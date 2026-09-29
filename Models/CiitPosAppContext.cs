using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Inventy_Demo_MVC_Core.models;

public partial class CiitPosAppContext : DbContext
{
    public CiitPosAppContext()
    {
    }

    public CiitPosAppContext(DbContextOptions<CiitPosAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

    public virtual DbSet<TblCustomer> TblCustomers { get; set; }

    public virtual DbSet<TblInvoicePayment> TblInvoicePayments { get; set; }

    public virtual DbSet<TblInvoiceProduct> TblInvoiceProducts { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ANISHKA;Database=CIIT_POS_App;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InvoiceDetail>(entity =>
        {
            entity.HasKey(e => e.InvoiceId).HasName("PK__InvoiceD__D796AAB5294E21A1");

            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CustomerId");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.InvoiceDetails)
                .HasForeignKey(d => d.FkCustomerId)
                .HasConstraintName("FK_CustId");
        });

        modelBuilder.Entity<TblCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__tblCusto__A4AE64D887F0E4D4");

            entity.ToTable("tblCustomer");

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblInvoicePayment>(entity =>
        {
            entity.HasKey(e => e.InvoicePaymentId).HasName("PK__tblInvoi__A79CC7FEB6CA83A4");

            entity.ToTable("tblInvoicePayments");

            entity.Property(e => e.FkInvoiceId).HasColumnName("Fk_InvoiceId");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDescription).HasMaxLength(100);
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.FkInvoice).WithMany(p => p.TblInvoicePayments)
                .HasForeignKey(d => d.FkInvoiceId)
                .HasConstraintName("FK_InvoId");
        });

        modelBuilder.Entity<TblInvoiceProduct>(entity =>
        {
            entity.HasKey(e => e.InvoiceProductId).HasName("PK__tblInvoi__D032D0C90E39E9A2");

            entity.ToTable("tblInvoiceProducts");

            entity.Property(e => e.FkInvoiceId).HasColumnName("Fk_InvoiceId");
            entity.Property(e => e.FkProductId).HasColumnName("Fk_ProductId");

            entity.HasOne(d => d.FkInvoice).WithMany(p => p.TblInvoiceProducts)
                .HasForeignKey(d => d.FkInvoiceId)
                .HasConstraintName("FK_InvId");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.TblInvoiceProducts)
                .HasForeignKey(d => d.FkProductId)
                .HasConstraintName("FK_ProdId");
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__tblProdu__B40CC6CD95045C6B");

            entity.ToTable("tblProducts");

            entity.Property(e => e.Gst).HasColumnName("GST");
            entity.Property(e => e.ProductName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
