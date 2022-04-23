using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gwenchaners_Voting_System_Project
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void linkLabelLogOut2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInPage logInPage = new LogInPage();
            this.Hide();
            logInPage.Show();

        }

        private void Results_Load(object sender, EventArgs e)
        {
           
        }
    }
}
