using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Repositories.Interface
{
   public interface ICategoryRepository
    {
        void CreateCategory(string categoryName, string descirption, ListView listView);
    }
}
