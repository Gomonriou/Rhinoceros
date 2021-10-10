using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using reader.Service;




namespace reader.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class RhinocerosController : ControllerBase
    {

        [HttpGet]
        [Route("{name}")]
        public IEnumerable<Rhinoceros> Get(string name)
        {
            return RhinocerosService.GetDepartmentByName(name);           
        }

        // [HttpGet]
        // [Route("All")]
        // public ActionResult<IEnumerable<Pizza>> GetAll()
        // {
        //     try
        //     {
        //        return Ok(PizzaService.Getall());
        //     }   
        //     catch (Exception e)
        //     {
        //         Console.WriteLine(e.Message);
        //         return StatusCode(500);
        //     }         
        // }

    }    
}