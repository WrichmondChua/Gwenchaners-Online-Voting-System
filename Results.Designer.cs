
namespace Gwenchaners_Voting_System_Project
{
    partial class Results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelLogOut2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxVicePresident = new System.Windows.Forms.ListBox();
            this.listBoxPresident = new System.Windows.Forms.ListBox();
            this.listBoxSenator = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.linkLabelLogOut2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.listBoxVicePresident);
            this.panel1.Controls.Add(this.listBoxPresident);
            this.panel1.Controls.Add(this.listBoxSenator);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(119, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 338);
            this.panel1.TabIndex = 25;
            // 
            // linkLabelLogOut2
            // 
            this.linkLabelLogOut2.AutoSize = true;
            this.linkLabelLogOut2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabelLogOut2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelLogOut2.Location = new System.Drawing.Point(185, 308);
            this.linkLabelLogOut2.Name = "linkLabelLogOut2";
            this.linkLabelLogOut2.Size = new System.Drawing.Size(62, 20);
            this.linkLabelLogOut2.TabIndex = 26;
            this.linkLabelLogOut2.TabStop = true;
            this.linkLabelLogOut2.Text = "Log Out";
            this.linkLabelLogOut2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogOut2_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(172, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "RESULTS";
            // 
            // listBoxVicePresident
            // 
            this.listBoxVicePresident.FormattingEnabled = true;
            this.listBoxVicePresident.ItemHeight = 15;
            this.listBoxVicePresident.Location = new System.Drawing.Point(136, 75);
            this.listBoxVicePresident.Name = "listBoxVicePresident";
            this.listBoxVicePresident.Size = new System.Drawing.Size(210, 19);
            this.listBoxVicePresident.TabIndex = 27;
            // 
            // listBoxPresident
            // 
            this.listBoxPresident.FormattingEnabled = true;
            this.listBoxPresident.ItemHeight = 15;
            this.listBoxPresident.Location = new System.Drawing.Point(94, 44);
            this.listBoxPresident.Name = "listBoxPresident";
            this.listBoxPresident.Size = new System.Drawing.Size(252, 19);
            this.listBoxPresident.TabIndex = 26;
            // 
            // listBoxSenator
            // 
            this.listBoxSenator.FormattingEnabled = true;
            this.listBoxSenator.ItemHeight = 15;
            this.listBoxSenator.Location = new System.Drawing.Point(15, 142);
            this.listBoxSenator.Name = "listBoxSenator";
            this.listBoxSenator.Size = new System.Drawing.Size(390, 154);
            this.listBoxSenator.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Senator:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vice - President:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "President:";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 503);
            this.Controls.Add(this.panel1);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listBoxVicePresident;
        public System.Windows.Forms.ListBox listBoxPresident;
        public System.Windows.Forms.ListBox listBoxSenator;
        private System.Windows.Forms.LinkLabel linkLabelLogOut2;
        private System.Windows.Forms.Label label4;
    }
}