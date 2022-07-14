using AutoMapper;
using eProdaja.Model.Requests;
using eProdaja.Model.SearchObjects;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class Ispit30062022Service : BaseCRUDService<Model.Ispit30062022, Database.Ispit30062022, Ispit30062022SearchRequest, Ispit30062022UpsertRequest, Ispit30062022UpsertRequest>, IIspit30062022Service
    {
        public Ispit30062022Service(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
