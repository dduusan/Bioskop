using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB_Repository.Objekti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MongoDB_Repository
{
    public partial class Logovanje : Form
    {
        public Korisnik korisnik;
        public Admin admin;
        public Logovanje()
        {
            InitializeComponent();
        }
        public Logovanje(Korisnik k)
        {
            InitializeComponent();
            korisnik = k;
        }
        public Logovanje(Admin a)
        {
            InitializeComponent();
            admin = a;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbBioskop");
          // DataProvider dataP = new DataProvider();
           // dataP.DodajSalu();

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (admin == null)
            {
                var korisnikCollection = db.GetCollection("korisnici");

                var query = (from korisnik in korisnikCollection.AsQueryable<Korisnik>()
                              where korisnik.username == username && korisnik.password == password
                              select korisnik).FirstOrDefault();
                if(query == null)
                {
                    MessageBox.Show("Uneli ste pogresnu sifru ili username!");
                }
                else
                {
                    korisnik = (Korisnik)query;
                    KorisnikEkran korisnickiEkran = new KorisnikEkran(korisnik);
                    korisnickiEkran.ShowDialog();
                }
               
            }
            else
            {
                var adminCollection = db.GetCollection("admini");
                var query = (from admin in adminCollection.AsQueryable<Admin>()
                             where admin.username == username && admin.password == password
                             select admin).FirstOrDefault();
                if (query == null)
                {
                    MessageBox.Show("Uneli ste pogresnu sifru ili username!");
                }
                else
                {
                    
                    admin = (Admin)query;
                   
                    EkranAdmina adminEkran = new EkranAdmina();
                    adminEkran.admin = admin;
                    adminEkran.ShowDialog();
                    
                }

            }

            

            
        }

        private void btnNoLogin_Click(object sender, EventArgs e)
        {
            if(admin == null)
            {
                Registracija RegistracijaEkran = new Registracija(korisnik);
                RegistracijaEkran.ShowDialog();
            }
            else
            {
                Registracija RegistracijaEkran = new Registracija(admin);
                RegistracijaEkran.ShowDialog();
            }
            
        }
    }
}
