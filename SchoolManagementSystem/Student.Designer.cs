namespace SchoolManagementSystem
{
    partial class Student
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.GendertextBox = new System.Windows.Forms.TextBox();
            this.SNametextBox = new System.Windows.Forms.TextBox();
            this.SIdtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.DelBtn);
            this.groupBox1.Controls.Add(this.UpdateBtn);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.EmailtextBox);
            this.groupBox1.Controls.Add(this.PhonetextBox);
            this.groupBox1.Controls.Add(this.GendertextBox);
            this.groupBox1.Controls.Add(this.SNametextBox);
            this.groupBox1.Controls.Add(this.SIdtextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 444);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolManagementSystem.Properties.Resources.photo_1456513080510_7bf3a84b82f8;
            this.pictureBox1.Location = new System.Drawing.Point(570, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Aqua;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(650, 360);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(170, 38);
            this.ClearBtn.TabIndex = 17;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.Aqua;
            this.DelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.Location = new System.Drawing.Point(456, 360);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(170, 38);
            this.DelBtn.TabIndex = 16;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Aqua;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(260, 360);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(170, 38);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Aqua;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(64, 360);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(170, 38);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(278, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailtextBox.Location = new System.Drawing.Point(278, 309);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(232, 27);
            this.EmailtextBox.TabIndex = 11;
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhonetextBox.Location = new System.Drawing.Point(278, 258);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(232, 27);
            this.PhonetextBox.TabIndex = 10;
            // 
            // GendertextBox
            // 
            this.GendertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GendertextBox.Location = new System.Drawing.Point(278, 208);
            this.GendertextBox.Name = "GendertextBox";
            this.GendertextBox.Size = new System.Drawing.Size(232, 27);
            this.GendertextBox.TabIndex = 9;
            // 
            // SNametextBox
            // 
            this.SNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNametextBox.Location = new System.Drawing.Point(278, 107);
            this.SNametextBox.Name = "SNametextBox";
            this.SNametextBox.Size = new System.Drawing.Size(232, 27);
            this.SNametextBox.TabIndex = 7;
            // 
            // SIdtextBox
            // 
            this.SIdtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIdtextBox.Location = new System.Drawing.Point(278, 57);
            this.SIdtextBox.Name = "SIdtextBox";
            this.SIdtextBox.Size = new System.Drawing.Size(232, 27);
            this.SIdtextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "DoB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 528);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(881, 192);
            this.dataGridView1.TabIndex = 2;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 732);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.TextBox GendertextBox;
        private System.Windows.Forms.TextBox SNametextBox;
        private System.Windows.Forms.TextBox SIdtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}