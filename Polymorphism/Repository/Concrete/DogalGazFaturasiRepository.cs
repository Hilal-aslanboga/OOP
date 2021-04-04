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
    class DogalGazFaturasiRepository : IBaseRepository
    {
        public string FaturaOde() => "Dogal gaz faturası ödendi..!";

        public void Irsaliye()
        {
            DogalGazFaturasi dogalGazFaturası = new DogalGazFaturasi();
            dogalGazFaturası.FaturaNo = 21321;
            dogalGazFaturası.FaturaAdı = "Dogal Gaz";

            MessageBox.Show($"Fatura No: {dogalGazFaturası.FaturaNo}\nFatura Adı: {dogalGazFaturası.FaturaAdı}\nFatura Kesim Tarihi: {dogalGazFaturası.FaturaKesimTarihi}\n{FaturaOde()}");
        }
    }
}
