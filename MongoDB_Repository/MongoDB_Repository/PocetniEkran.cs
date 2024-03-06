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
    public partial class PocetniEkran : Form
    {
        public Korisnik globalniKorisnik;
        public Admin globalniAdmin;
        public PocetniEkran()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            globalniAdmin = new Admin();
            Logovanje LogovanjeEkran = new Logovanje(globalniAdmin);
            LogovanjeEkran.ShowDialog();
        }

        private void btnKorisnik_Click(object sender, EventArgs e)
        {
            globalniKorisnik = new Korisnik();
            Logovanje LogovanjeEkran = new Logovanje(globalniKorisnik);
            LogovanjeEkran.ShowDialog();
        }
    }
}
