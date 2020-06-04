using Exply.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exply.Forms
{
    public partial class CategoryAdd : Form
    {
        ExplyEntities Entities = new ExplyEntities();
        public CategoryAdd()
        {
            InitializeComponent();
            GetAllCategories();
            lstCategories.ClearSelected();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategoryName.Text != string.Empty || !string.IsNullOrWhiteSpace(txtCategoryName.Text))
                {
                    Category category = new Category();
                    category.Description = txtCategoryName.Text;
                    var model = Entities.Categories.Add(category);
                    int results = Entities.SaveChanges();
                    if (results >= 0)
                    {
                        MessageBox.Show("Record Saved Successfully", "Exply", MessageBoxButtons.OK);
                    }
                    GetAllCategories();
                    txtCategoryName.Clear();
                }
                else
                {
                    txtCategoryName.Focus();
                    MessageBox.Show("Enter Category Name", "Exply", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Exply", MessageBoxButtons.OK);
            }


        }

        void GetAllCategories()
        {
            
            var model = Entities.Categories.ToList();

            lstCategories.DataSource = model;
            lstCategories.ValueMember = "Id";
            lstCategories.DisplayMember = "Description";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoryAdd_Load(object sender, EventArgs e)
        {
            
        }

        void UpdateCategory(int id, Category cat)
        {
            
           
            var model = Entities.Categories.Find(id);
            if(model != null)
            {
                model.Description = cat.Description;
                Entities.SaveChanges();
                GetAllCategories();
            }
        }

        
    }
}
