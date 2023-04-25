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

    [InverseProperty("Kandydat")]
    public virtual ICollection<Dokumenty> DokumentyKandydats { get; set; } = new List<Dokumenty>();

    [InverseProperty("Pracownicy")]
    public virtual ICollection<Dokumenty> DokumentyPracownicies { get; set; } = new List<Dokumenty>();

    [InverseProperty("Kandydat")]
    public virtual ICollection<Egzaminy> Egzaminies { get; set; } = new List<Egzaminy>();

    [ForeignKey("KierunekId")]
    [InverseProperty("Kandydacis")]
    public virtual Kierunki Kierunek { get; set; } = null!;

    [InverseProperty("Kandydat")]
    public virtual ICollection<Płatności> Płatnościs { get; set; } = new List<Płatności>();

    [ForeignKey("UżytkownikId")]
    [InverseProperty("Kandydacis")]
    public virtual Użytkownicy Użytkownik { get; set; } = null!;
}
