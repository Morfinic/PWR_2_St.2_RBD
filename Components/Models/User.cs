using Microsoft.EntityFrameworkCore;

namespace RozproszneBazyDanych.Components.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("USER_VIEW")]
public class User_View
{
    
    [Column("USER_ID")]
    [Key]
    public string UserId { get; set; }
    
    [Column("USERNAME")]
    public string Username { get; set; }
    
    [Column("USER_ROLE")]
    public string UserRole { get; set; }
    
    [Column("EMAIL")]
    public string Email { get; set; }
    
    [Column("USER_PASSWORD")]
    public string Password { get; set; }
}