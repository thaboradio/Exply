namespace Exply.Forms
{
    partial class CategoryAdd
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
            this.pnlCategoryForm = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCategoryHeader = new System.Windows.Forms.Label();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.pnlCategoryForm.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategoryForm
            // 
            this.pnlCategoryForm.Controls.Add(this.pnlSave);
            this.pnlCategoryForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategoryForm.Location = new System.Drawing.Point(250, 125);
            this.pnlCategoryForm.Name = "pnlCategoryForm";
            this.pnlCategoryForm.Size = new System.Drawing.Size(550, 466);
            this.pnlCategoryForm.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(62, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(387, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Category";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(142, 6);
            this.txtCategoryName.Multiline = true;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(297, 41);
            this.txtCategoryName.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(47, 6);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(125, 29);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Name :";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblCategoryHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(250, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(550, 125);
            this.pnlHeader.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(15, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 60);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCategoryHeader
            // 
            this.lblCategoryHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategoryHeader.Location = new System.Drawing.Point(147, 30);
            this.lblCategoryHeader.Name = "lblCategoryHeader";
            this.lblCategoryHeader.Size = new System.Drawing.Size(196, 39);
            this.lblCategoryHeader.TabIndex = 1;
            this.lblCategoryHeader.Text = "Category";
            this.lblCategoryHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCategories
            // 
            this.pnlCategories.Controls.Add(this.lstCategories);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCategories.Location = new System.Drawing.Point(0, 0);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(250, 591);
            this.pnlCategories.TabIndex = 4;
            // 
            // lstCategories
            // 
            this.lstCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 16;
            this.lstCategories.Location = new System.Drawing.Point(0, 0);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(250, 591);
            this.lstCategories.TabIndex = 0;

            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.txtCategoryName);
            this.pnlSave.Controls.Add(this.lblCategoryName);
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSave.Location = new System.Drawing.Point(0, 0);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(550, 125);
            this.pnlSave.TabIndex = 3;
            // 
            // CategoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.pnlCategoryForm);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlCategories);
            this.Name = "CategoryAdd";
            this.Text = "CategryAdd";
            this.Load += new System.EventHandler(this.CategoryAdd_Load);
            this.pnlCategoryForm.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlCategories.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.pnlSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategoryForm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCategoryHeader;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Panel pnlSave;
    }
}