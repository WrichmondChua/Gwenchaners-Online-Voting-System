using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Gwenchaners_Voting_System_Project
{
    public partial class ConfirmationPage : Form
    {
        public static string SetFileName = "";
        public ConfirmationPage()
        {
            InitializeComponent();
        }

        private void linkLabelBack2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Voting_Section vs = new Voting_Section();
            this.Hide();
            vs.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmationPage_Load(object sender, EventArgs e)
        {

        }

        private void buttonCastVote_Click(object sender, EventArgs e)
        {
            Results rp = new Results();
            this.Hide();
            rp.Show();

            foreach (String p in listBoxPresident.Items)
            {
                rp.listBoxPresident.Items.Add(p);
            }

            foreach (String vp in listBoxVicePresident.Items)
            {
                rp.listBoxVicePresident.Items.Add(vp);
            }

            foreach (String sen in listBoxSenator.Items)
            {
                rp.listBoxSenator.Items.Add(sen);
            }

        }
    }
}
