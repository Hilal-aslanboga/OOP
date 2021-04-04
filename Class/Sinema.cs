using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    // Sınıfları nesne yaratmak için kullanıyoruz. Nesne yaratmak için ilk önce o nesnenin prototipi (sınıf-class)yaratılır. 
    //Prototiplerden üretilecek olan nesnelerin belirli özellikleri vardır ve bunları prototip içinde saklıyoruz.

    //Access Modifiers(Erişim Belirteçleri)
    // Bir sınıfın bir üyesine sınıf dışarısından erişilip erişilemeyeceği yada farklı bir Assabely içersinden erişim durumunu belirlediğimiz bir konudur. Farklı çeşitleri bulunmaktadır. 
    /* 1. Public => Solution altında her yerden erişilebilir.
     * 2. Private => Sadece sınıf içersinde erişime açıktır.
     * 3. Internal => Sadece bulunduğu proje altındaki namespace içersinden erişilebilir.
    */ 
    
    class Sinema // Bir sınıfa Erişim Belirteci belirtmezsek o sınıf varsayılan olarak "internal" olarak kabul edilir.
    {
        int toplamKoltukSayisi; //Sınıf içersindeki bir üyeye Erişim Belirteci ile işaretlemezsek varsayılan olarak "default" yani private olur.
        int bosKoltukSayisi;
        double bakiye;
        string salonNo;

        const double Tam = 20.0; //Bir değişkenin değerinin program boyunca sabit olarak tutulması istendiğinde const (sabit) ifadesinden yararlanabilirz.
        const double Indirimli = 15.0;

        public Sinema(string salonn,int koltukdsayi)
        {
            toplamKoltukSayisi = koltukdsayi;
            salonNo = salonn;
            bosKoltukSayisi = toplamKoltukSayisi;
            bakiye = 0;
        }

        // Metodu incelediğimiz zaman bilet satışı gerçekleştiğinde boş koltuk sayısının azaltılması sağlanıyor. İndirimli veya tam bilet olması durumuna göre bakiyenin arttırılması sağlanıyor. 

        public void BiletSat(bool indirimli)
        {
            bosKoltukSayisi--;
            if (indirimli)
                bakiye += Indirimli;
            else
                bakiye += Tam;
        }

        // Gelen parametre ile biletin indirimli ya da tam bilet olduğunun kontrolünü yapıp para iadesi bakiye azaltılacak ve boş koltuk sayısının arttırılması sağlanıcak.

        public void BiletIptal(bool indirimli)
        {
            bosKoltukSayisi++;
            if (indirimli)
            {
                bakiye -= Indirimli;
            }
            else
            {
                bakiye -= Tam;
            }
        }

        // Boş koltuk sayısını öğrenebileceğimiz bir metod oluşturup sadece boş koltuk sayısının geri döndürüldüğünü gördücez.

        public int BosKoltukOgren() => bosKoltukSayisi;


       public double BakiyeOgren()
        {
            return bakiye;
        }
    }
}
