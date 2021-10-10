using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
// using reader.Service;
using Reader.Repository;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;


namespace Reader.Controllers
{
    [ApiController]
    [Route("[controller]")]


    public class ReaderController : ControllerBase
    {

        private static MongoClient client;
        private static IMongoDatabase db;
        private static IMongoCollection<ObjetDepartment> dbCollection;

        public void BoardGamesController()
        {
            client = new MongoClient("mongodb+srv://root:toor@rhinoceros.jkqed.mongodb.net/Rhinoceros?retryWrites=true&w=majority");
            db = client.GetDatabase("Rhinoceros");
            dbCollection = db.GetCollection<ObjetDepartment>("Departments");
        }


        [HttpGet]
        [Route("byname/{name}")]
        public async Task<ActionResult> GetByName(string name)
        {   try
            {
                var filter = Builders<ObjetDepartment>.Filter;
                var eqFilter = filter.Eq(x => x.DepartmentsNom, name);

                var result = await dbCollection.FindAsync<ObjetDepartment>(eqFilter).ConfigureAwait(false);
                return Ok(result.FirstOrDefault());
            }
            finally
            {
                Console.WriteLine("naze");
            }
        }


        [HttpGet]
        [Route("test")]        
        public async Task<ActionResult<IEnumerable<ObjetDepartment>>> GetAll()
        {
           FilterDefinitionBuilder<ObjetDepartment> filter = Builders<ObjetDepartment>.Filter;
           FilterDefinition<ObjetDepartment> emptyFilter = filter.Empty;

           IAsyncCursor<ObjetDepartment> allDocuments = await dbCollection.FindAsync<ObjetDepartment>(emptyFilter).ConfigureAwait(false);

           return Ok(allDocuments.ToList());
        }

    }    
}