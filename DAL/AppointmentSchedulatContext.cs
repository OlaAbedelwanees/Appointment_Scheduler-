using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore.Tools;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AppointmentSchedulatContext : DbContext  
    {

        public AppointmentSchedulatContext(DbContextOptions<AppointmentSchedulatContext> options)  
            :base(options)  
        {  
            Database.EnsureCreated();  
        }  


        public DbSet<Appointment> Appointment { get; set; }  
        public DbSet<User> User { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)  
        {
            // modelBuilder.Entity<Appointment>()
            //     .HasOne<User>(s => s.User)
            //     .WithMany(g => g.Appointments)
            //     .HasForeignKey(s => s.UserId);

                 base.OnModelCreating(modelBuilder); 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test");
        }
    }
}