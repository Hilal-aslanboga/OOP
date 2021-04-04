using Polymorphism.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnElektrik_Click(object sender, EventArgs e)
        {
            ElektirikFaturasiRepository repo = new ElektirikFaturasiRepository();
            repo.Irsaliye();
        }

        private void btnSu_Click_1(object sender, EventArgs e)
        {
            SuFaturasiRepository repo = new SuFaturasiRepository();
            repo.Irsaliye();
        }

        private void btnDogalGaz_Click_1(object sender, EventArgs e)
        {
            DogalGazFaturasiRepository repo = new DogalGazFaturasiRepository();
            repo.Irsaliye();
        }
    }
}
