namespace MVc_2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SnacksDB : DbContext
    {
        public SnacksDB()
            : base("name=SnacksDB")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Snack> Snacks { get; set; }
        public virtual DbSet<SnackList> SnackLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Permissions)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Snack>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SnackList>()
                .Property(e => e.SnackID)
                .IsUnicode(false);

            modelBuilder.Entity<SnackList>()
                .Property(e => e.AccountID)
                .IsUnicode(false);

            modelBuilder.Entity<SnackList>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<SnackList>()
                .Property(e => e.name)
                .IsUnicode(false);
        }

        internal static SnacksDB Create()
        {
            return new SnacksDB();
        }
    }
}
