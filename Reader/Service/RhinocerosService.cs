using System;
using System.Collections.Generic;
using System.Linq;
using Rhinoceros.Writer;
using MongoDB.Driver;
using MongoDB.Bson;

namespace reader.Service
{
    public static class RhinocerosService
    {
        public static IEnumerable<departement> GetDepartmentByName(string name)
        {
            // IEnumerable<departement> query = 
            //     from n in PizzaRepository.GetPizzas() //chercher dans la db
            //     where n.Nom.Contains(name)
            //     select n;
            var collection = Database.GetCollection<BsonDocument>("departements");

            var IEnumerable<departement>  query =
                from e in collection.AsQueryable<departement>()
                where e.FirstName == "Eure"
                select e;

            // foreach (var employee in query)
            // {
            //     // process employees named "John"
            // }

            // return query;
        }


        // public static IEnumerable<Pizza> Getall()
        // {
        //     IEnumerable<Pizza> query = 
        //         from n in PizzaRepository.GetPizzas()
        //         select n;
            
        //     return query;
        // }

        
    }
    
}