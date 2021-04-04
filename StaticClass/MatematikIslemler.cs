using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticClass
{
    static class MatematikIslemler
    {
        //Bir sınıf içerisindeki static olmayan metotlara ve özelliklere o sınıftan oluşturduğumuz nesneler üzerinden erişiriz. Static olan metotlara ve özelliklere ise nesne oluşturmadan sınıf adı ile erişiriz.
        //Static olmayan elemanlar nesneye özgü bilgileri tutarken static olan elemanlar uygulama çalıştığı sürece kendilerine en son atanan değeri tutarlar.
        //Static bir metodun içerisinden static olmayan metotlar ve değişkenler çağrılamaz. Sadece diğer static metotlar ve değişkenler çağrılabilir.
        //Oluşturduğumuz sınıf içerisinde sadece static metotlar ve değişkenler bulunuyorsa sınıfı static olarak tanımlayabiliriz. Sınıfların static olarak tanımlanması bir zorunluluk değildir sadece okunabilirliği arttıran bir yaklaşımdır.
        //Matematikİslemleri sınıfının üye elemanları(Topla ve Carp metotları) static olduğu için sınıfı da static olarak bildirdik. Matematik sınıfının static olduğunu gören bir programcı, sınıf içerisinde sadece static elemanların bulunduğunu anlayacaktır.
       

        //params: Metotların değişken sayıda parametre almasına imkan veren bir anahtar kelimedir. 
        //Metotlar oluşturulurken kullanılacak parametre sayısı önceden belirlenir. Eğer method içersine yazıcağımız parametre belli değil ise params ı kullanırız.
        public static double Topla(params double[] Sayilar) 
        {
            double Toplam = 0;
            for (int i = 0; i < Sayilar.Length; i++)
                Toplam = Toplam + Sayilar[i];
            return Toplam;          
        }

        public static double Carp(params double[] Sayilar)
        {
            double Carpim = 1;
            for (int i = 0; i < Sayilar.Length; i++)
                Carpim = Carpim * Sayilar[i];
            return Carpim;
        }

        /*Kısaca özetlemek gerekirse
        Static sınıflardan nesne oluşturulamaz. 
        Static sınıf türünden referanslar oluşturulamaz.
        Static sınıfların içinde static olmayan metot yada değişken tanımlanamaz.
        Static sınıflarda kalıtım yoktur.*/
    }
}
