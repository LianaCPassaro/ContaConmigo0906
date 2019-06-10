using ContaConmigo.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ContaConmigo.Data
{
    public class ContaContext : DbContext
    {
        public ContaContext(DbContextOptions<ContaContext> options) : base(options)
        {
        }
        
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Institution> Institutions{ get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Donor> Donors{ get; set; }
        public DbSet<RequestDonor> RequestDonors{ get; set; }
        public DbSet<BloodFactor> BloodFactors { get; set; }


    }
}
