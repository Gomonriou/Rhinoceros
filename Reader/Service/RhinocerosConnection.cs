// using System;
// using System.Collections.Generic;
// using System.Linq;
// using MongoDB.Driver;
// using MongoDB.Bson;
// using MongoDB.Driver.Linq;

// namespace Reader.Service
// {
//     public static class RhinocerosService
//     {
//         public static IEnumerable<departement> GetDepartmentByName(string name)
//         {

//         var settings = "mongodb+srv://root:toor@rhinoceros.jkqed.mongodb.net/Rhinoceros?retryWrites=true&w=majority";
//         var client = new MongoClient(settings);
//         var Database = client.GetDatabase("Rhinoceros");

//         var collection = Database.GetCollection<ObjetDepartment>("Departments");

//         IMongoCollection<ObjetDepartment> collection = Database.GetCollection<ObjetDepartment>("Departments");
             
//         }
        
//     }
    
// }


