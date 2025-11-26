using Microsoft.EntityFrameworkCore;

namespace RozproszneBazyDanych.Components.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("GLOBAL_MAGAZYN")]
[Keyless]
public class Magazyn
{
    [Column("NODEID")]
    public string NodeId { get; set; }
    
    [Column("NAZWA_PRODUKTU")]
    public string NazwaProduktu { get; set; }
    
    [Column("ILOSC")]
    public int Ilosc { get; set; }
}