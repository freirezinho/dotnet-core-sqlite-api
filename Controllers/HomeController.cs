using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using server.Models;

namespace server.Controllers
{
    [ApiController]
    [Route("/")]

    public class HomeController : ControllerBase
    {
        [HttpGet]
        // public User Get()
        // {
        //     User user = new User();
        //     user.Id = 1;
        //     user.Name = "teste";
        //     user.Email = "teste@mail.com";
        //     return user;
        // }
        public ServiceStatus Get()
        {
            ServiceStatus status = new ServiceStatus();
            status.timestamp = DateTime.Now;
            status.active = true;
            return status;
        }
    }
}