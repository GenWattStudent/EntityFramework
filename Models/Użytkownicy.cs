﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Rekrutacja.Models;

[Table("Użytkownicy")]
public partial class Użytkownicy
{
    [Key]
    [Column("użytkownik_id")]
    public int UżytkownikId { get; set; }

    [Column("imię")]
    [StringLength(50)]
    public string Imię { get; set; } = null!;

    [Column("nazwisko")]
    [StringLength(50)]
    public string Nazwisko { get; set; } = null!;

    [Column("PESEL")]
    [StringLength(11)]
    public string Pesel { get; set; } = null!;

    [Column("telefon")]
    [StringLength(20)]
    public string Telefon { get; set; } = null!;

    [Column("email")]
    [StringLength(50)]
    public string? Email { get; set; }

    [Column("nr_dowodu")]
    [StringLength(20)]
    public string NrDowodu { get; set; } = null!;

    [Column("płeć")]
    [StringLength(10)]
    public string Płeć { get; set; } = null!;

    [Column("data_urodzenia", TypeName = "date")]
    public DateTime DataUrodzenia { get; set; }

    [InverseProperty("Użytkownik")]
    public virtual ICollection<Adresy> Adresies { get; set; } = new List<Adresy>();

    [InverseProperty("Użytkownik")]
    public virtual ICollection<Kandydaci> Kandydacis { get; set; } = new List<Kandydaci>();

    [InverseProperty("Użytkownik")]
    public virtual ICollection<Pracownicy> Pracownicies { get; set; } = new List<Pracownicy>();
}
