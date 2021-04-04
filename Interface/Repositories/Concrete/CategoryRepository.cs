using Interface.Entites.Concrete;
using Interface.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Repositories.Concrete
{
    public class CategoryRepository : IBaseRepository,ICategoryRepository
    {
        public void CreateCategory(string categoryName, string descirption, ListView listView)
        {
            Category category = new Category();
            category.Id = Guid.NewGuid();
            category.Name = categoryName;
            category.Description = descirption;

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = category.Id.ToString();
            listViewItem.SubItems.Add(category.Name);
            listViewItem.SubItems.Add(category.Description);
            listViewItem.SubItems.Add(category.CreateDate.ToString());
            listViewItem.SubItems.Add(category.Status.ToString());

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
    }
}
