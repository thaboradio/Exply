using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exply.Data;
namespace Exply.Forms
{
    public partial class Categories : Form
    {
        ExplyEntities Entities = new ExplyEntities();
        private List<Category> categories = new List<Category>();
        public Categories()
        {
            InitializeComponent();
            PopulateListbox();
        }

        private void btnClocse_Click(object sender, EventArgs e)
        {
            this.Close();
            ExplyMain mainForm = new ExplyMain();
        }

        private void btnUpdateshoForm_Click(object sender, EventArgs e)
        {
            UpdateCategory(Convert.ToInt32(lstCategories.SelectedValue));
        }

        private void btnDeleteShowForm_Click(object sender, EventArgs e)
        {
            DeleteCategory(Convert.ToInt32(lstCategories.SelectedValue));
        }

        string GetCategoryName(int id)
        {
            var model = Entities.Categories.Find(id);
            return model.Description;
        }

      
        void PopulateListbox()
        {
            
            lstCategories.DataSource = Entities.Categories.ToList();
            lstCategories.DisplayMember = "Description";
            lstCategories.ValueMember = "Id";
        }

        private void lstCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            txtNameUp.Text = lstCategories.GetItemText(lstCategories.SelectedItem);
        }

        void UpdateCategory(int id)
        {
            var model = Entities.Categories.Find(id);
            if(model != null)
            {
                model.Description = txtNameUp.Text;
                //Entities.Entry(model).State = System.Data.Entity.EntityState.Modified;
                Entities.SaveChanges();
                MessageBox.Show("Record Updated Successfully", "Exply", MessageBoxButtons.OK);
                PopulateListbox();
            }
        }

        void DeleteCategory(int id)
        {
            var model = Entities.Categories.Find(id);
            if(model != null)
            {
                Entities.Categories.Remove(model);
                Entities.SaveChanges();
            }
        }
    }
}
