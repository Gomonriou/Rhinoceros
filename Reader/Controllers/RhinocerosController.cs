using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reader.Repository;
using MongoDB.Driver;
using Reader.Service;
using MongoDB.Bson;
using MongoDB.Driver.Linq;


namespace Reader.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class RhinocerosController : ControllerBase
    {
        private readonly RhinocerosService _departmentService;

        public RhinocerosController(RhinocerosService rhinocerosService)
        {
            _departmentService = rhinocerosService;
        }

        [HttpGet]                                               // https://localhost:5001/Rhinoceros/
        public ActionResult<List<ObjetDepartment>> Get() =>
            _departmentService.Get();  


        [HttpGet("{id:length(24)}", Name = "GetDepartment")]    // https://localhost:5001/Rhinoceros/6162d1050f4cf766959653bc
        public ActionResult<ObjetDepartment> Get(string id)
        {
            var NomDepartment = _departmentService.Get(id);

            if (NomDepartment == null)
            {
                return NotFound();
            }

            return NomDepartment;
        }

        [HttpPost("search")] // localhost/Rhino/Search
        public IActionResult Rechercher(Search search)
        {
            return Content("");
        }

    }    
}































        // [HttpGet]
        // [Route("byname/{name}")]
        // public async Task<ActionResult> GetByName(string name)
        // {   try
        //     {
        //         var filter = Builders<ObjetDepartment>.Filter;
        //         var eqFilter = filter.Eq(x => x.DepartmentsNom, name);

        //         var result = await dbCollection.FindAsync<ObjetDepartment>(eqFilter).ConfigureAwait(false);
        //         return Ok(result.FirstOrDefault());
        //     }
        //     finally
        //     {
        //         Console.WriteLine("casse les couilles");
        //     }
        // }


        // [HttpGet]
        // [Route("test")]        
        // public async Task<ActionResult<IEnumerable<ObjetDepartment>>> GetAll()
        // {
        //    FilterDefinitionBuilder<ObjetDepartment> filter = Builders<ObjetDepartment>.Filter;
        //    FilterDefinition<ObjetDepartment> emptyFilter = filter.Empty;

        //    IAsyncCursor<ObjetDepartment> allDocuments = await dbCollection.FindAsync<ObjetDepartment>(emptyFilter).ConfigureAwait(false);

        //    return Ok(allDocuments.ToList());
        // }