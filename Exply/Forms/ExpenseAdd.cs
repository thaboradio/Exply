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
    public partial class ExpenseAdd : Form
    {
        ExplyEntities Entities = new ExplyEntities();
        public ExpenseAdd()
        {
            InitializeComponent();
            GetAllCategories();
            dtpExpenseDate.MaxDate = DateTime.Today;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Expens expense = new Expens();
                var model = Entities.Expenses;

                expense.Name = txtName.Text;
                expense.Date = dtpExpenseDate.Value;
                expense.Description = rtbDescription.Text;
                expense.Amount = Convert.ToDecimal(txtAmount.Text);
                expense.Category = Convert.ToInt32(cmCategory.SelectedValue);
                expense.Remark = rtbRemarks.Text;

                model.Add(expense);
                int results = Entities.SaveChanges();
                if (results <= 0)
                {
                    MessageBox.Show("An error occured while trying to save record", "Exply", MessageBoxButtons.OK);
                }
                else
                {
                    ClearControls();
                    MessageBox.Show("Record Saved Successfully", "Exply", MessageBoxButtons.OK);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Exply", MessageBoxButtons.OK);
            }

        }

        void ClearControls()
        {
            txtAmount.Clear();
            txtName.Clear();
            rtbDescription.Clear();
            rtbRemarks.Clear();
            dtpExpenseDate.Value = DateTime.Today;
            cmCategory.ResetText();
        }

        void GetAllCategories()
        {
            var model = Entities.Categories.ToList();
            cmCategory.DataSource = model;
            cmCategory.DisplayMember = "Description";
            cmCategory.ValueMember = "Id";
            cmCategory.Invalidate();
        }

    }
}
