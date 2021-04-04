using Interface.Entites.Concrete;
using Interface.Entites.Enums;
using Interface.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Repositories.Concrete
{
    //AppUserRepository sınıfı hem IBaseRepository hemde IAppUserRepository sınıflarından kalıtım almıştır. Böylelikle child olan AppUserRepository sınıfı iki atadan kalıtım alarak çoklu kalıtım yapılmıştır.

    public class AppUserRepository : IBaseRepository, IAppUserRepository
    {
        public void CreateUser(string firstnName, string lastName, Role role, ListView listView)
        {
            AppUser appUser = new AppUser();
            appUser.Id = 1;
            appUser.FirstName = firstnName;
            appUser.LastName = lastName;
            appUser.Role = role;

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = appUser.Id.ToString();
            listViewItem.SubItems.Add(appUser.FirstName);
            listViewItem.SubItems.Add(appUser.LastName);
            listViewItem.SubItems.Add(appUser.Role.ToString());
            listViewItem.SubItems.Add(appUser.Status.ToString());
            listViewItem.SubItems.Add(appUser.CreateDate.ToString());

            listView.Items.Add(listViewItem);
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = String.Empty;
                }
            }
        }

        public void GetRole(ComboBox comboBox)
        {
            comboBox.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBox.SelectedIndex = 0;
        }
    }
}
