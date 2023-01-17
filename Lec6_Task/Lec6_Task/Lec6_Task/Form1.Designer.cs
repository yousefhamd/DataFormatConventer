namespace Lec6_Task
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shwID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shwName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shwAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shwTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shwDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shwSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 544);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Save Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Show Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shwID,
            this.shwName,
            this.shwAddress,
            this.shwTel,
            this.shwDate,
            this.shwSalary});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 432);
            this.dataGridView1.TabIndex = 1;
            // 
            // shwID
            // 
            this.shwID.HeaderText = "ID";
            this.shwID.Name = "shwID";
            // 
            // shwName
            // 
            this.shwName.HeaderText = "Name";
            this.shwName.Name = "shwName";
            // 
            // shwAddress
            // 
            this.shwAddress.HeaderText = "Address";
            this.shwAddress.Name = "shwAddress";
            // 
            // shwTel
            // 
            this.shwTel.HeaderText = "Tel";
            this.shwTel.Name = "shwTel";
            // 
            // shwDate
            // 
            this.shwDate.HeaderText = "Date";
            this.shwDate.Name = "shwDate";
            // 
            // shwSalary
            // 
            this.shwSalary.HeaderText = "Salary";
            this.shwSalary.Name = "shwSalary";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(257, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 97);
            this.button4.TabIndex = 5;
            this.button4.Text = "Save JSON";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 97);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save SQL Server";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(457, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 97);
            this.button3.TabIndex = 6;
            this.button3.Text = "Save XML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Lec6_Task.Properties.Resources.load;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(266, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 104);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(84, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(451, 56);
            this.button5.TabIndex = 2;
            this.button5.Text = "Show";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 544);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shwID;
        private System.Windows.Forms.DataGridViewTextBoxColumn shwName;
        private System.Windows.Forms.DataGridViewTextBoxColumn shwAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn shwTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn shwDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn shwSalary;
    }
}

