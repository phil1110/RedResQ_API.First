using Microsoft.AspNetCore.Mvc;
using RedResQ_API.Lib.Services;
using System.Data.SqlClient;
using RedResQ_API.Lib.Models;

namespace RedResQ_API.Service.Controllers;

[ApiController]
[Route("[controller]")]
public class SessionController : ControllerBase
{
    public SessionController()
    {
        
    }

    [HttpGet]
    public ActionResult<Session> Get(string password, string username = "", string email = "")
    {
        try
        {
            var output = SessionService.Login(username, email, password);
            
            if (output == null)
            {
                return NotFound();
            }
            else
            {
                return output;
            }
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}