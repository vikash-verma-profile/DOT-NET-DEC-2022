using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SampleApi.Models;

public partial class DbSampleContext : DbContext
{
    public DbSampleContext()
    {
    }

    public DbSampleContext(DbContextOptions<DbSampleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblSample> TblSamples { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-PP0TB7N;Initial Catalog=DbSample;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblSample>(entity =>
        {
            entity.ToTable("tblSample");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
