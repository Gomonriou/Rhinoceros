using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using Reader.Repository;

namespace Reader.Service
{
    public class RhinocerosService
    {
        private readonly IMongoCollection<ObjetDepartment> _departments;

        public RhinocerosService(IRhinocerosDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _departments = database.GetCollection<ObjetDepartment>(settings.CollectionName);
        }
        public List<ObjetDepartment> Get() =>
            _departments.Find(ObjetDepartment => true).ToList();

        public ObjetDepartment Get(string id) =>
            _departments.Find<ObjetDepartment>(ObjetDepartment => ObjetDepartment.Id == id).FirstOrDefault();

    }  
}


