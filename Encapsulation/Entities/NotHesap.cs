using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Entities
{
    //Encapsulation sınıfın herhangi bir üyesine yapılan erişimin kontrol altına alınmasıdır.
    // Bir başka deyişle söylemek gerekirse dış erişime kapalı üyeye get ve set mothdları ile kontrollü bir şekilde erişmeye denir.
    public class NotHesap
    {
        private string _ad;
        public string Ad
        {
            get {return _ad;} // field içersindeki değeri dışarıya gönder
            set { _ad = value.ToUpper(); } // dışarıdan gelen değeri field'a ata 
        }

        private string _soyad;
        public string Soyad
        {
            get {return _soyad; }
            set {_soyad=value.ToUpper(); }
        }

        private string _ders;
        public string Ders
        {
            get => _ders; 
            set => _ders = value.ToUpper();
        }

        private double _vize;
        public double Vize
        {
            get => _vize;
            set { _vize = value * 0.3; }
        }

        private double _final;
        public double Final
        {
            get => _final;
            set { _final = value * 0.7;}
            
        }

        private double _ortalama;
        public double Ortalama
        {
            get => _ortalama = _vize + _final;          
        }
    }
}
