using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void btnTopla_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Toplama İşlemi: { MatematikIslemler.Topla(178, 56, 963, 14, 61, 28)}");
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Çarpma İşlemi: { MatematikIslemler.Carp(178, 56, 963, 14, 61, 28)}");
        }
    }
}
