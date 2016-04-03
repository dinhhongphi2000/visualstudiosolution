namespace Model.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NhatruongDbContext : DbContext
    {
        public NhatruongDbContext()
            : base("data source=hongphi.database.windows.net;initial catalog=Test;user id=dinhhongphi_1996;password=KientriManhme!;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<SINHVIEN> SINHVIEN { get; set; }
        public virtual DbSet<USERACCOUNT> USERACCOUNT { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MSSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.HOTEN)
                .IsUnicode(false);

            modelBuilder.Entity<USERACCOUNT>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<USERACCOUNT>()
                .Property(e => e.Pass)
                .IsUnicode(false);
        }
    }
}
