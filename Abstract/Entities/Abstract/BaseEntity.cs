using Abstract.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Entities.Abstract
{
    // Bir sınıfı soyutlaştırmak istersek ilk olarak o sınıfı abstract olarak işaretlemektir.
   public abstract class BaseEntity
    {
        //Abstract bir sınıf içersinde "abstract" olarak işaretlenmiş bir üye varsa kural koyma yeteneğinden faydalanmış olduk. 
        //Böylelikle alt sınıflarda override edilmeye zorunlu kılıyoruz.
        public abstract Guid Id { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate
        {
            get=> _createDate;
            set=> _createDate = value;
        }

        private Status _status = Status.Active;
        public Status Status
        {
            get => _status;
            set=> _status = value;
        }
    }
}
