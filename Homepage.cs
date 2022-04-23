using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gwenchaners_Voting_System_Project
{
    public partial class Homepage : Form
    {
        
        public Homepage()
        {
            InitializeComponent();
        }

        private void btnVoteNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Voting_Section vs1 = new Voting_Section();
            vs1.Show();


        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInPage lip = new LogInPage();
            this.Hide();
            lip.Show();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
