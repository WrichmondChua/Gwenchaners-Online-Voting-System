using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gwenchaners_Voting_System_Project
{
    public partial class LogInPage : Form
    {
        static int attempt1 = 1;
        static int attempt2 = 1;
        static int attempt3 = 1;
        static int attempt4 = 1;
        static int attempt5 = 1;


        public LogInPage()
        {

            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Voting_Section obj2 = new Voting_Section();
           
            if (txtboxIDNo.Text == "1000123456" && txtboxPassword.Text == "carabao")
            {

                if ((attempt1 == 1) && (attempt1 > 0))
                {
                    this.Hide();
                    Homepage homepage = new Homepage();
                    homepage.Show();
                    --attempt1;

                }
                else
                {
                    MessageBox.Show("You Have Already Voted");
                }
                            

            }
            else if (txtboxIDNo.Text == "2000123456" && txtboxPassword.Text == "anaconda")
            {
                if ((attempt2 == 1) && (attempt2 > 0))
                {
                    this.Hide();
                    Homepage homepage = new Homepage();
                    homepage.Show();
                    --attempt2;

                }
                else
                {
                    MessageBox.Show("You Have Already Voted");
                }
            }
            else if (txtboxIDNo.Text == "3000123456" && txtboxPassword.Text == "crocodile")
            {
                if ((attempt3 == 1) && (attempt3 > 0))
                {
                    this.Hide();
                    Homepage homepage = new Homepage();
                    homepage.Show();
                    --attempt3;

                }
                else
                {
                    MessageBox.Show("You Have Already Voted");
                }
            }
            else if (txtboxIDNo.Text == "4000123456" && txtboxPassword.Text == "penguin")
            {
                if ((attempt4 == 1) && (attempt4 > 0))
                {
                    this.Hide();
                    Homepage homepage = new Homepage();
                    homepage.Show();
                    --attempt4;

                }
                else
                {
                    MessageBox.Show("You Have Already Voted");
                }
            }
            else if (txtboxIDNo.Text == "5000123456" && txtboxPassword.Text == "hamster")
            {
                if ((attempt5 == 1) && (attempt5 > 0))
                {
                    this.Hide();
                    Homepage homepage = new Homepage();
                    homepage.Show();
                    --attempt5;

                }
                else
                {
                    MessageBox.Show("You Have Already Voted");
                }
            }
            else
            {
                MessageBox.Show("Either your ID Number or your Password is Incorrect. Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtboxIDNo_TextChanged(object sender, EventArgs e)
        {
            if (txtboxIDNo.Text.Equals("IDNo"))
            {
                txtboxIDNo.Text = "";
            }

        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {

            if (txtboxPassword.Text.Equals("Password"))
            {
                txtboxPassword.Text = "";
            }

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked == true)
            {
                txtboxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtboxPassword.UseSystemPasswordChar = true;
            }
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {

        }
    }
}
