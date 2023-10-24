using Microsoft.AspNetCore.Mvc;
using RedResQ_API.Lib.Services;
using System.Data.SqlClient;

namespace RedResQ_API.Service.Controllers;

[ApiController]
[Route("[controller]")]
public class SessionController : ControllerBase
{
    public SessionController()
    {
        
    }

    [HttpGet]
    public ActionResult<object> Get(string password, string username = "", string email = "")
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
}