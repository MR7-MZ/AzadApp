using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Azad.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DataContext _context;
        public WeatherForecastController(DataContext context)
        {
           _context = context;

        }   
        [HttpGet]

        public async Task<IActionResult> GetValues()
        {
          var values=await _context.Values.ToListAsync();
          return Ok(values); 
        }
        [HttpGet("{id}")]

        public async Task <IActionResult> GetValues(int id)
        {
          var values=await _context.Values.FirstOrDefaultAsync(x =>x.Id ==id);
          return Ok(values); 
        }
       
    }
}
