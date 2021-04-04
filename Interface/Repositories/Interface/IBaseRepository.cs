using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Repositories.Interface
{   
    //BaseRepository her varlık için CRUD operasyonlarındaki ortak methodların barındırılıcağı yerdir.
    public interface IBaseRepository
    {
        void Eraser(GroupBox groupBox);
    }
}
