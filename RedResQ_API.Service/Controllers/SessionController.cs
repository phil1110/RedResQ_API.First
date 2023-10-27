﻿using Microsoft.AspNetCore.Mvc;
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
    public ActionResult<Session> Get(string id, string secret)
    {
        try
        {
            var output = SessionService.Login(id, secret);
            
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