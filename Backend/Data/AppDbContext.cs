using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Microsoft.EntityFrameworkCore;


namespace Backend.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<AppUser> AppUsers { get; set; } = default!;
    public DbSet<Group> Groups { get; set; } = default!;
    public DbSet<Restaurant> Restaurants {get;set;} = default!;
    public DbSet<Food> Foods {get;set;}=default!;
    protected override void OnModelCreating(ModelBuilder builder)
    {
      // TODO: Add seed data here
      builder.Entity<Restaurant>().HasData(
        new Restaurant(){
          RestaurantID = 1,
          Name = "McDonalds",
          Rating = 1
        }
      );



      builder.Entity<Food>().HasData(
        new Food(){
          FoodID = 1,
          RestaurantID = 1,
          Name = "Big Mac",
          Description = "The food of the only president to be charged with felonies."
        }
      );
//      base.OnModelCreating(builder);
    }
  }
}