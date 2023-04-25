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
         => optionsBuilder.UseSqlServer("Data Source=LAPTOP-HA5MSFQO\\SQLEXPRESS;Database=Rekrutacja;Integrated Security=True;Connect Timeout=30;Encrypt=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;TrustServerCertificate=True;");
}
