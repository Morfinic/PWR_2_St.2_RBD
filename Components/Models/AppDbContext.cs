namespace RozproszneBazyDanych.Components.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Produkty> Produkty { get; set; }
    public DbSet<User_View> User_View { get; set; }
    public DbSet<Magazyn> Global_Magazyn { get; set; }
    public DbSet<Zamowienia> Zamowienia { get; set; }
}