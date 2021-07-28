using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.Data
{
    public class CabsBookingDbContext: DbContext
    {
        public CabsBookingDbContext(DbContextOptions<CabsBookingDbContext> options): base(options)
        {

        }
        public DbSet <Bookings> Bookings { get; set; }
        public DbSet <Places> Places { get; set; }
        public DbSet <CabTypes> CabTypes { get; set; }
        public DbSet <Bookings_History> Bookings_Histories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CabTypes>(ConfigureCabTypes);
            modelBuilder.Entity<Bookings>(ConfigureBookings);
            modelBuilder.Entity<Bookings_History>(ConfigureBookings_History);
            modelBuilder.Entity<Places>(ConfigurePlaces);
            modelBuilder.Entity<Bookings>().HasOne(b => b.Place).WithMany(p => p.Bookings).HasForeignKey(b => b.ToPlace);
            modelBuilder.Entity<Bookings_History>().HasOne(b => b.Place).WithMany(p => p.Bookings_Histories).HasForeignKey(b => b.ToPlace);
        }

        //Fluent API

        private void ConfigurePlaces(EntityTypeBuilder<Places> builder)
        {
            builder.ToTable("Places");
            builder.HasKey(p => p.PlaceId);
        }
       
        private void ConfigureBookings(EntityTypeBuilder<Bookings> builder)
        {
            builder.ToTable("Bookings");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Email).HasMaxLength(50).IsRequired(false);
            builder.Property(b => b.BookingTime).HasMaxLength(5);
            builder.Property(b => b.PickupAddress).HasMaxLength(300).IsRequired(false);
            builder.Property(b => b.Landmark).HasMaxLength(30).IsRequired(false);
            builder.Property(b => b.PickupTime).HasMaxLength(5).IsRequired(false);
            builder.Property(b => b.ContactNo).HasMaxLength(25).IsRequired(false);
            builder.Property(b => b.Status).HasMaxLength(30).IsRequired(false);          
        }

         private void ConfigureCabTypes(EntityTypeBuilder<CabTypes> builder)
        {
            builder.ToTable("CabTypes");
            builder.HasKey(ct => ct.CabTypeId);
            builder.Property(ct => ct.CabTypeName).HasMaxLength(30);
        }

        private void ConfigureBookings_History(EntityTypeBuilder<Bookings_History> builder)
        {
            builder.ToTable("Bookings_history");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Email).HasMaxLength(50).IsRequired(false);
            builder.Property(b => b.BookingTime).HasMaxLength(5).IsRequired(false);
            builder.Property(b => b.PickupAddress).HasMaxLength(300).IsRequired(false);
            builder.Property(b => b.Landmark).HasMaxLength(30).IsRequired(false);
            builder.Property(b => b.PickupTime).HasMaxLength(5).IsRequired(false);
            builder.Property(b => b.ContactNo).HasMaxLength(25).IsRequired(false);
            builder.Property(b => b.Status).HasMaxLength(30).IsRequired(false);
            builder.Property(b => b.charge).IsRequired(false);
            builder.Property(b => b.Feedback).HasMaxLength(1000).IsRequired(false);
            builder.Property(b => b.comp_time).HasMaxLength(5).IsRequired(false);
        }
    }

}
