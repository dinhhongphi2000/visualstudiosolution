namespace Models.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopDbContext : DbContext
    {
        public ShopDbContext()
            : base("data source=hongphi.database.windows.net;initial catalog=Test;user id=dinhhongphi_1996;password=KientriManhme!;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<USERACCOUNT> USERACCOUNT { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<USERACCOUNT>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<USERACCOUNT>()
                .Property(e => e.Pass)
                .IsUnicode(false);
        }
    }
}
