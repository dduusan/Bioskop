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
    public partial class EkranAdmina : Form
    {
        public Admin admin;
        public EkranAdmina()
        {
            InitializeComponent();
        }
        public EkranAdmina(Admin a)
        {
            InitializeComponent();
            admin = a;
        }
        private void EkranAdmina_Load(object sender, EventArgs e)
        {
            this.popuniInicijalno();
            this.popuniEkran();
        }

        private void btnDodajFilm_Click(object sender, EventArgs e)
        {
           
            DodajFilm EkranFilm = new DodajFilm();
            EkranFilm.admin = admin;
            EkranFilm.ShowDialog();
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


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnObrisiFilm_Click(object sender, EventArgs e)
        {
            DataProvider dataP = new DataProvider();

            if (this.listView1.SelectedItems.Count > 0)
            {
                String nazivFilma = this.listView1.SelectedItems[0].SubItems[0].Text;
                dataP.BrisiFilm(admin, nazivFilma);
                MessageBox.Show("Film " + nazivFilma + " je obrisan!");
                this.refresujEkran();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            
            if (this.listView1.SelectedItems.Count > 0)
            {
                String nazivFilma = this.listView1.SelectedItems[0].SubItems[0].Text;
                Izmena IzmenaEkran = new Izmena(nazivFilma);
                IzmenaEkran.ShowDialog();
              
            }
        }
        public void refresujEkran()
        {
            listView1.Clear();
            this.popuniInicijalno();
            this.popuniEkran();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           this.refresujEkran();
        }
    }
}
