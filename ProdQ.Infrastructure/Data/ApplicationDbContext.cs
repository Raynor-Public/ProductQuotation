using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProdQ.Infrastructure.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Qoute> Qoutes { get; set; }

    public virtual DbSet<QouteItem> QouteItems { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=IT-RAYNOR-LPTOP\\MSSQL2012FULLED;Database=Quotation;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__product__3213E83FA4E2ADC2");

            entity.ToTable("product");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createddate).HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("price");
        });

        modelBuilder.Entity<Qoute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__qoute__3213E83F9F83ED40");

            entity.ToTable("qoute");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createddate).HasColumnName("createddate");
            entity.Property(e => e.Subject)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("subject");
            entity.Property(e => e.TotalPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("totalPrice");
            entity.Property(e => e.ValidUntil).HasColumnName("validUntil");
        });

        modelBuilder.Entity<QouteItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__qouteIte__3213E83F910140F5");

            entity.ToTable("qouteItem");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("price");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.QouteId).HasColumnName("qouteId");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Qoute).WithMany(p => p.QouteItems)
                .HasForeignKey(d => d.QouteId)
                .HasConstraintName("FK_qouteItem_qouteId");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user__3213E83FCFF4151D");

            entity.ToTable("user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createddate).HasColumnName("createddate");
            entity.Property(e => e.Fullname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("fullname");
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
