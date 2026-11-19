namespace WinFormsUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnAdd = new Button();
            this.btnDelete = new Button();
            this.btnShowAll = new Button();
            this.txtName = new TextBox();
            this.txtAge = new TextBox();
            this.txtSex = new TextBox();
            this.listBoxSims = new ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new Point(50, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(94, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new Point(50, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(94, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new Point(50, 221);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new Size(94, 29);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Показать всех";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new Point(328, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(125, 27);
            this.txtName.TabIndex = 5;
            // 
            // txtAge
            // 
            this.txtAge.Location = new Point(483, 47);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new Size(125, 27);
            this.txtAge.TabIndex = 4;
            // 
            // txtSex
            // 
            this.txtSex.Location = new Point(634, 47);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new Size(125, 27);
            this.txtSex.TabIndex = 3;
            // 
            // listBoxSims
            // 
            this.listBoxSims.FormattingEnabled = true;
            this.listBoxSims.Location = new Point(22, 288);
            this.listBoxSims.Name = "listBoxSims";
            this.listBoxSims.Size = new Size(254, 144);
            this.listBoxSims.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.listBoxSims);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Sims Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        private Button btnShowAll;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtSex;
        private ListBox listBoxSims;
    }
}