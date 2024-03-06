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
    public partial class KorisnikEkran : Form
    {
        public Korisnik korisnik;
        public KorisnikEkran()
        {
            InitializeComponent();
        }
        public KorisnikEkran(Korisnik k)
        {
            InitializeComponent();
            korisnik = k;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void popuniInicijalno()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Naziv Filma", 100);
            listView1.Columns.Add("Zanr", 100);
            listView1.Columns.Add("Sala", 100);
            listView1.Columns.Add("Broj Mesta", 100);
            listView1.Columns.Add("Broj Raspolozivih Mesta", 100);
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
            List<Film> filmovi = new List<Film>();
            DataProvider dataP = new DataProvider();
            filmovi = dataP.VratiSveFilmove();
            Sala salica = new Sala();
            DataProvider dataPr = new DataProvider();

            foreach (Film f in filmovi)
            {
                salica = dataPr.VratiSalu(f.sala);
                add(f.naziv, f.zanr, f.sala, salica.brojMesta.ToString(), f.brojZauzetihMesta.ToString(), f.vreme);
            }

        }

        private void KorisnikEkran_Load(object sender, EventArgs e)
        {
            this.popuniInicijalno();
            this.popuniInicijalno1();
            this.popuniEkran();
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            DataProvider dataP = new DataProvider();

            if (this.listView1.SelectedItems.Count > 0)
            {
                String nazivFilma = this.listView1.SelectedItems[0].SubItems[0].Text;
                MessageBox.Show("ZA REZERV FILM: " + nazivFilma);
                Film izabraniFilm = dataP.VratiFilm(nazivFilma);
                MessageBox.Show("Izabrali ste ovaj film: " + izabraniFilm.naziv);
                Sala salaFilma = dataP.VratiSalu(izabraniFilm.sala);
                if(salaFilma.brojMesta - izabraniFilm.brojZauzetihMesta == 0)
                {
                    MessageBox.Show("Sva mesta su popunjena!");
                }
                else
                {
                    dataP.RezervisiFilm(korisnik, izabraniFilm);
                    //salaFilma.brojZauzetih++;
                    dataP.AzurirajSalu(izabraniFilm, salaFilma);
                    //korisnik.rezervisaniFilmovi.Add(izabraniFilm);
                   // dataP.AzurirajKorisnika(korisnik, izabraniFilm);
                    MessageBox.Show("Uspesno ste rezervisali mesto!");
                    this.refresujEkran();
                }
       
            }
        }

        private void btnVidiSve_Click(object sender, EventArgs e)
        {

            RezervisaneKarte KarteEkran = new RezervisaneKarte(korisnik);
            KarteEkran.ShowDialog();
            
            
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string zaPtretragu = txtPretraga.Text;
            DataProvider dataP = new DataProvider();
            Film trazeniFilm = dataP.VratiFilm(zaPtretragu);
         
            if (trazeniFilm == null)
            {
                MessageBox.Show("Trazeni film ne postoji!");
            }
            else 
            {
                Sala salaFilma = dataP.VratiSalu(trazeniFilm.sala);
                add1(trazeniFilm.naziv, trazeniFilm.zanr, trazeniFilm.sala, salaFilma.brojMesta.ToString(), trazeniFilm.brojZauzetihMesta.ToString(), trazeniFilm.vreme);
            }
          
        }

        public void refresujEkran()
        {
            listView1.Clear();
            this.popuniInicijalno();
            this.popuniEkran();
        }
        public void popuniInicijalno1()
        {
            listView2.View = View.Details;
            listView2.FullRowSelect = true;
            listView2.Columns.Add("Naziv Filma", 100);
            listView2.Columns.Add("Zanr", 100);
            listView2.Columns.Add("Sala", 100);
            listView2.Columns.Add("Broj Mesta", 100);
            listView2.Columns.Add("Broj Zauzetih Mesta", 50);
            listView2.Columns.Add("Vreme Odrzavanja", 100);
        }
        public void add1(string nazivFilma, string zanr, string sala, string brojmesta, string raspoloziva, string vreme)
        {
            String[] row = { nazivFilma, zanr, sala, brojmesta, raspoloziva, vreme };
            ListViewItem item = new ListViewItem(row);
            listView2.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.refresujEkran();
        }
    }
}
