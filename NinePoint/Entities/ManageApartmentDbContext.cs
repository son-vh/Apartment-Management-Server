namespace NinePoint.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ManageApartmentDbContext : DbContext
    {
        public ManageApartmentDbContext()
            : base("name=ManageApartmentDbContext")
        {
        }

        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<JobInfo> JobInfoes { get; set; }
        public virtual DbSet<Resident> Residents { get; set; }
        public virtual DbSet<Support> Supports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipment>()
                .Property(e => e.EquipmentImage)
                .IsUnicode(false);

            modelBuilder.Entity<JobInfo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<JobInfo>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.Room)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.Floor)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.ResidentImage)
                .IsUnicode(false);

            modelBuilder.Entity<Support>()
                .Property(e => e.SupportImage)
                .IsUnicode(false);
        }
    }
}
