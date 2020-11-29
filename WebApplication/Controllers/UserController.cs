using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment1.Data;
using FileData;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _service;
        private FileContext _fileContext;

        public UserController(IUserService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<ActionResult<User>> GetUserValidation()
        {
            try
            {
                IList<User> users = await _service.GetUsersAsync();
                return Ok(users);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);            }
        }
        
        [HttpPost]
        public async Task<ActionResult<User>> addUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            { 
                await _service.AddUserAsync(user);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}