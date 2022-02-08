using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DogWalkingAppAuth.Models
{
    public partial class DogWalkingDataContext : DbContext
    {
        public DogWalkingDataContext()
            : base("name=DogWalkingDataContext")
        {
        }

        public virtual DbSet<Dog> Dogs { get; set; }
        public virtual DbSet<DogWalking> DogWalkings { get; set; }
        public virtual DbSet<Walker> Walkers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dog>()
                .Property(e => e.DogName)
                .IsUnicode(false);

            modelBuilder.Entity<Dog>()
                .Property(e => e.DogBreed)
                .IsUnicode(false);

            modelBuilder.Entity<DogWalking>()
                .Property(e => e.Distance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DogWalking>()
                .Property(e => e.Affirmations)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Walker>()
                .Property(e => e.Walker_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Walker>()
                .Property(e => e.Role)
                .IsUnicode(false);
        }
    }
}
