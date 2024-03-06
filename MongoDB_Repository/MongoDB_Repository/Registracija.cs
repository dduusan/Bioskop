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
    public partial class Registracija : Form
    {
        public Admin admin;
        public Korisnik korisnik;
        public Registracija()
        {
            InitializeComponent();
        }
        public Registracija(Admin a)
        {
            InitializeComponent();
            admin = a;
        }
        public Registracija(Korisnik k)
        {
            InitializeComponent();
            korisnik = k;
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string adresa = txtAdresa.Text;

            if(korisnik == null)
            {
                admin.ime = ime;
                admin.prezime = prezime;
                admin.username = username;
                admin.password = password;
                admin.adresa = adresa;
                DataProvider dataP = new DataProvider();
              bool ne_postoji = dataP.DodajAdmina(admin);
                if (ne_postoji == true)
                {
                    EkranAdmina AdminovEkran = new EkranAdmina(admin);
                    AdminovEkran.ShowDialog();
                }
            }
            else
            {
                korisnik.ime = ime;
                korisnik.prezime = prezime;
                korisnik.username = username;
                korisnik.password = password;
                korisnik.adresa = adresa;
                DataProvider dataP = new DataProvider();
                bool ne_postoji = dataP.DodajKorisnika(korisnik);
                if (ne_postoji == true)
                {
                    KorisnikEkran KorisnikovEkran = new KorisnikEkran(korisnik);
                    KorisnikovEkran.ShowDialog();
                }
               
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
