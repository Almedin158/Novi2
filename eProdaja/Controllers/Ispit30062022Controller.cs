using eProdaja.Model.Requests;
using eProdaja.Model.SearchObjects;
using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class Ispit30062022Controller : BaseCRUDController<Model.Ispit30062022, Ispit30062022SearchRequest, Ispit30062022UpsertRequest, Ispit30062022UpsertRequest>
    {
        public Ispit30062022Controller(IIspit30062022Service service)
            : base(service)
        {
        }
    }
}
