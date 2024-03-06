using MongoDB.Driver;
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
    public partial class RezervisaneKarte : Form
    {
        public Korisnik korisnik;
      
        public RezervisaneKarte()
        {
            InitializeComponent();
        }
        public RezervisaneKarte(Korisnik k)
        {
            InitializeComponent();
            korisnik = k;
            
        }

        private void btnRezervaciju_Click(object sender, EventArgs e)
        {
            DataProvider dataP = new DataProvider();
            if (this.listView1.SelectedItems.Count > 0)
            {
                String nazivFilma = this.listView1.SelectedItems[0].SubItems[0].Text;
                Film izabraniFilm = dataP.VratiFilm(nazivFilma);
                
                dataP.BrisiKorisnikuFilm(korisnik, izabraniFilm);

               
                

            }
            this.Close();
        }
        private void RezervisaneKarte_Load(object sender, EventArgs e)
        {
            this.popuniInicijalno();
            this.popuniEkran();
        }
        public void popuniInicijalno()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Naziv Filma", 100);
            listView1.Columns.Add("Zanr", 100);
            listView1.Columns.Add("Sala", 100);
            listView1.Columns.Add("Broj Mesta", 100);
            listView1.Columns.Add("Broj Zauzetih Mesta", 100);
            listView1.Columns.Add("Vreme Odrzavanja", 100);
        }
        public void add(string nazivFilma, string zanr, string sala, string brojmesta, string raspoloziva, string vreme)
        {
            String[] row = { nazivFilma, zanr, sala, brojmesta, raspoloziva, vreme };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
        public void popuniEkran()
        {
            /* List<MongoDBRef> filmovi = new List<MongoDBRef>();
             List<Film> praviFilmovi = new List<Film>();
             DataProvider dataP = new DataProvider();
             filmovi = dataP.VratiSveFilmoveKorisnika(korisnik); // vraca reference
             praviFilmovi = dataP.VratiSveFilmoveKorisnika2(korisnik, filmovi); //vraca filmove objekte
             Sala salica = new Sala();*/
            DataProvider dataP = new DataProvider();
            List<Film> rezervacije = dataP.VratiSveFilmoveKorisnika(korisnik);

            Sala salica = new Sala();
            foreach (Film f in rezervacije)
            {
                salica = dataP.VratiSalu(f.sala);
                add(f.naziv, f.zanr, f.sala, salica.brojMesta.ToString(), f.brojZauzetihMesta.ToString(), f.vreme);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
