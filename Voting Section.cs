using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gwenchaners_Voting_System_Project
{
    public partial class Voting_Section : Form
    {
        private const int maxNumberOfCheckedItems = 1;

        public Voting_Section()
        {
            InitializeComponent();
        }



        private void labelFullIDNo_Click(object sender, EventArgs e)
        {
            LogInPage obj = new LogInPage();

        }

        private void Voting_Section_Load(object sender, EventArgs e)
        {


        }

        private void checkedListBoxP_SelectedIndexChanged(object sender, EventArgs e)
        {

            CheckedListBox box = (CheckedListBox)sender;
            if (box.CheckedItems.Count==(maxNumberOfCheckedItems))
            {
               
            }     

            if (box.CheckedItems.Count==1)
            {
                
                MessageBox.Show("Vote exceeded for President.");
            }
              
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmationPage cp = new ConfirmationPage();
            this.Hide();
            cp.Show();

            foreach (String a in checkedListBoxPres.CheckedItems)
            {
                cp.listBoxPresident.Items.Add(a);
            }

            foreach (String b in checkedListBoxVP.CheckedItems)
            {
                cp.listBoxVicePresident.Items.Add(b);
            }

            foreach (String c in checkedListBoxSenator.CheckedItems)
            {
                cp.listBoxSenator.Items.Add(c);
            }
        }

        private void checkedListBoxVP_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox box = (CheckedListBox)sender;
            if (box.CheckedItems.Count == (maxNumberOfCheckedItems))
            {

            }

            if (box.CheckedItems.Count == 1)
            {
                MessageBox.Show("Vote exceeded for Vice-President.");
            }
        }

        private void checkedListBoxSenator_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox box = (CheckedListBox)sender;
            if (box.CheckedItems.Count == (maxNumberOfCheckedItems))
            {

            }

            if (box.CheckedItems.Count == 12)
            {
                MessageBox.Show("Vote exceeded for voting Senators.");
            }
        }
    }
}
