using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Formun çalışmasını kısaca açıklamak gerekirse Oluştur Butonunu kullanarak oluşturacağımız Sinema sınıfından yeni bir nesne oluşturacağız. Sınıf yapısında BiletSat, BiletIptal, BoskoltukOgren ve BakiyeOgren metotlarını oluşturarak gerekli işlemlerin yapılmasını sağlayacak ve bu işlemlerle ilgili label3 kontrolünde kullanıcı bilgilendirmesi yapacağız.

        Sinema salon;

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                salon = new Sinema(txtSalon.Text, Convert.ToInt32(txtKoltukSayisi.Text));
                label3.Text = "Salon Oluşturuldu. Koltuk Sayısı:"+salon.BosKoltukOgren();
            }
            catch (Exception)
            {
                label3.Text = "Salon Oluşturulamadı. Bilgileri kontrol edin.";
            }
        }

        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            salon.BiletSat(chk_Indirimli.Checked);
            label3.Text = "Bilet satıldı. Kalan koltuk sayısı: " + salon.BosKoltukOgren();
        }

        private void btnBiletIptal_Click(object sender, EventArgs e)
        {
            salon.BiletIptal(chk_Indirimli.Checked);
            label3.Text = "Bilet iptal edildi. Kalan koltuk sayısı : "+salon.BosKoltukOgren();
        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            label3.Text = "Boş koltuk sayısı: " + salon.BakiyeOgren()+"TL";
        }

        private void btnBosKoltuk_Click(object sender, EventArgs e)
        {
            label3.Text = "Boş koltuk sayısı: " + salon.BosKoltukOgren();
        }
    }
}
