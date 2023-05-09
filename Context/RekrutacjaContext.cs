using Microsoft.EntityFrameworkCore;
using Rekrutacja.Models;

namespace Rekrutacja.Context;

public partial class RekrutacjaContext : DbContext
{
    public virtual DbSet<Adresy> Adresy { get; set; }

    public virtual DbSet<Dokumenty> Dokumenty { get; set; }

    public virtual DbSet<Egzaminy> Egzaminy { get; set; }

    public virtual DbSet<Kandydaci> Kandydaci { get; set; }

    public virtual DbSet<Kierunki> Kierunki { get; set; }

    public virtual DbSet<Pracownicy> Pracownicy { get; set; }

    public virtual DbSet<Płatności> Płatności { get; set; }

    public virtual DbSet<Użytkownicy> Użytkownicy { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer("Data Source=LAPTOP-HA5MSFQO\\SQLEXPRESS;Database=Test_Rekrutacji;Integrated Security=True;Connect Timeout=30;Encrypt=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Użytkownicy>()
            .HasMany(u => u.Adresy)
            .WithOne(u => u.Użytkownik)
            .HasForeignKey(u => u.UżytkownikId);

        modelBuilder.Entity<Użytkownicy>()
            .HasOne(u => u.Pracownicy)
            .WithOne(u => u.Użytkownik)
            .HasForeignKey<Pracownicy>(u => u.PracownikId)
            .OnDelete(DeleteBehavior.NoAction)
            .HasConstraintName("FK_Dokumenty_Pracownicy_PracownicyID")
            .IsRequired();

        modelBuilder.Entity<Dokumenty>()
            .HasOne(u => u.Pracownicy)
            .WithMany(u => u.DokumentyPracowników)
            .HasForeignKey(u => u.PracownicyId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Kandydaci>()
            .HasOne(u => u.Użytkownik)
            .WithOne(u => u.Kandydaci)
            .HasForeignKey<Użytkownicy>(u => u.UżytkownikId);

        modelBuilder.Entity<Kandydaci>()
            .HasOne(u => u.Kierunek)
            .WithOne(u => u.Kandydaci)
            .HasForeignKey<Kandydaci>(u => u.KierunekId);

        modelBuilder.Entity<Kandydaci>()
            .HasMany(u => u.Płatności)
            .WithOne(u => u.Kandydat)
            .HasForeignKey(u => u.KandydatId);

        modelBuilder.Entity<Kandydaci>()
            .HasMany(u => u.Egzaminy)
            .WithOne(u => u.Kandydat)
            .HasForeignKey(u => u.KandydatId);

        modelBuilder.Entity<Kandydaci>()
            .HasMany(u => u.Dokumenty)
            .WithOne(u => u.Kandydaci)
            .HasForeignKey(u => u.KandydatId);
    }
}
