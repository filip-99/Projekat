using Shared.Interfaces.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_schedule
{
    public partial class Login2 : Form
    {
        private readonly ISchedulingBusiness schedulingBusiness;
        private readonly IPeriodBusiness periodBusiness;
        private readonly IClassroomBusiness classroomBusiness;
        public Login2(ISchedulingBusiness schedulingBusiness, IPeriodBusiness periodBusiness, IClassroomBusiness classroomBusiness)
        {
            InitializeComponent();
            this.schedulingBusiness = schedulingBusiness;
            this.periodBusiness = periodBusiness;
            this.classroomBusiness = classroomBusiness;
        }

        public Login2()
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBoxPassword.Text = "password";

        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.Text == "password")
            {
                textBoxPassword.Text = "";
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Trim() == "")
            {
                textBoxPassword.Text = "password";
            }
        }

        private void textBoxPassword_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.Text == "password")
            {
                textBoxPassword.Text = "";
            }
        }

        private void textBoxPassword_Leave_1(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Trim() == "")
            {
                textBoxPassword.Text = "password";
            }
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != "")
            {
                if (textBoxPassword.Text == "admin")
                {
                    MessageBox.Show("You have successfully logged in!");
                    this.Hide();
                    NovaForma fm = new NovaForma(schedulingBusiness, periodBusiness, classroomBusiness);
                    fm.ShowDialog();
                    return;
                }

                else
                    MessageBox.Show("Wrong password! ");
                textBoxPassword.Clear();
            }
            else
            {
                MessageBox.Show("You need to enter password!");
            }
        }
    }
}
