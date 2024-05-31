using System;
using System.Collections.Generic;
using AccesoDeDatos.Models;
using Microsoft.EntityFrameworkCore;

namespace AccesoDeDatos.Data;

public partial class AutoLotContext : DbContext
{
    public AutoLotContext()
    {
    }

    public AutoLotContext(DbContextOptions<AutoLotContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CreditRisk> CreditRisks { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-D84T50G\\SQLEXPRES;Database= AutoLot;Trusted_Connection=True;TrustServerCertificate=True;");
    //tener cuidado con la ruta que esta arriba de este comentario
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<CreditRisk>(entity =>
        {
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.Customer).WithMany(p => p.CreditRisks).HasConstraintName("FK_CreditRisks_Customers");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
