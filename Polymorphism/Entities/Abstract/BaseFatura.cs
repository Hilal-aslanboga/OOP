using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Entities.Abstract
{
    //Polymorphism kelimesi “birçok forma sahip olmak” anlamına gelir.
    // Genellikle polymorphism, bir sınıf hiyerarşisi olduğunda ve ortak bir taban sınıftan inheritance(miras) yoluyla ilişkilendirildiğinde oluşur.
    //Polymorphism, bir üye metot çağrısının, metodu çağıran nesnenin türüne bağlı olarak farklı bir işlemi gerçekleştirilmesine neden olacağı anlamına gelir.
    //Basitçe polymorphism, tek bir metodun farklı uygulamalara sahip olabileceği anlamına gelir.
    public class BaseFatura
    {
        public int FaturaNo { get; set; }

        public string FaturaAdı { get; set; }


        private DateTime _faturaKesimTarihi = DateTime.Now;
        public DateTime FaturaKesimTarihi
        {
            get => _faturaKesimTarihi;
            set => _faturaKesimTarihi = value;
        }
    }
}
