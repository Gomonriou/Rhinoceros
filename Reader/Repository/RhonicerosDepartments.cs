using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Reader.Repository
{
    public class ObjetDepartment
    {
        // public int ID {get ; set;}
        // public int Code_Postale {get ; set;}
        // public string DepartmentNom {get ; set;}
        // public int Population {get ; set;}
        // // public string GPS {get ; set;}

        // public Department (int ID, int Code_Postale, string Department, int Population)
        // {
        //     this.ID = ID;
        //     this.Code_Postale = Code_Postale;
        //     this.Department = Department;
        //     this.Population = Population;
        // }

        [BsonId]
        public string AnotherId { get; set; }

        [BsonElement("Departement")]
        public int Code_Postale { get; set; }
        public string DepartmentsNom { get; set; }
        public int Population { get; set; }
    }

}

// rajouter les coordonnées gps