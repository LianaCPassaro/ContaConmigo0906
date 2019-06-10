using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaConmigo.Data.Entities
{
    public class Donor
    {
        public int DonorId { get; set; }
        public string Name_Don { get; set; }
        public string Last_Name_Don { get; set; }
        public City City { get; set; }
        public DateTime Last_Date_Blood_Extract { get; set; }
        public BloodGroup BloodGroupID { get; set; }
        public BloodFactor BloodFactorID { get; set; }
    }
}
