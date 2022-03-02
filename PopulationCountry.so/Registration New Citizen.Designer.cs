namespace PopulationCountry.so
{
    partial class Form2
    {
        ///// <summary>
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textNew = new System.Windows.Forms.Button();
            this.Gender = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.myConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myConnectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 59);
            this.button1.TabIndex = 30;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(108, 36);
            this.textName.MaxLength = 99767;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(129, 20);
            this.textName.TabIndex = 29;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(116, 144);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 20);
            this.textAge.TabIndex = 27;
            this.textAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(116, 208);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 20);
            this.textAddress.TabIndex = 25;
            this.textAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textAddress.TextChanged += new System.EventHandler(this.textAddress_TextChanged);
            // 
            // textPhone
            // 
            this.textPhone.AllowDrop = true;
            this.textPhone.Location = new System.Drawing.Point(116, 179);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 20);
            this.textPhone.TabIndex = 24;
            this.textPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPhone.TextChanged += new System.EventHandler(this.textPhone_TextChanged);
            // 
            // textId
            // 
            this.textId.AllowDrop = true;
            this.textId.Enabled = false;
            this.textId.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textId.Location = new System.Drawing.Point(116, 10);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 23;
            this.textId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "PersonalColor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // textNew
            // 
            this.textNew.Location = new System.Drawing.Point(59, 260);
            this.textNew.Name = "textNew";
            this.textNew.Size = new System.Drawing.Size(75, 59);
            this.textNew.TabIndex = 32;
            this.textNew.Text = "AddNew";
            this.textNew.UseVisualStyleBackColor = true;
            this.textNew.Click += new System.EventHandler(this.textNew_Click);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(324, 131);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(0, 13);
            this.Gender.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Gender";
            // 
            // comboGender
            // 
            this.comboGender.AllowDrop = true;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboGender.Location = new System.Drawing.Point(108, 65);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(121, 21);
            this.comboGender.Sorted = true;
            this.comboGender.TabIndex = 37;
            this.comboGender.TabStop = false;
            this.comboGender.SelectedIndexChanged += new System.EventHandler(this.comboGender_SelectedIndexChanged);
            this.comboGender.Click += new System.EventHandler(this.comboGender_Click);
            this.comboGender.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboGender_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(243, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 309);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(711, 349);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 59);
            this.Update.TabIndex = 40;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 59);
            this.button2.TabIndex = 41;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.AllowDrop = true;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Black",
            "Normal",
            "White"});
            this.comboBoxColor.Location = new System.Drawing.Point(109, 106);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.Sorted = true;
            this.comboBoxColor.TabIndex = 42;
            this.comboBoxColor.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(373, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 59);
            this.button3.TabIndex = 43;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // myConnectionBindingSource
            // 
            this.myConnectionBindingSource.DataSource = typeof(PopulationCountry.so.MyConnection);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1068, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.textNew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textId);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration New Citizen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myConnectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button textNew;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.BindingSource myConnectionBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Button button3;
    }
}