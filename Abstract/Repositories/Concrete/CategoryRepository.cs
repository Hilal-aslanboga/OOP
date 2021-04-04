using Abstract.Entities.Concrete;
using Abstract.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract.Repositories.Concrete
{
    class CategoryRepository : BaseCategoryRepository
    {
        Category category;

        public override void CreateCategory(string categoryName, string description)
        {
            category = new Category();
            category.Name = categoryName;
            category.Description = description;
        }

        public override void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = String.Empty;
                }
            }
        }

        public override void ListOfCategories(ListView listView)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = category.Id.ToString();
            listViewItem.SubItems.Add(category.Name);
            listViewItem.SubItems.Add(category.Description);
            listViewItem.SubItems.Add(category.Status.ToString());
            listViewItem.SubItems.Add(category.CreateDate.ToString());


            listView.Items.Add(listViewItem);

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
