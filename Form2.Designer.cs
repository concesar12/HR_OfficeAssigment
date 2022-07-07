
namespace HR_OfficeAssigment
{
    partial class Form2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InsertEmployee = new System.Windows.Forms.Button();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.HireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartmentModifier = new System.Windows.Forms.ComboBox();
            this.YearHiredTable = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.ShowEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YearHiredTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "HR Office Management";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(444, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(39, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date of Hired";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Full Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Id Employee";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sick leaves taken";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Allowable sick Leaves";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Department";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(385, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Annual salary";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 23);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(510, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 23);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(510, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(36, 23);
            this.textBox3.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(148, 147);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(127, 23);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(511, 139);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(35, 23);
            this.textBox8.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "<< Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 28);
            this.button2.TabIndex = 21;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(321, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 27);
            this.button3.TabIndex = 22;
            this.button3.Text = "Modify";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(239, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Department No";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(334, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(39, 23);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(463, 244);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(117, 29);
            this.DeleteButton.TabIndex = 25;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InsertEmployee
            // 
            this.InsertEmployee.Location = new System.Drawing.Point(172, 245);
            this.InsertEmployee.Name = "InsertEmployee";
            this.InsertEmployee.Size = new System.Drawing.Size(117, 28);
            this.InsertEmployee.TabIndex = 26;
            this.InsertEmployee.Text = "Add New";
            this.InsertEmployee.UseVisualStyleBackColor = true;
            this.InsertEmployee.Click += new System.EventHandler(this.InsertEmployee_Click);
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(149, 173);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(223, 23);
            this.BirthDatePicker.TabIndex = 27;
            // 
            // HireDatePicker
            // 
            this.HireDatePicker.Location = new System.Drawing.Point(148, 202);
            this.HireDatePicker.Name = "HireDatePicker";
            this.HireDatePicker.Size = new System.Drawing.Size(224, 23);
            this.HireDatePicker.TabIndex = 28;
            // 
            // DepartmentModifier
            // 
            this.DepartmentModifier.FormattingEnabled = true;
            this.DepartmentModifier.Location = new System.Drawing.Point(510, 207);
            this.DepartmentModifier.Name = "DepartmentModifier";
            this.DepartmentModifier.Size = new System.Drawing.Size(138, 23);
            this.DepartmentModifier.TabIndex = 29;
            this.DepartmentModifier.SelectedIndexChanged += new System.EventHandler(this.DepartmentModifier_SelectedIndexChanged);
            // 
            // YearHiredTable
            // 
            this.YearHiredTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.YearHiredTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YearHiredTable.Location = new System.Drawing.Point(32, 435);
            this.YearHiredTable.Name = "YearHiredTable";
            this.YearHiredTable.RowTemplate.Height = 25;
            this.YearHiredTable.Size = new System.Drawing.Size(628, 142);
            this.YearHiredTable.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 15);
            this.label13.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(159, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 29);
            this.button4.TabIndex = 34;
            this.button4.Text = "2 Years";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(290, 376);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 29);
            this.button5.TabIndex = 35;
            this.button5.Text = "6 months";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(425, 376);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 29);
            this.button6.TabIndex = 36;
            this.button6.Text = "Sick Leaves";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(553, 376);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 29);
            this.button7.TabIndex = 37;
            this.button7.Text = "Salary";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(12, 321);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 39);
            this.label14.TabIndex = 38;
            this.label14.Text = "Filters";
            // 
            // ShowEmployees
            // 
            this.ShowEmployees.Location = new System.Drawing.Point(34, 376);
            this.ShowEmployees.Name = "ShowEmployees";
            this.ShowEmployees.Size = new System.Drawing.Size(106, 29);
            this.ShowEmployees.TabIndex = 39;
            this.ShowEmployees.Text = "Show Employees";
            this.ShowEmployees.UseVisualStyleBackColor = true;
            this.ShowEmployees.Click += new System.EventHandler(this.ShowEmployees_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 589);
            this.Controls.Add(this.ShowEmployees);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.YearHiredTable);
            this.Controls.Add(this.DepartmentModifier);
            this.Controls.Add(this.HireDatePicker);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.InsertEmployee);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YearHiredTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button InsertEmployee;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.DateTimePicker HireDatePicker;
        private System.Windows.Forms.ComboBox DepartmentModifier;
        private System.Windows.Forms.DataGridView YearHiredTable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ShowEmployees;
    }
}