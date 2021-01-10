using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project
{
    public partial class Employee_form : Form
    {
        public Employee_form()
        {
            InitializeComponent();
        }
        public Employee_form(string name, string sex, string age, string workposition, double salary, double monthlyovertime,
            string workdurationincomp)
        {
            InitializeComponent();
            name_label.Text = name;
            gender_label.Text = sex;
            age_label.Text = age;
            work_position_label.Text = workposition;
            salary_label.Text = Convert.ToString(salary);
            month_overtime_label.Text = Convert.ToString(monthlyovertime);
            work_duration_label.Text = workdurationincomp;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to edit the data?", "Edit permission",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("Please enter the new data! ");
                Edit_form frm3 = new Edit_form(name_label.Text, gender_label.Text, age_label.Text, work_position_label.Text, 
                    Convert.ToDouble(salary_label.Text), Convert.ToDouble(month_overtime_label.Text), work_duration_label.Text);
                this.Hide();
                frm3.ShowDialog();
                this.Close();
            }
            else if (dialog == DialogResult.No)
                this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_form frm1 = new Login_form();
            this.Hide();
            frm1.ShowDialog();
            this.Close();
        }

        private void Calc_button_Click(object sender, EventArgs e)
        {
            double working_hr = 10;
            double tax = Convert.ToDouble(salary_label.Text)* 0.05;
            double total_salary = Convert.ToDouble(salary_label.Text) + (Convert.ToDouble(month_overtime_label.Text) * working_hr) - tax;
            MessageBox.Show("The total salary after taxes discount of " + name_label.Text + " is " + total_salary);
        }
    }
}
