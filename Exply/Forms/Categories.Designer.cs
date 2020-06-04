namespace Exply.Forms
{
    partial class Categories
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
            this.btnClocse = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnUpdateshoForm = new System.Windows.Forms.Button();
            this.btnDeleteShowForm = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlManageCategory = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameUp = new System.Windows.Forms.TextBox();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.pnlManageButtons = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlSide.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlManageCategory.SuspendLayout();
            this.pnlManageButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClocse
            // 
            this.btnClocse.FlatAppearance.BorderSize = 0;
            this.btnClocse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClocse.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClocse.Location = new System.Drawing.Point(12, 12);
            this.btnClocse.Name = "btnClocse";
            this.btnClocse.Size = new System.Drawing.Size(92, 48);
            this.btnClocse.TabIndex = 0;
            this.btnClocse.Text = "X";
            this.btnClocse.UseVisualStyleBackColor = true;
            this.btnClocse.Click += new System.EventHandler(this.btnClocse_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.btnClocse);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(818, 100);
            this.pnlHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(3)))), ((int)(((byte)(48)))));
            this.pnlSide.Controls.Add(this.lstCategories);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.ForeColor = System.Drawing.Color.White;
            this.pnlSide.Location = new System.Drawing.Point(0, 100);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(233, 596);
            this.pnlSide.TabIndex = 2;
            // 
            // btnUpdateshoForm
            // 
            this.btnUpdateshoForm.FlatAppearance.BorderSize = 0;
            this.btnUpdateshoForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateshoForm.Location = new System.Drawing.Point(143, 35);
            this.btnUpdateshoForm.Name = "btnUpdateshoForm";
            this.btnUpdateshoForm.Size = new System.Drawing.Size(140, 48);
            this.btnUpdateshoForm.TabIndex = 0;
            this.btnUpdateshoForm.Text = "Update Category";
            this.btnUpdateshoForm.UseVisualStyleBackColor = true;
            this.btnUpdateshoForm.Click += new System.EventHandler(this.btnUpdateshoForm_Click);
            // 
            // btnDeleteShowForm
            // 
            this.btnDeleteShowForm.FlatAppearance.BorderSize = 0;
            this.btnDeleteShowForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteShowForm.Location = new System.Drawing.Point(300, 35);
            this.btnDeleteShowForm.Name = "btnDeleteShowForm";
            this.btnDeleteShowForm.Size = new System.Drawing.Size(140, 48);
            this.btnDeleteShowForm.TabIndex = 0;
            this.btnDeleteShowForm.Text = "Delete Category";
            this.btnDeleteShowForm.UseVisualStyleBackColor = true;
            this.btnDeleteShowForm.Click += new System.EventHandler(this.btnDeleteShowForm_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlManageButtons);
            this.pnlMain.Controls.Add(this.pnlManageCategory);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(233, 100);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(585, 596);
            this.pnlMain.TabIndex = 3;
            // 
            // pnlManageCategory
            // 
            this.pnlManageCategory.Controls.Add(this.label4);
            this.pnlManageCategory.Controls.Add(this.txtNameUp);
            this.pnlManageCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlManageCategory.Name = "pnlManageCategory";
            this.pnlManageCategory.Size = new System.Drawing.Size(585, 127);
            this.pnlManageCategory.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name :";
            // 
            // txtNameUp
            // 
            this.txtNameUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameUp.Location = new System.Drawing.Point(143, 68);
            this.txtNameUp.Multiline = true;
            this.txtNameUp.Name = "txtNameUp";
            this.txtNameUp.Size = new System.Drawing.Size(297, 41);
            this.txtNameUp.TabIndex = 1;
            // 
            // lstCategories
            // 
            this.lstCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 16;
            this.lstCategories.Location = new System.Drawing.Point(0, 0);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(291, 745);
            this.lstCategories.TabIndex = 0;
            this.lstCategories.SelectedValueChanged += new System.EventHandler(this.lstCategories_SelectedValueChanged);
            // 
            // pnlManageButtons
            // 
            this.pnlManageButtons.Controls.Add(this.btnUpdateshoForm);
            this.pnlManageButtons.Controls.Add(this.btnDeleteShowForm);
            this.pnlManageButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageButtons.Location = new System.Drawing.Point(0, 127);
            this.pnlManageButtons.Name = "pnlManageButtons";
            this.pnlManageButtons.Size = new System.Drawing.Size(585, 114);
            this.pnlManageButtons.TabIndex = 10;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 696);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(818, 696);
            this.MinimumSize = new System.Drawing.Size(818, 696);
            this.Name = "Categories";
            this.Text = "Categories";
            this.pnlHeader.ResumeLayout(false);
            this.pnlSide.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlManageCategory.ResumeLayout(false);
            this.pnlManageCategory.PerformLayout();
            this.pnlManageButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClocse;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button btnDeleteShowForm;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameUp;
        private System.Windows.Forms.Panel pnlManageCategory;
        private System.Windows.Forms.Button btnUpdateshoForm;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Panel pnlManageButtons;
    }
}