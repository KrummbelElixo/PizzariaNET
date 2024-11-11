using Microsoft.EntityFrameworkCore;
using PizzariaNET.Models;

namespace PizzariaNET.Data;

public class ApplicationDBContext : DbContext
{
    public DbSet<Pizza> Pizzas { get; set; }

    public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        
    }
}