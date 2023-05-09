using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Rekrutacja.Models;

[Table("Adresy")]
public partial class Adresy
{
    [Key]
    [Column("adres_id")]
    public int AdresId { get; set; }

    [Column("użytkownik_id")]
    public int UżytkownikId { get; set; }

    [Column("państwo")]
    [StringLength(30)]
    public string Państwo { get; set; } = null!;

    [Column("miasto")]
    [StringLength(40)]
    public string Miasto { get; set; } = null!;

    [Column("ulica")]
    [StringLength(30)]
    public string Ulica { get; set; } = null!;

    [Column("numer")]
    [StringLength(10)]
    public string Numer { get; set; } = null!;

    public virtual Użytkownicy Użytkownik { get; set; }
}
