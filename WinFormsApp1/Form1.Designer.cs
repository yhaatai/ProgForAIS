namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonAdd = new Button();
            buttonShow = new Button();
            buttonDelete = new Button();
            listSims = new ListBox();
            textName = new TextBox();
            textSex = new TextBox();
            textAge = new TextBox();
            LabelName = new Label();
            LabelAge = new Label();
            LabelSex = new Label();
            labelId = new Label();
            textId = new TextBox();
            buttonUpdate = new Button();
            buttonGetAdult = new Button();
            buttonGetsex = new Button();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(21, 6);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(21, 78);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(94, 29);
            buttonShow.TabIndex = 1;
            buttonShow.Text = "Show";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(21, 43);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // listSims
            // 
            listSims.FormattingEnabled = true;
            listSims.Location = new Point(12, 218);
            listSims.Name = "listSims";
            listSims.Size = new Size(203, 224);
            listSims.TabIndex = 3;
            // 
            // textName
            // 
            textName.Location = new Point(233, 62);
            textName.Name = "textName";
            textName.Size = new Size(125, 27);
            textName.TabIndex = 4;
            textName.TextChanged += textName_TextChanged;
            // 
            // textSex
            // 
            textSex.Location = new Point(561, 62);
            textSex.Name = "textSex";
            textSex.Size = new Size(125, 27);
            textSex.TabIndex = 5;
            // 
            // textAge
            // 
            textAge.Location = new Point(393, 62);
            textAge.Name = "textAge";
            textAge.Size = new Size(125, 27);
            textAge.TabIndex = 6;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(233, 32);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(49, 20);
            LabelName.TabIndex = 7;
            LabelName.Text = "Name";
            LabelName.Click += label1_Click;
            // 
            // LabelAge
            // 
            LabelAge.AutoSize = true;
            LabelAge.Location = new Point(393, 32);
            LabelAge.Name = "LabelAge";
            LabelAge.Size = new Size(36, 20);
            LabelAge.TabIndex = 8;
            LabelAge.Text = "Age";
            // 
            // LabelSex
            // 
            LabelSex.AutoSize = true;
            LabelSex.Location = new Point(561, 32);
            LabelSex.Name = "LabelSex";
            LabelSex.Size = new Size(32, 20);
            LabelSex.TabIndex = 9;
            LabelSex.Text = "Sex";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(725, 32);
            labelId.Name = "labelId";
            labelId.Size = new Size(121, 20);
            labelId.TabIndex = 10;
            labelId.Text = "ID для удаления";
            // 
            // textId
            // 
            textId.Location = new Point(725, 62);
            textId.Name = "textId";
            textId.Size = new Size(125, 27);
            textId.TabIndex = 11;
            textId.TextChanged += textId_TextChanged;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(21, 113);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonGetAdult
            // 
            buttonGetAdult.BackColor = SystemColors.Control;
            buttonGetAdult.Location = new Point(21, 183);
            buttonGetAdult.Name = "buttonGetAdult";
            buttonGetAdult.Size = new Size(94, 29);
            buttonGetAdult.TabIndex = 14;
            buttonGetAdult.Text = "GetAdult";
            buttonGetAdult.UseVisualStyleBackColor = false;
            buttonGetAdult.Click += buttonGetAdult_Click;
            // 
            // buttonGetsex
            // 
            buttonGetsex.BackColor = SystemColors.Control;
            buttonGetsex.BackgroundImageLayout = ImageLayout.Zoom;
            buttonGetsex.ForeColor = SystemColors.ControlText;
            buttonGetsex.Location = new Point(21, 148);
            buttonGetsex.Name = "buttonGetsex";
            buttonGetsex.Size = new Size(94, 29);
            buttonGetsex.TabIndex = 15;
            buttonGetsex.Text = "GetSex";
            buttonGetsex.UseVisualStyleBackColor = false;
            buttonGetsex.Click += buttonGetsex_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1074, 482);
            Controls.Add(buttonGetsex);
            Controls.Add(buttonGetAdult);
            Controls.Add(buttonUpdate);
            Controls.Add(textId);
            Controls.Add(labelId);
            Controls.Add(LabelSex);
            Controls.Add(LabelAge);
            Controls.Add(LabelName);
            Controls.Add(textAge);
            Controls.Add(textSex);
            Controls.Add(textName);
            Controls.Add(listSims);
            Controls.Add(buttonDelete);
            Controls.Add(buttonShow);
            Controls.Add(buttonAdd);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonShow;
        private Button buttonDelete;
        private ListBox listSims;
        private TextBox textName;
        private TextBox textSex;
        private TextBox textAge;
        private Label LabelName;
        private Label LabelAge;
        private Label LabelSex;
        private Label labelId;
        private TextBox textId;
        private Button buttonUpdate;
        private Button button2;
        private Button buttonGetAdult;
        private Button buttonGetsex;
    }
}
