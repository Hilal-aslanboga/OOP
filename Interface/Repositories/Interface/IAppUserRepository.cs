using Interface.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Repositories.Interface
{
    //Arayüzler (interface) soyutlama yapılırken kullanabileceğimiz bir başka yapıdır. Abstract sınıfların aşağı yukarı tüm özelliklerine sahiptir. 

    /* Abstract Sınıf ile Interface Arasındaki Farklar
    1. Abstract sınıflarda abstract olarak işaretlediğim üye alt sınıflarda ovirrede edilmek zorundaydı.
    Interface sınıflarda her üye override edilmek zorundadır.
    2. Bir concrete sınıf sadece bir abstract yada concrete sınıftan miras alabilirken birden fazla interface'den kalıtım alabilir. 
    Buda çoklu kalıtım (multiple inheritance) denir. Şayet kullanılacak kalıtım mimarisinde bir alt sınıf (child class) birden fazla ata sınıftan (parent class) miras alacaksa çoklu kalıtım yapılmaktadır.
    Çoklu kalıtımı projenizde uygulamak isterseniz interface'lere ihtiyacınız bulunmaktadır.
    3.Abstract sınıflarda constructor bulunmaktadır ve kodlama yapılmaktadır. Burada kodlamadan kastımız üyelere erişim belirteçleri (access modifiers) ile işaretlemek, methodların gövdesini doldurma, kapsülleme gibi işlemlerdir.
    Ama bu durum C# 8.0'dan önce interface için geçerli değildi. C# 8.0'dan önce interface içerisinde kodlama yapılamıyordu yani üyleri access modifiers kabul etmezdi, methodlara gövde kazandıramazdık gibi. */

    //Abstraction projemizde yapmış olduğumuz örneği birde Interface ile yapalım arasındaki farkları görmüş oluruz.

    public interface IAppUserRepository
    {
        //Interface'lerde method gövdeleri boş bırakılır yani herhangi bir iş üzerlerine atanmaz. 
        //Çünkü alt sınıflarda tüm üyeler ovirrede ediliceği için burda bir işlem yapmak mantıksız olur.

        void CreateUser(string firstnName, string lastName, Role role, ListView listView);
        void GetRole(ComboBox comboBox);
    }
}
