
namespace Gwenchaners_Voting_System_Project
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.btnVoteNow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoteNow
            // 
            this.btnVoteNow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVoteNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVoteNow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVoteNow.FlatAppearance.BorderSize = 0;
            this.btnVoteNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoteNow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoteNow.Location = new System.Drawing.Point(221, 551);
            this.btnVoteNow.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoteNow.Name = "btnVoteNow";
            this.btnVoteNow.Size = new System.Drawing.Size(205, 37);
            this.btnVoteNow.TabIndex = 1;
            this.btnVoteNow.Text = "Vote Now!";
            this.btnVoteNow.UseVisualStyleBackColor = false;
            this.btnVoteNow.Click += new System.EventHandler(this.btnVoteNow_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(647, 646);
            this.Controls.Add(this.btnVoteNow);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoteNow;
    }
}