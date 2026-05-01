using EventHub.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Configuration
{
    public class AppDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHub;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasMany(e => e.Sessions).WithOne(s => s.MyEvent);
            modelBuilder.Entity<Event>().HasMany(e => e.Notes).WithOne(n => n.MyEvent);
            modelBuilder.Entity<ProfilePage>().HasKey(p => p.OrganizerId);
            modelBuilder.Entity<Organizer>().HasOne(o => o.Profile).WithOne(p => p.MyOrganizer)
                                            .HasForeignKey<ProfilePage>(p => p.OrganizerId);

            modelBuilder.ApplyConfiguration(new AttendeeConfiguration());

        }

        DbSet<Organizer> Organizers { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<Session> Sessions { get; set; }   
        DbSet<Attendee> Attendees { get; set; }
        DbSet<Badge> Badges {  get; set; }  
        DbSet<Note> Notes {  get; set; }  


    }
}
