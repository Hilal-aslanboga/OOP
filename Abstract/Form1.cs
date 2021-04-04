using Abstract.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.CreateCategory(txtName.Text, txtDescription.Text);
            categoryRepository.ListOfCategories(listView1);
            categoryRepository.Eraser(groupBox1);
        }
    }
}
