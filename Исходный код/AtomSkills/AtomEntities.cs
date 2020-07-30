namespace AtomSkills
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AtomEntities : DbContext
    {
        public AtomEntities()
            : base("name=AtomEntities")
        {
        }

        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Functions> Functions { get; set; }
        public virtual DbSet<FunctionsRole> FunctionsRole { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RolesUser> RolesUser { get; set; }
        public virtual DbSet<Statuses> Statuses { get; set; }
        public virtual DbSet<TransportImages> TransportImages { get; set; }
        public virtual DbSet<Transports> Transports { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>()
                .HasMany(e => e.Transports)
                .WithRequired(e => e.Brands)
                .HasForeignKey(e => e.IDBrand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Functions>()
                .HasMany(e => e.FunctionsRole)
                .WithRequired(e => e.Functions)
                .HasForeignKey(e => e.IDFunction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.FunctionsRole)
                .WithRequired(e => e.Roles)
                .HasForeignKey(e => e.IDRole);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.RolesUser)
                .WithRequired(e => e.Roles)
                .HasForeignKey(e => e.IDRole);

            modelBuilder.Entity<Statuses>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Statuses)
                .HasForeignKey(e => e.IDStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transports>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Transports)
                .HasForeignKey(e => e.IDTrans)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transports>()
                .HasMany(e => e.TransportImages)
                .WithRequired(e => e.Transports)
                .HasForeignKey(e => e.IDTransport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.IDSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Orders1)
                .WithRequired(e => e.Users1)
                .HasForeignKey(e => e.IDOperator)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.RolesUser)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.IDUser)
                .WillCascadeOnDelete(false);
        }
    }
}
