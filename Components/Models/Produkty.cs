using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RozproszneBazyDanych.Components.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("PRODUKTY")]
public class Produkty
{
    [Key]
    [Column("PID")]
    public int PID { get; set; }
    
    [Column("NAZWA")]
    public string? Nazwa { get; set; }
    
    [Column("CENA")]
    public double? Cena { get; set; }
    
    [Column("KATEGORIA")]
    public string? Kategoria { get; set; }
}