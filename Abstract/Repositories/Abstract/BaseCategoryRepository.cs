using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract.Repositories.Abstract
{
    //Repository uygulama mantığı içersinde her üye için yürütülecek CRUD (Create - Update - Delete)operasyonlarında bize yardımcı olarak methodların tutlduğu yerdir.  
    public abstract class BaseCategoryRepository
    {
        public abstract void CreateCategory(string categoryName, string description);
        public abstract void Eraser(GroupBox groupBox);

        //Her iki methodunda gövdesi bulunmamaktadır. Bunun sebebi bu sınıf alt sınıflarda override ediliceğinden dolayı gövde kazandırmak mantıksız olurdu zaten c# buna izin vermez.
        // İhtiyaç halinde kalıtım verdiğimiz sınıfta düzenlemeler gerçekleştirilir.


        //Abtract sınıfları virtual olarak işaretlenmez zaten alt sınıflarda override etmek zorundayız.
        public abstract void ListOfCategories(ListView listView);
    }
}
