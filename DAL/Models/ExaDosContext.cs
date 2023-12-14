using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class ExaDosContext : DbContext
{
    public ExaDosContext()
    {
    }

    public ExaDosContext(DbContextOptions<ExaDosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accione> Acciones { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<Vajilla> Vajillas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=exaDos;Username=postgres;Password=Flash12311");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accione>(entity =>
        {
            entity.HasKey(e => e.IdAccion).HasName("acciones_pkey");

            entity.ToTable("acciones", "esqexados");

            entity.Property(e => e.IdAccion).HasColumnName("id_accion");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdReserva).HasColumnName("id_reserva");
            entity.Property(e => e.IdVajilla).HasColumnName("id_vajilla");

            entity.HasOne(d => d.IdReservaNavigation).WithMany(p => p.Acciones)
                .HasForeignKey(d => d.IdReserva)
                .HasConstraintName("fk_acciones_id_reserva");

            entity.HasOne(d => d.IdVajillaNavigation).WithMany(p => p.Acciones)
                .HasForeignKey(d => d.IdVajilla)
                .HasConstraintName("fk_acciones_id_vajilla");
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.IdReserva).HasName("reservas_pkey");

            entity.ToTable("reservas", "esqexados");

            entity.Property(e => e.IdReserva).HasColumnName("id_reserva");
            entity.Property(e => e.FchReserva)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fch_reserva");
        });

        modelBuilder.Entity<Vajilla>(entity =>
        {
            entity.HasKey(e => e.IdElemento).HasName("vajillas_pkey");

            entity.ToTable("vajillas", "esqexados");

            entity.Property(e => e.IdElemento).HasColumnName("id_elemento");
            entity.Property(e => e.CantidadElemento).HasColumnName("cantidad_elemento");
            entity.Property(e => e.CodigoElemento)
                .HasMaxLength(255)
                .HasColumnName("codigo_elemento");
            entity.Property(e => e.DescripcionElemento)
                .HasMaxLength(255)
                .HasColumnName("descripcion_elemento");
            entity.Property(e => e.NombreElemento)
                .HasMaxLength(255)
                .HasColumnName("nombre_elemento");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
