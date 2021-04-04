using Interface.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entites.Abstract
{
    public abstract class BaseEntity<T> // "T" tip anlamındadır ve generictir 
                                        //Herhangi bir tipe (int, string vb) bağlı değildir. Bunu yapmamızın sebebi alt sınıflarda bu tip "T" yerine ihtiyacımız olan tipi geçebilelim.  
    {
        public abstract T Id { get; set; } //Alt sınıflarda ihityacımız olan tipi verebileceğiz.

        private DateTime _createdate = DateTime.Now;
        public DateTime CreateDate
        {
            get => _createdate;
            set => _createdate = value;
        }

        private Status _status = Status.Active;
        public Status Status
        {
            get => _status;
            set => _status = value;
        }
    }
}
