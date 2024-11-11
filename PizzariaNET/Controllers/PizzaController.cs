using Microsoft.AspNetCore.Mvc;
using PizzariaNET.Repositories;

namespace PizzariaNET.Controllers;

[ApiController]
[Route("api/pizzas")]
public class PizzaController : ControllerBase
{
    private readonly IPizzaRepository _pizzaRepository;

    public PizzaController(IPizzaRepository pizzaRepository)
    {
        _pizzaRepository = pizzaRepository;
    }

    [HttpGet]
    public IActionResult ListAll()
    {
        var pizzas = _pizzaRepository.ListAll();

        return Ok(pizzas);
    }
}