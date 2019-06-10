using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaConmigo.Data.Entities
{
    public class City
    {
        public int CityId {get;set;}
        public string CityName { get;set;}
        public int ZipCode { get; set; }
        public Province ProvinceId{ get; set; }
    }
}
