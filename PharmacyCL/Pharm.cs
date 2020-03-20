using PharmacyCL.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace PharmacyCL
{
    public class Pharm : DbContext
    {
        public Pharm(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<PharmacyBranch> PharmacyBranches { get; set; }

    }
}
