using PizzariaNET.Data;
using PizzariaNET.Models;

namespace PizzariaNET.Repositories;

public class PizzaRepository : IPizzaRepository
{
   private readonly ApplicationDBContext _context;
   
   public PizzaRepository(ApplicationDBContext context)
   {
      _context = context;
   }

   public List<Pizza> ListAll()
   {
      return _context.Pizzas.ToList();
   }
}