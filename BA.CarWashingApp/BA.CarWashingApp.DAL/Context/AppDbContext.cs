using BA.CarWashingApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.DAL.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DirtStatus> DirtStatuses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Material>  Materials { get; set; }
        public DbSet<MaterialWashingRecipe> MaterialWashingRecipes { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Washing> Washings { get; set; }
        public DbSet<WashingRecipe> WashingRecipes { get; set; }
        public DbSet<WashingStep> WashingSteps { get; set; }
        public DbSet<WashingType> WashingTypes { get; set; }
        public DbSet<WashingTypeWashing> WashingTypeWashings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=OZAN;Initial Catalog=CarWashingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
