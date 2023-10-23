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
    public ActionResult<object> Get()
    {
        return SessionService.Login("", "", "");
    }
}