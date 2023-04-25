using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Rekrutacja.Models;

[Table("Kierunki")]
public partial class Kierunki
{
    [Key]
    [Column("kierunek_id")]
    public int KierunekId { get; set; }

    [Column("nazwa")]
    [StringLength(20)]
    public string Nazwa { get; set; } = null!;

    [Column("opis")]
    [StringLength(500)]
    public string Opis { get; set; } = null!;

    [Column("stopień_studiów")]
    public int StopieńStudiów { get; set; }

    [Column("tryb_studiów")]
    [StringLength(14)]
    public string TrybStudiów { get; set; } = null!;

    [Column("liczba_miejsc")]
    public int LiczbaMiejsc { get; set; }

    [InverseProperty("Kierunek")]
    public virtual ICollection<Kandydaci> Kandydacis { get; set; } = new List<Kandydaci>();
}
