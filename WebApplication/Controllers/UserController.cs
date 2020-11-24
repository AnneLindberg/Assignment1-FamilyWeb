using System;
using System.Threading.Tasks;
using Assignment1.Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<ActionResult<User>> GetUserValidation([FromQuery] string username, string password)
        {
            try
            {
                User user = await _service.ValidateUser(username, password);
                Console.WriteLine(user.UserName);
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);            }
        }
    }
}