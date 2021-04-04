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
    class SuFaturasiRepository : IBaseRepository
    {
        public string FaturaOde() => "Su faturası ödendi..!";

        public void Irsaliye()
        {
            SuFaturasi suFaturası = new SuFaturasi();
            suFaturası.FaturaNo = 21321;
            suFaturası.FaturaAdı = "Su Faturası";

            MessageBox.Show($"Fatura No: {suFaturası.FaturaNo}\nFatura Adı: {suFaturası.FaturaAdı}\nFatura Kesim Tarihi: {suFaturası.FaturaKesimTarihi}\nDurumu: {FaturaOde()}");
        }
    }
}
