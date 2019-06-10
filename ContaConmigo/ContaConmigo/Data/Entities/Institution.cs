using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaConmigo.Data.Entities
{
    public class Institution
    {
        public int InstitutionId { get; set; }
        public string InstitutionDescription { get; set; }
        public string InstitutionAdress { get; set; }
        public int PhoneNumber { get; set; }
        public City City { get; set; }
    }
}
