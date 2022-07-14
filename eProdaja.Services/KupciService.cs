using AutoMapper;
using eProdaja.Model.Requests;
using eProdaja.Model.SearchObjects;
using eProdaja.Services.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KupciService : BaseCRUDService<Model.Kupci, Database.Kupci, KupciSearchRequest, KupciUpsertRequest, KupciUpsertRequest>, IKupciService
    {
        public KupciService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Kupci> Get(KupciSearchRequest search = null)
        {

            if (search.Ime != null)
            {
                var kupciIme = Context.Kupcis.Where(x=>x.Ime==search.Ime);
                return Mapper.Map<List<Model.Kupci>>(kupciIme);
            }

            if (search.ProizvodiId == 0)
            {
                return base.Get(search);
            }

            var kupci = Context.Kupcis.Include(x => x.Narudzbes).ThenInclude(x => x.NarudzbaStavkes).ThenInclude(x => x.Proizvod);

            bool pronadjen;

            List<Kupci> kup = new List<Kupci>();

            foreach(var kupac in kupci)
            {
                pronadjen = false;
                foreach(var narudzba in kupac.Narudzbes)
                {
                    foreach(var narduzbaStavka in narudzba.NarudzbaStavkes)
                    {
                        if(narduzbaStavka.Kolicina*narduzbaStavka.Proizvod.Cijena>=search.MinimalniIznosNovca && narduzbaStavka.ProizvodId == search.ProizvodiId){
                            if (pronadjen == false)
                            {
                                kup.Add(kupac);
                                pronadjen = true;
                            }
                        }
                    }
                }
            }

            return Mapper.Map<List<Model.Kupci>>(kup);
        }
    }
}
