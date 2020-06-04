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
    public partial class Expenses : Form
    {
        ExplyEntities Entities = new ExplyEntities();
        public List<ExpenseVM> expensesList = new List<ExpenseVM>();
        public Expenses()
        {
            
            InitializeComponent();
            LoadData();

            dataGridView1.DataSource = expensesList;
            dataGridView1.ForeColor = Color.Black;
         
        }

        public void LoadData()
        {
            var expense = new ExpenseVM();
            var listOfItems = Entities.Expenses.ToList();
            foreach (var item in listOfItems)
            {
                expense.Id = item.Id;
                expense.Name = item.Name;
                expense.Description = item.Description;
                expense.Amount = item.Amount;
                expense.Date = item.Date;
                expense.Category = item.Category;
                expensesList.Add(expense);
            }
        }
        
    }

    public class ExpenseVM
    {
        public ExpenseVM()
        {

        }
        public int Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> Category { get; set; }
        

        //public Category Category1 { get; set; }
    }
}
