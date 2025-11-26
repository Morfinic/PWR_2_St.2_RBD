namespace RozproszneBazyDanych.Components.Models;
using System.ComponentModel.DataAnnotations;

public class NewProdukt
{
    [Required(ErrorMessage = "Nazwa jest wymagane")]
    public string Nazwa { get; set; }
    
    [Required]
    [Range(0.01, 5000.0, ErrorMessage = "Cena musi być większa od 0")]
    public decimal Cena { get; set; }
    
    [Required(ErrorMessage = "Kategoria jest wymagane")]
    public string Kategoria { get; set; }
}