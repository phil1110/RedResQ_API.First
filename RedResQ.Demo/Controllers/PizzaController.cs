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
    public List<Pizza> GetAll() => PizzaService.GetAll();
    
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

    // PUT action

    // DELETE action
}