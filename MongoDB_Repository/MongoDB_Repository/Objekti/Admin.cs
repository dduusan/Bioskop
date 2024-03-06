using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDB_Repository
{
   public class Admin
    {
        public ObjectId Id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public List<MongoDBRef> Filmovi { get; set; }
        public Admin()
        {
            Filmovi = new List<MongoDBRef>();
        }
        //public MongoDBRef Sektor { get; set; }
    }
}
