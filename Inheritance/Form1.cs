using Inheritance.Entities.ChildClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnUcgen_Click(object sender, EventArgs e)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.sekilAdi = "Üçgen";
            ucgen.genislik = 15;
            ucgen.yukseklik = 4;

            ucgen.Goster();       
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            Kare kare = new Kare();
            kare.sekilAdi = "Kare";
            kare.genislik = 9;
            kare.yukseklik = 9;

            kare.Goster();
        }

        private void btnDikdortgen_Click(object sender, EventArgs e)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.sekilAdi = "Dikdörtgen";
            dikdortgen.genislik = 14;
            dikdortgen.yukseklik = 6;

            dikdortgen.Goster();
        }
    }
}
