﻿using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Infrastructure.Configurations;

namespace Infrastructure.Persistance.MSSqlServer
{
    public class DbContextMSSqlServer : DbContext
    {
        public DbContextMSSqlServer(DbContextOptions<DbContextMSSqlServer> options) : base(options) { }
        public DbSet<Country> Countries {  get; set; }
        public DbSet<Substance> Substances { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Dose> Doses { get; set; }
        public DbSet<Medform> Medforms { get; set; }
        public DbSet<DoseMedicine> DoseMedicines { get; set; }
        public DbSet<MedicineSubstance> MedicineSubstances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MedicineConfiguration());
            modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new DoseMedicineConfiguration());
            modelBuilder.ApplyConfiguration(new MedicineSubstanceConfiguration());
            modelBuilder.ApplyConfiguration(new MedformConfiguration());
            modelBuilder.ApplyConfiguration(new DoseConfiguration());
            modelBuilder.ApplyConfiguration(new SubstanceConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }

    
}
