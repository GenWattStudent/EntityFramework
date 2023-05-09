using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Rekrutacja.Models;

[Table("Kandydaci")]
public partial class Kandydaci
{
    [Key]
    [Column("kandydat_id")]
    public int KandydatId { get; set; }

    [Column("użytkownik_id")]
    public int UżytkownikId { get; set; }

    [Column("kierunek_id")]
    public int KierunekId { get; set; }

    [Column("status")]
    [StringLength(20)]
    public string Status { get; set; } = null!;

    [Column("ścieżka_zdjęcia")]
    [StringLength(100)]
    public string? ŚcieżkaZdjęcia { get; set; }

    [Column("data_aplikacji", TypeName = "date")]
    public DateTime DataAplikacji { get; set; }

    [Column("data_aktualizacji_statusu", TypeName = "date")]
    public DateTime DataAktualizacjiStatusu { get; set; }

    public virtual ICollection<Dokumenty> Dokumenty { get; set; } = new List<Dokumenty>();

    public virtual ICollection<Egzaminy> Egzaminy { get; set; } = new List<Egzaminy>();

    public virtual Kierunki Kierunek { get; set; }

    public virtual ICollection<Płatności> Płatności { get; set; } = new List<Płatności>();

    public virtual Użytkownicy Użytkownik { get; set; }
}
