using System.Net;
using RedResQ.Demo.Models;
using RedResQ.Demo.Services;
using Microsoft.AspNetCore.Mvc;
using RedResQ_API.Lib;

namespace RedResQ.Demo.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }
    
    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();
    
    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if (pizza == null)
        {
            return NotFound();
        }

        return pizza;
    }

	// POST action
	[HttpPost]
	public IActionResult Create(Pizza pizza)
	{
		PizzaService.Add(pizza);
		return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
	}

	// PUT action
	[HttpPut("{id}")]
	public IActionResult Update(int id, Pizza[] pizzas)
	{
		if (id != pizzas[0].Id)
			return BadRequest();

		var existingPizza = PizzaService.Get(id);
		if (existingPizza is null)
			return NotFound();

		PizzaService.Update(pizzas[0]);

		return NoContent();
	}

	// DELETE action
	[HttpDelete("{id}")]
	public IActionResult Delete(int id)
	{
		var pizza = PizzaService.Get(id);

		if (pizza is null)
			return NotFound();

		PizzaService.Delete(id);

		return NoContent();
	}
}