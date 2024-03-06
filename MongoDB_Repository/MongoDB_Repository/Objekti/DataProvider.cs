using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MongoDB_Repository.Objekti
{
    public class DataProvider
    {
        #region Admin

        public void DodajSalu()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");



            var collection = db.GetCollection<Sala>("sale");




            Sala sala1 = new Sala
            {
                naziv = "Sala1",
                brojMesta = 10,
               
                FilmoviSale = {}
                    
                };
            Sala sala2 = new Sala
            {
                naziv = "Sala2",
                brojMesta = 10,
                
                FilmoviSale = {}

            };
            Sala sala3 = new Sala
            {
                naziv = "Sala3",
                brojMesta = 10,
             
                 FilmoviSale = {}
            };

            collection.Insert(sala1);
            collection.Insert(sala2);
            collection.Insert(sala3);
          
        }
        public bool DodajAdmina(Admin adminObj)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");



            var collection = db.GetCollection<Admin>("admini");

            var query = (from admin in collection.AsQueryable<Admin>()
                         where admin.username == adminObj.username
                         select admin).FirstOrDefault();
            if (query != null)
            {
                MessageBox.Show("Uneti username vec postoji! Pokusajte ponovo!");
                return false;
            }
            else
            {
                Admin admin1 = new Admin
                {
                    ime = adminObj.ime,
                    prezime = adminObj.prezime,
                    username = adminObj.username,
                    password = adminObj.password,
                    adresa = adminObj.adresa,
                    Filmovi = adminObj.Filmovi
                };

                collection.Insert(admin1);
                return true;
            }
        }
        #endregion

        #region Korisnik
        public bool DodajKorisnika(Korisnik korisnikObj)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");



            var collection = db.GetCollection<Korisnik>("korisnici");

            var query = (from korisnik in collection.AsQueryable<Korisnik>()
                         where korisnik.username == korisnikObj.username
                         select korisnik).FirstOrDefault();
            if (query != null)
            {
                MessageBox.Show("Uneti username vec postoji! Pokusajte ponovo!");
                return false;
            }
            else
            {
                Korisnik korisnik1 = new Korisnik
                {
                    ime = korisnikObj.ime,
                    prezime = korisnikObj.prezime,
                    username = korisnikObj.username,
                    password = korisnikObj.password,
                    adresa = korisnikObj.adresa
                };

                collection.Insert(korisnik1);
                return true;
            }
        }
        #endregion

        #region Filmovi
        public List<Film> VratiSveFilmove()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");

            var collection = db.GetCollection<Film>("filmovi");
            List<Film> SviFilmovi = new List<Film>();

            foreach (Film f in collection.FindAll())
            {
                SviFilmovi.Add(f);
            }
            return SviFilmovi;
        }
        public void AzurirajKorisnika(Korisnik k, Film f)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");

            var collection = db.GetCollection<Korisnik>("korisnici");

       
            MongoDBRef ref1 = new MongoDBRef("filmovi", f.Id);
            var update1 = MongoDB.Driver.Builders.Update.Set("rezervisaniFilmovi", BsonValue.Create(new List<MongoDBRef> { ref1 }));
            var query = from d in collection.AsQueryable<Korisnik>()
                        where d.ime == k.ime
                        select d;
            collection.Update((IMongoQuery)query, update1);


  
        }

        public void BrisiKorisnikuFilm(Korisnik k, Film f)
        {
            DataProvider dP = new DataProvider();
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");

            var collection = db.GetCollection<Korisnik>("korisnici");
            var saleCollection = db.GetCollection<Sala>("sale");
            var filmoviCollection = db.GetCollection<Film>("filmovi"); // !
            Sala odabrana = dP.VratiSalu(f.sala);
           

            
            List<MongoDBRef> korisnikoveFilmRef = new List<MongoDBRef>();
            MongoDBRef zaBrisanjeFilm = new MongoDBRef("filmovi", f.Id);
            Korisnik izabranik = new Korisnik();
            Film zaPromenu = new Film();
           
            foreach(Korisnik kk in collection.FindAll())
            {
                if(kk.Id == k.Id)
                {
                    izabranik = kk;
                    foreach(MongoDBRef r in kk.rezervisaniFilmovi.ToList())
                    {
                       
                        if(r.Id == f.Id)
                        {
                            zaPromenu = f;
                            zaPromenu.brojZauzetihMesta--;
                            kk.rezervisaniFilmovi.Remove(r);
                            
                            collection.Save(kk);
                            filmoviCollection.Save(zaPromenu);
                           
                            
                        }
                    }
                }
            }

          

        }
        public void AzurirajKorisnikaListu(Korisnik k, List<MongoDBRef>lista)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");

            var collection = db.GetCollection<Korisnik>("korisnici");


            //MongoDBRef ref1 = new MongoDBRef("filmovi", f.Id);
            var update1 = MongoDB.Driver.Builders.Update.Set("rezervisaniFilmovi", BsonValue.Create(lista));
            var query = from d in collection.AsQueryable<Korisnik>()
                        where d.ime == k.ime
                        select d;
            collection.Update((IMongoQuery)query, update1);
        }
        public List<Film> VratiSveFilmoveKorisnika(Korisnik k)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");

            var korisniciCollection = db.GetCollection<Korisnik>("korisnici");
            var filmoviCollection = db.GetCollection<Film>("filmovi");
            Korisnik trenutniKorisnik = new Korisnik();

            foreach(Korisnik kk in korisniciCollection.FindAll())
            {
                if(kk.Id == k.Id)
                {
                    trenutniKorisnik = kk;
                }
            }
            List<Film> rezervisaniFilmoviKorisnika = new List<Film>();
            foreach(MongoDBRef f in trenutniKorisnik.rezervisaniFilmovi)
            {
                foreach(Film movie in filmoviCollection.FindAll())
                {
                    if(f.Id == movie.Id)
                    {
                        rezervisaniFilmoviKorisnika.Add(movie);
                    }
                }
            }

            return rezervisaniFilmoviKorisnika;
        }

        public List<Film> VratiSveFilmoveKorisnika2(Korisnik k, List<MongoDBRef> ref1)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");

            var vlasnikCollection = db.GetCollection("korisnici");
          //  var sviFilmovi = db.GetCollection("filmovi");

            List<Film> sviFilmovi2 = VratiSveFilmove();
            List<Film> zaVracanje = new List<Film>();

            foreach(MongoDBRef r in ref1)
            {
                foreach(Film f in sviFilmovi2)
                {
                    if (r.Id == f.Id)
                        zaVracanje.Add(f); //poklapanje referenci
                }
            }
            
            return zaVracanje;
        }
        public void DodajFilm (Film f, Admin a, Sala s)
        {
          
           // DataProvider d = new DataProvider();
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");
           // MongoDBRef m = new MongoDBRef("vlasnici", vlasnik.Id);
           // MongoDBRef i1 = new MongoDBRef("izlozbe", i.Id);

            var collection = db.GetCollection<Film>("filmovi");
           

            //f.izlozbe.Add(i1);
           //// MongoDBRef salaRef = new MongoDBRef("sale", s.Id);
            //MongoDBRef adminRef = new MongoDBRef("admini", a.Id);

            f.Admin = new MongoDBRef("admini", a.Id);
            f.Sala = new MongoDBRef("sale", s.Id);
            //f.Sala = salaRef;
            //f.Admin = adminRef;
            collection.Insert(f);

            var vcollection = db.GetCollection<Admin>("admini");
            var izcollection = db.GetCollection<Sala>("sale");
           
            collection.Save(f);

            foreach(Admin ad in vcollection.FindAll())
            {
                if (ad.Id == a.Id)
                {
                    ad.Filmovi.Add(new MongoDBRef("filmovi", f.Id));
                    vcollection.Save(ad);
                }
            }

            foreach (Sala sa in izcollection.FindAll())
            {
                if (sa.Id == s.Id)
                {
                    sa.FilmoviSale.Add(new MongoDBRef("filmovi", f.Id));
                    izcollection.Save(sa);
                }
            }
            // s.FilmoviSale.Add(new MongoDBRef("filmovi", f.Id));
            //a.Filmovi.Add(new MongoDBRef("filmovi", f.Id));


            // vcollection.Save(a);
            // izcollection.Save(s);
        }

        public void BrisiFilm(Admin a, string naziv)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");
            DataProvider DP = new DataProvider();
            var collection = db.GetCollection<Film>("filmovi");

            var collectionKor = db.GetCollection<Korisnik>("korisnici");
            var collectionSale = db.GetCollection<Sala>("sale");
            Film zaBr = new Film();
            zaBr = DP.VratiFilm(naziv);
            var query = Query.EQ("naziv", naziv);
            this.BrisiAdminuFilm(a, naziv);

            foreach(Korisnik k in collectionKor.FindAll())
            {
                foreach(MongoDBRef r in k.rezervisaniFilmovi.ToList())
                {
                    if (r.Id == zaBr.Id)
                        this.BrisiKorisnikuFilm(k, zaBr);
                }
            }
            foreach (Sala s in collectionSale.FindAll())
            {
                foreach (MongoDBRef r in s.FilmoviSale.ToList())
                {
                    if (r.Id == zaBr.Id)
                        this.BrisiFilmSale(s, zaBr.naziv);
                }
            }
            collection.Remove(query);
           
        
        }
        public void BrisiAdminuFilm(Admin a, string naziv)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");
            DataProvider DP = new DataProvider();
            Film zaBrisanje = new Film();
            zaBrisanje = DP.VratiFilm(naziv);
            Admin zaMenjanje = new Admin();

            var adminCollection = db.GetCollection<Admin>("admini");
            var filmCollection = db.GetCollection<Film>("filmovi");

            

            foreach(Admin ad in adminCollection.FindAll())
            {
                if(ad.Id == a.Id)
                {
                    zaMenjanje = ad;
                   foreach(MongoDBRef filmRef in ad.Filmovi.ToList())
                    {
                       if(filmRef.Id == zaBrisanje.Id)
                        {
                            ad.Filmovi.Remove(filmRef);
                            adminCollection.Save(ad);
                          
                        }
                    }
                }
            }


        }
        public void BrisiFilmSale(Sala a, string naziv)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");
            DataProvider DP = new DataProvider();
            Film zaBrisanje = new Film();
            zaBrisanje = DP.VratiFilm(naziv);
            Sala zaMenjanje = new Sala();

            var saleCollection = db.GetCollection<Sala>("sale");
            var filmCollection = db.GetCollection<Film>("filmovi");



            foreach (Sala ad in saleCollection.FindAll())
            {
                if (ad.Id == a.Id)
                {
                    zaMenjanje = ad;
                    foreach (MongoDBRef filmRef in ad.FilmoviSale.ToList())
                    {
                        if (filmRef.Id == zaBrisanje.Id)
                        {
                            ad.FilmoviSale.Remove(filmRef);
                            saleCollection.Save(ad);
                           
                        }
                    }
                }
            }


        }

        public void IzmeniFilm(string naziv, string vreme, string ime)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");

            var collection = db.GetCollection<Film>("filmovi");

            var query = Query.EQ("naziv", naziv);
            var update = MongoDB.Driver.Builders.Update.Set("vreme", vreme);
            var update1 = MongoDB.Driver.Builders.Update.Set("naziv", ime);

            collection.Update(query, update);
            collection.Update(query, update1);
        }
        public Film VratiFilm(string naziv)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");
           
            Film vracamFilm = new Film();
            var collection = db.GetCollection<Film>("filmovi");
         
            foreach(Film f in collection.FindAll())
            {
                if (f.naziv == naziv)
                {
                    vracamFilm = f;
                   
                }
                else
                {
                   
                }
            }
           
            return vracamFilm;
            
           
           
        }
        #endregion

        #region Sala
        public Sala VratiSalu(string naziv)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");

            var salecollection = db.GetCollection<Sala>("sale");
          
            var query1 = (from sala in salecollection.AsQueryable<Sala>()
                          where sala.naziv == naziv
                          select sala).FirstOrDefault();

            return (Sala)query1;
        }

        public void RezervisiFilm(Korisnik k, Film f)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");

            var filmCollection = db.GetCollection<Film>("filmovi");
            var korisniciCollection = db.GetCollection<Korisnik>("korisnici");

            foreach(Korisnik kk in korisniciCollection.FindAll())
            {
                if(kk.Id == k.Id)
                {
                    foreach (Film film in filmCollection.FindAll())
                    {
                        if (film.Id == f.Id)
                        {
                            film.brojZauzetihMesta++;
                            filmCollection.Save(film);
                            kk.rezervisaniFilmovi.Add(new MongoDBRef("filmovi", film.Id));
                            korisniciCollection.Save(kk);
                        }
                    }
                }
            }
            
        }
        public void AzurirajSalu (Film f, Sala s)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");

            var collection = db.GetCollection<Sala>("sale");

            var query = from d in collection.AsQueryable<Sala>()
                        where d.naziv == s.naziv
                        select d;

            var query1 = Query.EQ("naziv", s.naziv);
            
        
        }

        public Sala VratiSaluRef(string naziv)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");

            var salecollection = db.GetCollection("sale");

            var query1 = (from sala in salecollection.AsQueryable<Sala>()
                          where sala.naziv == naziv
                          select sala).FirstOrDefault();

            return query1;
        }
        #endregion
    }
}
