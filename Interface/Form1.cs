using Interface.Entites.Enums;
using Interface.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AppUserRepository userRepository = new AppUserRepository();

        private void Form1_Load(object sender, EventArgs e)
        {
            userRepository.GetRole(cmbRole);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.CreateCategory(txtName.Text, txtDescription.Text, listView1);
            categoryRepository.Eraser(groupBox1);
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            userRepository.CreateUser(
                txtFirstName.Text,
                txtLastName.Text,
                (Role)Enum.Parse(typeof(Role), cmbRole.Text),
                listView1);
            userRepository.Eraser(groupBox3);
        }
    }
}
