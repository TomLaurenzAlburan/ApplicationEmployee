﻿namespace ApplicationEmployee
{
    partial class frmComputeSalary
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnComputeSalary = new System.Windows.Forms.Button();
            this.TxtHoursWorked = new System.Windows.Forms.TextBox();
            this.TxtRatePerHour = new System.Windows.Forms.TextBox();
            this.TxtJobTitle = new System.Windows.Forms.TextBox();
            this.TxtDepartment = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(187, 334);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 22);
            this.lblResult.TabIndex = 27;
            // 
            // btnComputeSalary
            // 
            this.btnComputeSalary.BackColor = System.Drawing.Color.Cyan;
            this.btnComputeSalary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComputeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputeSalary.Location = new System.Drawing.Point(163, 186);
            this.btnComputeSalary.Name = "btnComputeSalary";
            this.btnComputeSalary.Size = new System.Drawing.Size(141, 35);
            this.btnComputeSalary.TabIndex = 26;
            this.btnComputeSalary.Text = "Compute Salary";
            this.btnComputeSalary.UseVisualStyleBackColor = false;
            this.btnComputeSalary.Click += new System.EventHandler(this.btnComputeSalary_Click);
            // 
            // TxtHoursWorked
            // 
            this.TxtHoursWorked.Location = new System.Drawing.Point(261, 143);
            this.TxtHoursWorked.Name = "TxtHoursWorked";
            this.TxtHoursWorked.Size = new System.Drawing.Size(208, 20);
            this.TxtHoursWorked.TabIndex = 25;
            // 
            // TxtRatePerHour
            // 
            this.TxtRatePerHour.Location = new System.Drawing.Point(16, 143);
            this.TxtRatePerHour.Name = "TxtRatePerHour";
            this.TxtRatePerHour.Size = new System.Drawing.Size(208, 20);
            this.TxtRatePerHour.TabIndex = 24;
            // 
            // TxtJobTitle
            // 
            this.TxtJobTitle.Location = new System.Drawing.Point(261, 90);
            this.TxtJobTitle.Name = "TxtJobTitle";
            this.TxtJobTitle.Size = new System.Drawing.Size(208, 20);
            this.TxtJobTitle.TabIndex = 23;
            // 
            // TxtDepartment
            // 
            this.TxtDepartment.Location = new System.Drawing.Point(16, 90);
            this.TxtDepartment.Name = "TxtDepartment";
            this.TxtDepartment.Size = new System.Drawing.Size(208, 20);
            this.TxtDepartment.TabIndex = 22;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(261, 44);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(208, 20);
            this.TxtLastName.TabIndex = 21;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(16, 44);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(208, 20);
            this.TxtFirstName.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Job Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Total Hourse worked";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rate Per Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "First Name";
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(489, 307);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnComputeSalary);
            this.Controls.Add(this.TxtHoursWorked);
            this.Controls.Add(this.TxtRatePerHour);
            this.Controls.Add(this.TxtJobTitle);
            this.Controls.Add(this.TxtDepartment);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmComputeSalary";
            this.Text = "Employee Salary Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnComputeSalary;
        private System.Windows.Forms.TextBox TxtHoursWorked;
        private System.Windows.Forms.TextBox TxtRatePerHour;
        private System.Windows.Forms.TextBox TxtJobTitle;
        private System.Windows.Forms.TextBox TxtDepartment;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

