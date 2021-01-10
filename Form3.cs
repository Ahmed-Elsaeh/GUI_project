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
    public partial class Edit_form : Form
    {
        string new_name;
        string new_sex;
        string new_age;
        string new_workposition;
        double new_salary;
        double new_monthlyovertime;
        string new_workdurationincomp;
        public Edit_form()
        {
            InitializeComponent();
        }
        public Edit_form(string name, string sex, string age, string workposition, double salary, double monthlyovertime,
            string workdurationincomp)
        {
            InitializeComponent();
            new_name = name;
            new_sex = sex;
            new_age = age;
            new_workposition = workposition;
            new_salary = Convert.ToDouble(salary);
            new_monthlyovertime = Convert.ToDouble(monthlyovertime);
            new_workdurationincomp = workdurationincomp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;

            foreach (var control in this.Controls.OfType<TextBox>())
            {
                var textBox = control as TextBox;
                if (textBox.Text != "")
                {
                    c++;
                }
            }

            if ( c == 0)
            {
                MessageBox.Show("You didn't insert any data to edit!");
                this.Refresh();
            }

            if ((name_edit.Text == "" || sex_edit.Text == "") && c != 0)
            {
                if(age_edit.Text != "")
                    new_age = age_edit.Text;
                if (work_pos_edit.Text != "")
                    new_workposition = work_pos_edit.Text;
                if (salary_edit.Text != "")
                    new_salary = Convert.ToDouble(salary_edit.Text);
                if (month_overtime_edit.Text != "")
                    new_monthlyovertime = Convert.ToDouble(month_overtime_edit.Text);
                if (work_dur_edit.Text != "")
                    new_workdurationincomp = work_dur_edit.Text;
                Employee_form frm2 = new Employee_form(new_name, new_sex, new_age, new_workposition, new_salary, 
                new_monthlyovertime, new_workdurationincomp);
                this.Hide();
                frm2.ShowDialog();
                this.Close();
            }
            else if(name_edit.Text != "" || sex_edit.Text != "")
            {
                new_name = name_edit.Text;
                new_sex = sex_edit.Text;
                new_age = age_edit.Text;
                new_workposition = work_pos_edit.Text;
                new_salary = Convert.ToDouble(salary_edit.Text);
                new_monthlyovertime = Convert.ToDouble(month_overtime_edit.Text);
                new_workdurationincomp = work_dur_edit.Text;
                Employee_form frm2 = new Employee_form(new_name, new_sex, new_age, new_workposition, Convert.ToDouble(new_salary),
                Convert.ToDouble(new_monthlyovertime), new_workdurationincomp);
                this.Hide();
                frm2.ShowDialog();
                this.Close();
            }
        }
    }
}
