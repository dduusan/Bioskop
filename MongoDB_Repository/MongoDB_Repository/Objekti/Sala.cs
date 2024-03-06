using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDB_Repository.Objekti
{
    public class Sala
    {
        public ObjectId Id { get; set; }
        public string naziv { get; set; }
        public int brojMesta { get; set; }
      
        //public int brojZauzetih { get; set; }
        public List<MongoDBRef> FilmoviSale { get; set; }
        public Sala()
        {
            FilmoviSale = new List<MongoDBRef>();
        }
    }
}
