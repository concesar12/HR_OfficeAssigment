
namespace HR_OfficeAssigment
{
    partial class ManagerWindow
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
            this.ManagersTable = new System.Windows.Forms.DataGridView();
            this.ManagerSwap = new System.Windows.Forms.GroupBox();
            this.AssignMan = new System.Windows.Forms.Button();
            this.EmpList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DepList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManagersTable)).BeginInit();
            this.ManagerSwap.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManagersTable
            // 
            this.ManagersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManagersTable.Location = new System.Drawing.Point(12, 83);
            this.ManagersTable.Name = "ManagersTable";
            this.ManagersTable.RowTemplate.Height = 25;
            this.ManagersTable.Size = new System.Drawing.Size(366, 207);
            this.ManagersTable.TabIndex = 0;
            this.ManagersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManagersTable_CellContentClick);
            // 
            // ManagerSwap
            // 
            this.ManagerSwap.Controls.Add(this.AssignMan);
            this.ManagerSwap.Controls.Add(this.EmpList);
            this.ManagerSwap.Controls.Add(this.label3);
            this.ManagerSwap.Controls.Add(this.DepList);
            this.ManagerSwap.Controls.Add(this.label2);
            this.ManagerSwap.Location = new System.Drawing.Point(396, 71);
            this.ManagerSwap.Name = "ManagerSwap";
            this.ManagerSwap.Size = new System.Drawing.Size(243, 258);
            this.ManagerSwap.TabIndex = 1;
            this.ManagerSwap.TabStop = false;
            this.ManagerSwap.Text = "Assign new manager";
            // 
            // AssignMan
            // 
            this.AssignMan.Location = new System.Drawing.Point(39, 206);
            this.AssignMan.Name = "AssignMan";
            this.AssignMan.Size = new System.Drawing.Size(150, 32);
            this.AssignMan.TabIndex = 4;
            this.AssignMan.Text = "Assign";
            this.AssignMan.UseVisualStyleBackColor = true;
            this.AssignMan.Click += new System.EventHandler(this.AssignMan_Click);
            // 
            // EmpList
            // 
            this.EmpList.FormattingEnabled = true;
            this.EmpList.Location = new System.Drawing.Point(9, 158);
            this.EmpList.Name = "EmpList";
            this.EmpList.Size = new System.Drawing.Size(195, 23);
            this.EmpList.TabIndex = 3;
            this.EmpList.SelectedIndexChanged += new System.EventHandler(this.EmpList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assign to employee:";
            // 
            // DepList
            // 
            this.DepList.FormattingEnabled = true;
            this.DepList.Location = new System.Drawing.Point(9, 60);
            this.DepList.Name = "DepList";
            this.DepList.Size = new System.Drawing.Size(195, 23);
            this.DepList.TabIndex = 1;
            this.DepList.SelectedIndexChanged += new System.EventHandler(this.DepList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manager setup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current managers by department";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(14, 307);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(96, 31);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "<<Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManagerSwap);
            this.Controls.Add(this.ManagersTable);
            this.Name = "ManagerWindow";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.ManagerWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManagersTable)).EndInit();
            this.ManagerSwap.ResumeLayout(false);
            this.ManagerSwap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ManagersTable;
        private System.Windows.Forms.GroupBox ManagerSwap;
        private System.Windows.Forms.ComboBox EmpList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DepList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AssignMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackButton;
    }
}