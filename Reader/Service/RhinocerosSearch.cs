using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using Reader.Repository;
using Reader.Service;

namespace Reader.Service
{
    public class Search
    {
       
        public string Nom { get; set; }
        
        public int? Nombre { get; set; }
        
        public string CodePostal { get; set; }
        
        
    }
}