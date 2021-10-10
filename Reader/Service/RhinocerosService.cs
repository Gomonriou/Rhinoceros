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
//         public static IEnumerable<ObjetDepartment> Getall()
//         {
//             IEnumerable<ObjetDepartment> query = 
//                 from n in ObjetDepartment.Get()
//                 select n;
            
//             return query;
//         }
        
//     }
    
// }