namespace RozproszneBazyDanych.Components.Models;
using System.ComponentModel.DataAnnotations;

public class NewZamowienie
{
    [Required(ErrorMessage = "Wybierz produkt")]
    [Range(0, int.MaxValue, ErrorMessage = "Wybierz produkt z listy")]
    public int IdProduktu { get; set; }
    
    [Required(ErrorMessage = "Wybierz użytkownika")]
    [Range(0, int.MaxValue, ErrorMessage = "Wybierz użytkownika z listy")]
    public int IdUzytkownika { get; set; }
}