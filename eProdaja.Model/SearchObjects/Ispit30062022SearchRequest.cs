using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model.SearchObjects
{
    public class Ispit30062022SearchRequest:BaseSearchObject
    {
        public int Ispit30062022Id { get; set; }
        public int ProizvodiId { get; set; }
        public int KupciId { get; set; }
        public int MinimalniIznosNarudzbe { get; set; }
        public int BrojNarudzbe { get; set; }
        public int IznosNarudzbe { get; set; }
    }
}
