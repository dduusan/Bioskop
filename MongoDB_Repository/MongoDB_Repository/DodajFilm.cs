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
    public partial class DodajFilm : Form
    {
        public Admin admin;
        public DodajFilm()
        {
            InitializeComponent();
        }
        public DodajFilm(Admin a)
        {
            InitializeComponent();
            admin = a;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text;
            string vreme = txtVreme.Text;
            string zanr = txtZanr.Text;
            string sala;


            Film noviFilm = new Film();
            noviFilm.naziv = naziv;
            noviFilm.vreme = vreme;
            noviFilm.zanr = zanr;
            //  noviFilm.sala = checkedListBox1.CheckedItems;
            // MessageBox.Show("Sala je:" + noviFilm.sala);
            //noviFilm.sala = checkedListBox1.CheckedItems.ToString();

            foreach (string s in checkedListBox1.CheckedItems)
            {
                sala = s;
                noviFilm.sala = sala;
            }



            //MongoDBRef adminRef = new MongoDBRef("admini", admin.Id);
            //noviFilm.Admin = adminRef;
            DataProvider dataP = new DataProvider();
            Sala izabranaSala = dataP.VratiSalu(noviFilm.sala);
            //Sala trazenaSala = dataP.VratiSalu(noviFilm.sala);
            // MongoDBRef salaRef = new MongoDBRef("sale", trazenaSala.Id);
            // noviFilm.Sala = salaRef;
           
            dataP.DodajFilm(noviFilm, admin, izabranaSala);
            this.Close();
           /* DataProvider dataP = new DataProvider();
           Sala salica = dataP.VratiSalu(noviFilm.sala);
            noviFilm.Sala = salica;
           */

        } 

    }
}
