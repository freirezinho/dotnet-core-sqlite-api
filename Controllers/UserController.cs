using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using server.Models;
using server;
namespace server.Controllers
{
    [EnableCors("AllowAll")]
    [ApiController]
    [Route("/users")]

    public class UserController : ControllerBase
    {
        SQLiteDbContext db = new SQLiteDbContext();

        [HttpGet]
        public User Get()
        {
            User user = db.Users
                            .First();
            return user;
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult NewUser([FromBody] User obj)

        {
            User user = new User();
            user.Name = obj.Name;
            user.Email = obj.Email;
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return Ok(user);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }
    }
}