namespace RozproszneBazyDanych.Components.Models;
using System.ComponentModel.DataAnnotations;


public class NewUser
{
    [Required(ErrorMessage = "Nazwa jest wymagane")]
    public string Username { get; set; }
    
    [Required(ErrorMessage = "Rola jest wymagana")]
    public string User_Role { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }
}