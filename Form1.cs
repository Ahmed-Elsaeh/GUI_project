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
    public partial class Login_form : Form
    {
        Employer emp1;
        Employer emp2;
        Employer emp3;
        Employer emp4;
        Employer emp5;

        /*public Login_form(string name, string sex, string age, string workposition, double salary, double monthlyovertime,
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
        }*/
        public Login_form()
        {
            InitializeComponent();
            emp1 = new Employer
            {
                name = "Ahmed",
                sex = "male",
                age = "21",
                workposition = "manager",
                salary = 11000,
                monthlyovertime = 16,
                workdurationincomp = "8"
            };

            emp2 = new Employer
            {
                name = "Mahmoud",
                sex = "male",
                age = "21",
                workposition = "accountant",
                salary = 6000,
                monthlyovertime = 10,
                workdurationincomp = "8"
            };

            emp3 = new Employer
            {
                name = "Salma",
                sex = "female",
                age = "20",
                workposition = "secrtary",
                salary = 5600,
                monthlyovertime = 13,
                workdurationincomp = "8"
            };

            emp4 = new Employer
            {
                name = "Nour",
                sex = "female",
                age = "25",
                workposition = "assistant manager",
                salary = 4800,
                monthlyovertime = 9,
                workdurationincomp = "8"
            };

            emp5 = new Employer
            {
                name = "Yasser",
                sex = "male",
                age = "24",
                workposition = "supervisor",
                salary = 9000,
                monthlyovertime = 19,
                workdurationincomp = "8"
            };
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            if ((user_text.Text == emp1.name || user_text.Text == emp2.name || user_text.Text == emp3.name || user_text.Text == emp4.name 
            || user_text.Text == emp5.name) && Password.Text == "123")
            {
                if(user_text.Text == emp1.name)
                {
                    Employee_form frm2 = new Employee_form(emp1.name, emp1.sex, emp1.age, emp1.workposition, emp1.salary, emp1.monthlyovertime,
                    emp1.workdurationincomp);
                    this.Hide();
                    frm2.ShowDialog();
                    this.Close();
                }
                if (user_text.Text == emp2.name)
                {
                    Employee_form frm2 = new Employee_form(emp2.name, emp2.sex, emp2.age, emp2.workposition, emp2.salary, emp2.monthlyovertime,
                    emp2.workdurationincomp);
                    this.Hide();
                    frm2.ShowDialog();
                    this.Close();
                }
                if (user_text.Text == emp3.name)
                {
                    Employee_form frm2 = new Employee_form(emp3.name, emp3.sex, emp3.age, emp3.workposition, emp3.salary, emp3.monthlyovertime,
                    emp3.workdurationincomp);
                    this.Hide();
                    frm2.ShowDialog();
                    this.Close();
                }
                if (user_text.Text == emp4.name)
                {
                    Employee_form frm2 = new Employee_form(emp4.name, emp4.sex, emp4.age, emp4.workposition, emp4.salary, emp4.monthlyovertime,
                    emp4.workdurationincomp);
                    this.Hide();
                    frm2.ShowDialog();
                    this.Close();
                }
                if (user_text.Text == emp5.name)
                {
                    Employee_form frm2 = new Employee_form(emp5.name, emp5.sex, emp5.age, emp5.workposition, emp5.salary, emp5.monthlyovertime,
                    emp5.workdurationincomp);
                    this.Hide();
                    frm2.ShowDialog();
                    this.Close();
                }
            }
            else {
                MessageBox.Show("Invalid credentials, please enter the right username or password", "Login error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Button1_Click(this, new EventArgs());
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Button1_Click(this, new EventArgs());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            
        }
    }
    class Employer
    {
        public string name;
        public string sex;
        public string age;
        public string workposition;
        public double salary;
        public double monthlyovertime;
        public string workdurationincomp;
    }
}
