using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaConmigo.Data.Entities
{
    public class RequestDonor
    {
        public int RequestDonorId { get; set; }
        public string Name_Request_Don { get; set; }
        public string Last_Name_Request_Don { get; set; }
        public int CityId { get; set; }
        public int ZipCode { get; set; }
        public DateTime Last_Date_Replacement { get; set; }
        public int AmountDonor { get; set; }
        public Institution InstitutionId { get; set; }
        public BloodGroup BloodGroupId { get; set; }
        public BloodFactor BloodFactorId { get; set; }
        public string Comments { get; set; }
        public int Phone_Number { get; set; }

    }
}
