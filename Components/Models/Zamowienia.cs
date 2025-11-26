using Microsoft.EntityFrameworkCore;

namespace RozproszneBazyDanych.Components.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ZAMOWIENIA_OPISOWE")]
[Keyless]
public class Zamowienia
{
    [Column("NAZWA_UZYTKOWNIKA")]
    public string Nazwa_Uzytkownika { get; set; }
    
    [Column("NAZWA_PRODUKTU")]
    public string Nazwa_Produktu { get; set; }
    
    [Column("DATA_UTWORZENIA")]
    public string Data_Utworzenia { get; set; }
    
    [Column("ORDER_STATUS")]
    public string Order_Status { get; set; }
}