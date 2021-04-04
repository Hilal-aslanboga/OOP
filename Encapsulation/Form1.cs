using Encapsulation.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            NotHesap notlar = new NotHesap();
            notlar.Ad = txtAd.Text;
            notlar.Soyad = txtSoyad.Text;
            notlar.Ders = cmbDers.Text;
            notlar.Vize = Convert.ToInt32(txtVize.Text);
            notlar.Final = Convert.ToInt32(txtFinal.Text);
            txtOrtalama.Text = notlar.Ortalama.ToString();

            ListViewItem kayit = new ListViewItem();
            kayit.Text = notlar.Ad;
            kayit.SubItems.Add(notlar.Soyad);
            kayit.SubItems.Add(notlar.Ders);
            kayit.SubItems.Add(notlar.Ortalama.ToString());
            listView1.Items.Add(kayit);
        }
    }
}
