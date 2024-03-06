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
    public partial class Izmena : Form
    {
       public string nazivFilma;
        public Izmena()
        {
            InitializeComponent();
        }
        public Izmena(string film)
        {
            InitializeComponent();
            nazivFilma = film;
        }

        private void btnIzmena_Click(object sender, EventArgs e)
        {
            string novoVreme = txtNovoVreme.Text;
            string novoIme = txtNovoIme.Text;
            DataProvider dataP = new DataProvider();
            dataP.IzmeniFilm(nazivFilma, novoVreme, novoIme);
            this.Close();
        }
    }
}
