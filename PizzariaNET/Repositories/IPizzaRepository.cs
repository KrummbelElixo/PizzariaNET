using PizzariaNET.Models;

namespace PizzariaNET.Repositories;

public interface IPizzaRepository
{
    List<Pizza> ListAll();
}