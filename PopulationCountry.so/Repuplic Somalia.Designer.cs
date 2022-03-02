namespace PopulationCountry.so
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.butt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::PopulationCountry.so.Properties.Resources.flag;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::PopulationCountry.so.Properties.Resources.FederalRepuplicSomalia;
            this.pictureBox2.Location = new System.Drawing.Point(503, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 172);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(-2, 6);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(405, 41);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Federal Repuplic Of Somalia  ";
            this.richTextBox1.ZoomFactor = 1.9F;
            // 
            // butt
            // 
            this.butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butt.Location = new System.Drawing.Point(503, 293);
            this.butt.Name = "butt";
            this.butt.Size = new System.Drawing.Size(110, 56);
            this.butt.TabIndex = 2;
            this.butt.Text = "Add New Citizen To Somalia";
            this.butt.UseVisualStyleBackColor = true;
            this.butt.Click += new System.EventHandler(this.butt_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(638, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = "Search Citizen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.Location = new System.Drawing.Point(438, 20);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(9, 9, 9, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.ShowSelectionMargin = true;
            this.richTextBox2.Size = new System.Drawing.Size(347, 41);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "Be a Part Citizen Of Somalia";
            this.richTextBox2.ZoomFactor = 1.8F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(834, 479);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butt);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Repuplic Somalia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button butt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

