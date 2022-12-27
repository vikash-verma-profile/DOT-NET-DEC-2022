using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApiProject.Models
{
    public partial class DemoAdoDBContext : DbContext
    {
        public DemoAdoDBContext()
        {
        }

        public DemoAdoDBContext(DbContextOptions<DemoAdoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDepartment> TblDepartments { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }
        public virtual DbSet<TblLogin> TblLogins { get; set; }
        public virtual DbSet<TblSample> TblSamples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-PP0TB7N;Initial Catalog=DemoAdoDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.ToTable("tblDepartment");

                entity.Property(e => e.Department).HasMaxLength(50);
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.ToTable("tblEmployee");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.ToTable("tblLogin");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSample>(entity =>
            {
                entity.ToTable("tblSample");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Text).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
