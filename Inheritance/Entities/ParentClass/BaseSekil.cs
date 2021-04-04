using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance.Entities.ParentClass
{
    // Ata sınıfların amacı diğer alt sınıflara kalıtım (miras) vasıtasıyla ortak özellik ve yetenek aktarmaktır. 
    // Mantık şu şekilde çalışır ata sınıfta yazdığımız özellikler diğer alt sınıflarda tekrar yazılmaz bu şekilde kod tekrarını engellemiş oluruz.

   public class BaseSekil // Ata sınıfları alt sınıflarda erişebilmek için public işaretlememiz gerekir.
    {
        public double genislik;
        public double yukseklik;
        public string sekilAdi;

        //Ata sınıflardan gelen methodları alt sınıflarda ezmek ve onları ihtiyaca göre dizayn etme işlemine override denir.
        //Bu fonksiyonu virtual işaretlememizin sebebi alt sınıflarda geçersiz kılıp ihtiyaca göre yeni özellik kazandırmaktır.
        public virtual double Alan() => genislik * yukseklik;


        public void Goster()
        {
            MessageBox.Show($"Şekil adı: {sekilAdi} Genişlik: {genislik} Yükseklik: {yukseklik} Alan: {Alan()}");
        }
    }
}
