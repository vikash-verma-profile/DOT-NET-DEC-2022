using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProductWebApi.Models;

public partial class ProductDb1Context : DbContext
{
    public ProductDb1Context()
    {
    }

    public ProductDb1Context(DbContextOptions<ProductDb1Context> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
