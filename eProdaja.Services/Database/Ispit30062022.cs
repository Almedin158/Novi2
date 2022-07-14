using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.Database
{
    public class Ispit30062022
    {
        public int Ispit30062022Id {get;set;}
        public int ProizvodiId { get; set; }
        public virtual Proizvodi Proizvodi { get; set; }
        public int KupciId { get; set; }
        public virtual Kupci Kupci { get; set; }
        public int MinimalniIznosNarudzbe { get; set; }
        public int BrojNarudzbe { get; set; }
        public int IznosNarudzbe { get; set; }
    }
}
