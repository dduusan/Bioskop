using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB_Repository.Objekti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDB_Repository
{
    public class Film
    {
        public ObjectId Id { get; set; }
        public string naziv { get; set; }
        public string zanr { get; set; }
        public string vreme { get; set; }
        public string sala { get; set; }
        public int brojZauzetihMesta { get; set; }
      //  public Sala nazivSale { get; set; }
        public MongoDBRef Sala { get; set; }
        public MongoDBRef Admin { get; set; }
        public Film()
        {
            brojZauzetihMesta = 0;
        }
    }
}
