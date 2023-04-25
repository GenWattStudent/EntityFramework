using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Rekrutacja.Models;

[Table("Dokumenty")]
public partial class Dokumenty
{
    [Key]
    [Column("dokument_id")]
    public int DokumentId { get; set; }

    [Column("kandydat_id")]
    public int KandydatId { get; set; }

    [Column("pracownicy_id")]
    public int PracownicyId { get; set; }

    [Column("rodzaj")]
    [StringLength(20)]
    public string Rodzaj { get; set; } = null!;

    [Column("status")]
    [StringLength(20)]
    public string Status { get; set; } = null!;

    [Column("uwagi")]
    [StringLength(250)]
    public string? Uwagi { get; set; }

    [Column("komentarz")]
    [StringLength(250)]
    public string? Komentarz { get; set; }

    [Column("ścieżka_dokumentu")]
    [StringLength(100)]
    public string ŚcieżkaDokumentu { get; set; } = null!;

    [Column("data_przesłania", TypeName = "date")]
    public DateTime DataPrzesłania { get; set; }

    [Column("data_aktualizacji_statusu", TypeName = "date")]
    public DateTime DataAktualizacjiStatusu { get; set; }

    [ForeignKey("KandydatId")]
    [InverseProperty("DokumentyKandydats")]
    public virtual Kandydaci Kandydat { get; set; } = null!;

    [ForeignKey("PracownicyId")]
    [InverseProperty("DokumentyPracownicies")]
    public virtual Kandydaci Pracownicy { get; set; } = null!;
}
