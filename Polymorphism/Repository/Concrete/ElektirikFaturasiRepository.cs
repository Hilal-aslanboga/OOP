using Polymorphism.Entities.Concrete;
using Polymorphism.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism.Repository.Concrete
{
    class ElektirikFaturasiRepository : IBaseRepository
    {
        public string FaturaOde() => "Elektirik faturası ödendi..!";

        public void Irsaliye()
        {
            ElektirikFaturasi elektirikFaturası = new ElektirikFaturasi();
            elektirikFaturası.FaturaNo = 21321321;
            elektirikFaturası.FaturaAdı = "Elektirik";

            MessageBox.Show($"Fatura No: {elektirikFaturası.FaturaNo}\nFatura Adı: {elektirikFaturası.FaturaAdı}\nFatura Kesim Tarihi: {elektirikFaturası.FaturaKesimTarihi}\nDurumu: {FaturaOde()}");
        }
    }
}
