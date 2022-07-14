using eProdaja.Model.Requests;
using eProdaja.Model.SearchObjects;
using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class KupciController : BaseCRUDController<Model.Kupci, KupciSearchRequest, KupciUpsertRequest, KupciUpsertRequest>
    {
        public KupciController(IKupciService service)
            : base(service)
        {
        }
    }
}
