
namespace OOP_project
{
    partial class Employee_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_form));
            this.name_label = new System.Windows.Forms.Label();
            this.gender_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.salary_label = new System.Windows.Forms.Label();
            this.edit_button = new System.Windows.Forms.Button();
            this.work_position_label = new System.Windows.Forms.Label();
            this.work_duration_label = new System.Windows.Forms.Label();
            this.month_overtime_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Calc_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(283, 12);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(81, 34);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "name";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gender_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_label.Location = new System.Drawing.Point(142, 86);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(100, 33);
            this.gender_label.TabIndex = 1;
            this.gender_label.Text = "gender";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_label.Location = new System.Drawing.Point(142, 144);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(61, 33);
            this.age_label.TabIndex = 2;
            this.age_label.Text = "age";
            // 
            // salary_label
            // 
            this.salary_label.AutoSize = true;
            this.salary_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salary_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_label.Location = new System.Drawing.Point(142, 259);
            this.salary_label.Name = "salary_label";
            this.salary_label.Size = new System.Drawing.Size(89, 33);
            this.salary_label.TabIndex = 3;
            this.salary_label.Text = "salary";
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.edit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.Location = new System.Drawing.Point(756, 393);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(155, 76);
            this.edit_button.TabIndex = 4;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // work_position_label
            // 
            this.work_position_label.AutoSize = true;
            this.work_position_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.work_position_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work_position_label.Location = new System.Drawing.Point(142, 201);
            this.work_position_label.Name = "work_position_label";
            this.work_position_label.Size = new System.Drawing.Size(175, 33);
            this.work_position_label.TabIndex = 5;
            this.work_position_label.Text = "work position";
            // 
            // work_duration_label
            // 
            this.work_duration_label.AutoSize = true;
            this.work_duration_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.work_duration_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work_duration_label.Location = new System.Drawing.Point(142, 382);
            this.work_duration_label.Name = "work_duration_label";
            this.work_duration_label.Size = new System.Drawing.Size(324, 33);
            this.work_duration_label.TabIndex = 6;
            this.work_duration_label.Text = "work duration in company";
            // 
            // month_overtime_label
            // 
            this.month_overtime_label.AutoSize = true;
            this.month_overtime_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.month_overtime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_overtime_label.Location = new System.Drawing.Point(142, 322);
            this.month_overtime_label.Name = "month_overtime_label";
            this.month_overtime_label.Size = new System.Drawing.Size(222, 33);
            this.month_overtime_label.TabIndex = 7;
            this.month_overtime_label.Text = "monthly overtime";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(560, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.back_button.Location = new System.Drawing.Point(756, 517);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(155, 76);
            this.back_button.TabIndex = 9;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Work position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Overtime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Duration";
            // 
            // Calc_button
            // 
            this.Calc_button.BackColor = System.Drawing.Color.Maroon;
            this.Calc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Calc_button.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Calc_button.Location = new System.Drawing.Point(332, 517);
            this.Calc_button.Name = "Calc_button";
            this.Calc_button.Size = new System.Drawing.Size(247, 76);
            this.Calc_button.TabIndex = 16;
            this.Calc_button.Text = "Calculate total salary";
            this.Calc_button.UseVisualStyleBackColor = false;
            this.Calc_button.Click += new System.EventHandler(this.Calc_button_Click);
            // 
            // Employee_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(923, 605);
            this.Controls.Add(this.Calc_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.month_overtime_label);
            this.Controls.Add(this.work_duration_label);
            this.Controls.Add(this.work_position_label);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.salary_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.name_label);
            this.Name = "Employee_form";
            this.Text = "Employer page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label name_label;
        public System.Windows.Forms.Label gender_label;
        public System.Windows.Forms.Label age_label;
        public System.Windows.Forms.Label salary_label;
        public System.Windows.Forms.Button edit_button;
        public System.Windows.Forms.Label work_position_label;
        public System.Windows.Forms.Label work_duration_label;
        public System.Windows.Forms.Label month_overtime_label;
        private System.Windows.Forms.Button back_button;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Calc_button;
    }
}