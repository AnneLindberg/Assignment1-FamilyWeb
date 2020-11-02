
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyWeb1.Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultsController : ControllerBase
    {
        private IAdultService _adultService;

        public AdultsController(IAdultService adultService)
        {
            _adultService = adultService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults()
        {
            try
            {
                IList<Adult> adults = await _adultService.GetAdultsAsync();
                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        
        
        
    }
}