namespace RozproszneBazyDanych.Components.Models;
using System.ComponentModel.DataAnnotations;

public class NewMagazyn
{
    [Required(ErrorMessage = "Nazwa jest wymagane")]
    public string NodeId { get; set; } = "LOK1";
    
    [Required(ErrorMessage = "Wybierz produkt")]
    [Range(0, int.MaxValue, ErrorMessage = "Wybierz produkt z listy")]
    public int NazwaProduktu { get; set; }
    
    [Required]
    [Range(0, 500, ErrorMessage = "Ilość musi być większa od 0")]
    public int Ilosc { get; set; }
}