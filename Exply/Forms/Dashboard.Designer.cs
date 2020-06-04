namespace Exply.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblExpense = new System.Windows.Forms.Label();
            this.pnCards = new System.Windows.Forms.Panel();
            this.pnGraphs = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allTimePieChart = new LiveCharts.WinForms.PieChart();
            this.label3 = new System.Windows.Forms.Label();
            this.pnCards.SuspendLayout();
            this.pnGraphs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Expenses";
            // 
            // lblCategories
            // 
            this.lblCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(3, 34);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(125, 57);
            this.lblCategories.TabIndex = 1;
            this.lblCategories.Text = "25";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExpense
            // 
            this.lblExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.Location = new System.Drawing.Point(134, 34);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(125, 57);
            this.lblExpense.TabIndex = 1;
            this.lblExpense.Text = "25";
            this.lblExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnCards
            // 
            this.pnCards.Controls.Add(this.lblExpense);
            this.pnCards.Controls.Add(this.label1);
            this.pnCards.Controls.Add(this.lblCategories);
            this.pnCards.Controls.Add(this.label2);
            this.pnCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCards.Location = new System.Drawing.Point(0, 0);
            this.pnCards.Name = "pnCards";
            this.pnCards.Size = new System.Drawing.Size(637, 149);
            this.pnCards.TabIndex = 2;
            // 
            // pnGraphs
            // 
            this.pnGraphs.Controls.Add(this.panel1);
            this.pnGraphs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGraphs.Location = new System.Drawing.Point(0, 149);
            this.pnGraphs.Name = "pnGraphs";
            this.pnGraphs.Size = new System.Drawing.Size(637, 374);
            this.pnGraphs.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.allTimePieChart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 374);
            this.panel1.TabIndex = 0;
            // 
            // allTimePieChart
            // 
            this.allTimePieChart.ForeColor = System.Drawing.SystemColors.Control;
            this.allTimePieChart.Location = new System.Drawing.Point(3, 44);
            this.allTimePieChart.Name = "allTimePieChart";
            this.allTimePieChart.Size = new System.Drawing.Size(631, 327);
            this.allTimePieChart.TabIndex = 0;
            this.allTimePieChart.Text = "pieChart1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "All Time Data";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 523);
            this.Controls.Add(this.pnGraphs);
            this.Controls.Add(this.pnCards);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.pnCards.ResumeLayout(false);
            this.pnGraphs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Panel pnCards;
        private System.Windows.Forms.Panel pnGraphs;
        private System.Windows.Forms.Panel panel1;
        private LiveCharts.WinForms.PieChart allTimePieChart;
        private System.Windows.Forms.Label label3;
    }
}