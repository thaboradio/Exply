using Exply.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Exply
{
    public partial class ExplyMain : Form
    {
        public ExplyMain()
        {
            InitializeComponent();
            CustomizeDesign();
            Dashboard dash = new Dashboard();
            openChildForm(dash);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void CustomizeDesign()
        {
            //Hide submenus
            pnlManage.Visible = false;
        }

        private void ExplyMain_Load(object sender, EventArgs e)
        {

        }

        public void HideShowManagePanel()
        {
            pnlManage.Visible = !pnlManage.Visible;
            
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            HideShowManagePanel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExpenseAdd expenseAddForm = new ExpenseAdd();
            openChildForm(expenseAddForm);
            //pnlButtons.Hide();
        }

        private Form ActiveForm = null;
        private void openChildForm(Form childForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            //pnlHeaderExpense.Show();
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlForms.Controls.Add(childForm);
            pnlForms.Tag = childForm;
            childForm.BackColor = this.BackColor;
            childForm.Show();
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            //pnlButtons.Hide();
            Categories categories = new Categories();
            openChildForm(categories);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryAdd categoriesForm = new CategoryAdd();
            openChildForm(categoriesForm);
            //pnlButtons.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            openChildForm(dash);
        }

        private void btnManageExpenses_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            openChildForm(expenses);
        }

        private void btnAddCategories_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryAdd());
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            openChildForm(new ExpenseAdd());
        }
    }
}
