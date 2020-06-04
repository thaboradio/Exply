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
using LiveCharts;
using LiveCharts.Wpf;

namespace Exply.Forms
{
    public partial class Dashboard : Form
    {
        ExplyEntities Entities = new ExplyEntities();
        public Dashboard()
        {
            InitializeComponent();
            lblCategories.Text = GetCountCategories().ToString();
            lblExpense.Text = GetCountExpenses().ToString(); ;
            LoadChartData();
        }

        public int GetCountCategories()
        {
            var model = Entities.Categories.Count();
            return model;
        }

        public int GetCountExpenses()
        {
            var model = Entities.Expenses.Count();
            return model;
        }

        public void LoadChartData()
        {
            var categoryList = Entities.Categories.ToList();
            var monthlyCount = 0;
            var groceriesCount = 0;
            var otherCount = 0;
            var loansCount = 0;

            monthlyCount = Entities.Expenses.Where(e => e.Category == 1).Count();
            groceriesCount = Entities.Expenses.Where(e => e.Category == 2).Count();
            otherCount = Entities.Expenses.Where(e => e.Category == 8).Count();
            loansCount = Entities.Expenses.Where(e => e.Category == 7).Count();

            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:p})", chartPoint.Y, chartPoint.Participation);
            //var model = Entities.Categories
            allTimePieChart.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Monthly Bills",
                    Values = new ChartValues<double> {monthlyCount},
                    //PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Groceries",
                    Values = new ChartValues<double> {groceriesCount},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Transport",
                    Values = new ChartValues<double> {otherCount},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Loans",
                    Values = new ChartValues<double> {loansCount},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };
            allTimePieChart.LegendLocation = LegendLocation.Bottom;
            allTimePieChart.BackColor = SystemColors.Control;
        }

        //public IEnumerable<Category> ExpensesCategory()
        //{
        //    List<Category> CategoryList = new List<Category>();
        //    var model = Entities.Expenses.ToList();

        //    foreach (var item in model)
        //    {
                
        //    }

        //}

        //public List GetCategory(int id)
        //{
        //    var model = Entities.Categories.Find(id);
        //    return model.Description;
        //}

    }
}
