using Inheritance.Entities.ParentClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Entities.ChildClass
{
    public class Ucgen:BaseSekil
    {
        // Ata sınıftan gelen Alan() methodu override edildi. Çünkü üçgenin alan hesaplanması diğer şekillere göre farklı olduğu için ihtiyaca göre dizayn edildi. 
        //Methodu override etmek için override yazılıp boşluk tuşuna basılır çıkan listede override etmek istediğiniz method seçilir.
        public override double Alan()
        {
            return genislik * yukseklik / 2;
        }

    }
}
