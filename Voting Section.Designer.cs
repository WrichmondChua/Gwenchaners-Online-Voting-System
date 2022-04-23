
namespace Gwenchaners_Voting_System_Project
{
    partial class Voting_Section
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voting_Section));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelvp = new System.Windows.Forms.Label();
            this.lblIDNo = new System.Windows.Forms.Label();
            this.labelvw = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.checkedListBoxPres = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxVP = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBoxSenator = new System.Windows.Forms.CheckedListBox();
            this.labelsenator = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, -13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID No.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, -13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name:";
            // 
            // labelvp
            // 
            this.labelvp.AutoSize = true;
            this.labelvp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelvp.Location = new System.Drawing.Point(47, 128);
            this.labelvp.Name = "labelvp";
            this.labelvp.Size = new System.Drawing.Size(118, 25);
            this.labelvp.TabIndex = 6;
            this.labelvp.Text = "PRESIDENT:";
            // 
            // lblIDNo
            // 
            this.lblIDNo.AutoSize = true;
            this.lblIDNo.Location = new System.Drawing.Point(394, -12);
            this.lblIDNo.Name = "lblIDNo";
            this.lblIDNo.Size = new System.Drawing.Size(38, 15);
            this.lblIDNo.TabIndex = 18;
            this.lblIDNo.Text = "label4";
            // 
            // labelvw
            // 
            this.labelvw.AutoSize = true;
            this.labelvw.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelvw.Location = new System.Drawing.Point(21, 532);
            this.labelvw.Name = "labelvw";
            this.labelvw.Size = new System.Drawing.Size(94, 17);
            this.labelvw.TabIndex = 5;
            this.labelvw.Text = "VOTE WISELY!";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(47, -12);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 15);
            this.lblname.TabIndex = 17;
            this.lblname.Text = "label3";
            // 
            // checkedListBoxPres
            // 
            this.checkedListBoxPres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBoxPres.FormattingEnabled = true;
            this.checkedListBoxPres.Items.AddRange(new object[] {
            "ABELLA, ERNIE (IND) ",
            "ANDES, HILARIO (IND) ",
            "DE GUZMAN, LEODY (PLM) ",
            "DOMAGOSO, ISKO MORENO (AKSYON) ",
            "GONZALES, NORBERTO (PDSP) ",
            "LACSON, PING (PDR) ",
            "LIHAYLIHAY, DANILO (IND)",
            "MANGONDATO, FAISAL (KTPNAN)",
            "MARCOS, BONGBONG (PFP)",
            "MARCOS, MARIA AURORA (IND)",
            "MONTEMAYOR, JOSE JR. (DPP)",
            "NIEZ, EDGAR (IND)",
            "PACQUIAO, MANNY PACMAN (PROMDI)",
            "ROBREDO, LENI (IND)"});
            this.checkedListBoxPres.Location = new System.Drawing.Point(47, 156);
            this.checkedListBoxPres.Name = "checkedListBoxPres";
            this.checkedListBoxPres.Size = new System.Drawing.Size(264, 144);
            this.checkedListBoxPres.TabIndex = 143;
            this.checkedListBoxPres.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxP_SelectedIndexChanged);
            // 
            // checkedListBoxVP
            // 
            this.checkedListBoxVP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBoxVP.FormattingEnabled = true;
            this.checkedListBoxVP.Items.AddRange(new object[] {
            "ATIENZA, LITO (PROMD)",
            "BELLO, WALDEN (PLM)",
            "DAVID, RIZALITO (DPP)",
            "DUTERTE, SARA (LAKAS)",
            "LOPEZ, MANNY SD (WPP)",
            "ONG, DOC WILLIE (AKSYON)",
            "PANGILINAN, KIKO (LP)",
            "SERAPIO, CARLOS (KTPNAN)",
            "SOTTO, VICENTE TITO (NPC)"});
            this.checkedListBoxVP.Location = new System.Drawing.Point(394, 156);
            this.checkedListBoxVP.Name = "checkedListBoxVP";
            this.checkedListBoxVP.Size = new System.Drawing.Size(264, 144);
            this.checkedListBoxVP.TabIndex = 145;
            this.checkedListBoxVP.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxVP_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(394, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 144;
            this.label3.Text = "VICE PRESIDENT:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkedListBoxSenator
            // 
            this.checkedListBoxSenator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBoxSenator.FormattingEnabled = true;
            this.checkedListBoxSenator.Items.AddRange(new object[] {
            "AFUANG, ABNER (IND)",
            "ALBANI, IBRAHIM (WPP)",
            "APOLINARIO, PASTOR (IND)",
            "ARCILLA, OSCAR JR. (IND)",
            "ARRANZA, MANG JESS (IND)",
            "BAGUILAT, TEDDY (LP)",
            "BAILEN, AGNES (IND)",
            "BALITA, CARL (AKSYON)",
            "BARBO, LUTZ (PDPLBN)",
            "BAUTISTA, HERBERT BISTEK (NPC)",
            "BELGICA, GRECO (PDDS)",
            "BELLO, SILVESTRE JR. (PDPLBN) ",
            "BIAZON, DEVIENDO SR. (IND)",
            "BINAY, JOJO (UNA)",
            "CABONEGRO, ROY (PLM)",
            "CASTRICIONES, BRO JOHN (PDPLBN)",
            "CAYETANO, ALAN PETER (IND)",
            "CHAVEZ, MELCHOR (WPP)",
            "COLMENARES, NERI (MKBYN)",
            "D\'ANGELO, DAVID (PLM)",
            "DE LIMA, LEILA (LP)",
            "DEL ROSARIO, MONSOUR (PDR)",
            "DIAZ, DING (PPP)",
            "DIOKNO, CHEL (KANP)",
            "EJERCITO, JV ESTRADA (NPC)",
            "ELEAZAR, GEN. GUILLERMO (PDR)",
            "EREÑO, BRO. ERNIE (PM)",
            "ESCUDERO, CHIZ (NPC)",
            "ESPIRITU, LUKE (PLM)",
            "ESTRADA, JINGGOY (PMP)",
            "FALCONE, BAL FALCON (DPP)",
            "GADON, LARRY (KBL)",
            "GATCHALIAN, WIN (NPC)",
            "GORDON, WOW DICK (BVNP)",
            "GUTOC, SAMIRA (AKSYON)",
            "HONASAN, GRINGO (IND)",
            "HONTIVEROS, RISA (AKBAYAN)",
            "JARDIN, SAMUEL ALOYSIUS (IND)",
            "JAVELLANA, RJ (IND)",
            "KIRAM, NUR-MAHAL (IND)",
            "LABOG, ELMER (MKBYN)",
            "LACAP, MARK ANTHONY (IND)",
            "LACSON, KUYA ALEX (KP)",
            "LANGIT, REY (PDPLBN)",
            "LEGARDA, LOREN (NPC)",
            "LIM, ARIEL (IND)",
            "MALLILLIN, EMILY (PPM)",
            "MARCOLETA, RODANTE (PDPLBN)",
            "MARCOS, FRANCIS LEO (IND)",
            "MARQUEZ, NORMAN (IND)",
            "MATULA, SONNY (IND)",
            "MINDALANO-ADAM,MARIETA (KTPNAN)",
            "OLARTE, ATTY/DR. LEO (BIGKIS)",
            "PADILLA, DRA. MINGUITA (PDR)",
            "PADILLA, ROBIN (PDPLBN)",
            "PANELO, SAL PANALO (PDPLBN) ",
            "PIMENTEL, ASTRA (PDPLBN)",
            "PIÑOL, MANNY (NPC)",
            "RICABLANCA, WILLIE JR. (PM)",
            "ROQUE, HARRY SPOX (PRP)",
            "SAHIDULLA, LADY ANNE (PDDS)",
            "SISON, JOPET (AKSYON)",
            "TEODORO, GIBO (PRP)",
            "TRILLANES, ANTONIO IV (LP) ",
            "TULFO, IDOL RAFFY (IND)",
            "VALEROS, REY (IND)",
            "VILLANUEVA,JOEL TESDAMAN (IND)",
            "VILLAR, MARK (NP)",
            "ZUBIAGA, CARMEN (IND)",
            "ZUBIRI, MIGZ (IND)"});
            this.checkedListBoxSenator.Location = new System.Drawing.Point(225, 362);
            this.checkedListBoxSenator.Name = "checkedListBoxSenator";
            this.checkedListBoxSenator.Size = new System.Drawing.Size(264, 144);
            this.checkedListBoxSenator.TabIndex = 147;
            this.checkedListBoxSenator.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxSenator_SelectedIndexChanged);
            // 
            // labelsenator
            // 
            this.labelsenator.AutoSize = true;
            this.labelsenator.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelsenator.Location = new System.Drawing.Point(225, 334);
            this.labelsenator.Name = "labelsenator";
            this.labelsenator.Size = new System.Drawing.Size(101, 25);
            this.labelsenator.TabIndex = 146;
            this.labelsenator.Text = "SENATOR:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 148;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Voting_Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(777, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBoxSenator);
            this.Controls.Add(this.labelsenator);
            this.Controls.Add(this.checkedListBoxVP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBoxPres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIDNo);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.labelvw);
            this.Controls.Add(this.labelvp);
            this.Name = "Voting_Section";
            this.Text = "Voting_Section";
            this.Load += new System.EventHandler(this.Voting_Section_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelvp;
        private System.Windows.Forms.Label lblIDNo;
        private System.Windows.Forms.Label labelvw;
        private System.Windows.Forms.Label lblname;
        public System.Windows.Forms.CheckedListBox checkedListBoxPres;
        public System.Windows.Forms.CheckedListBox checkedListBoxVP;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckedListBox checkedListBoxSenator;
        private System.Windows.Forms.Label labelsenator;
        private System.Windows.Forms.Button button1;
    }
}