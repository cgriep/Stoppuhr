namespace Stoppuhr
{
    partial class SteuerungFenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkPunkte = new System.Windows.Forms.CheckBox();
            this.chkCountdown = new System.Windows.Forms.CheckBox();
            this.lblTon = new System.Windows.Forms.Label();
            this.btnTon = new System.Windows.Forms.Button();
            this.btnWeiter = new System.Windows.Forms.Button();
            this.rdoRichtungAb = new System.Windows.Forms.RadioButton();
            this.rdoRichtungAuf = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZeit = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnHeimP1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tonFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panPunkte = new System.Windows.Forms.Panel();
            this.btnGastM1 = new System.Windows.Forms.Button();
            this.btnGastP1 = new System.Windows.Forms.Button();
            this.btnHeimM1 = new System.Windows.Forms.Button();
            this.panPunkte.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkPunkte
            // 
            this.chkPunkte.AutoSize = true;
            this.chkPunkte.Location = new System.Drawing.Point(571, 98);
            this.chkPunkte.Name = "chkPunkte";
            this.chkPunkte.Size = new System.Drawing.Size(97, 17);
            this.chkPunkte.TabIndex = 29;
            this.chkPunkte.Text = "Punkteanzeige";
            this.chkPunkte.UseVisualStyleBackColor = true;
            this.chkPunkte.CheckedChanged += new System.EventHandler(this.chkPunkte_CheckedChanged);
            // 
            // chkCountdown
            // 
            this.chkCountdown.AutoSize = true;
            this.chkCountdown.Checked = true;
            this.chkCountdown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCountdown.Location = new System.Drawing.Point(571, 75);
            this.chkCountdown.Name = "chkCountdown";
            this.chkCountdown.Size = new System.Drawing.Size(80, 17);
            this.chkCountdown.TabIndex = 27;
            this.chkCountdown.Text = "Countdown";
            this.chkCountdown.UseVisualStyleBackColor = true;
            // 
            // lblTon
            // 
            this.lblTon.Location = new System.Drawing.Point(568, 18);
            this.lblTon.Name = "lblTon";
            this.lblTon.Size = new System.Drawing.Size(124, 31);
            this.lblTon.TabIndex = 28;
            this.lblTon.Text = "c:\\windows\\media\\notify.wav";
            // 
            // btnTon
            // 
            this.btnTon.Location = new System.Drawing.Point(571, 50);
            this.btnTon.Name = "btnTon";
            this.btnTon.Size = new System.Drawing.Size(126, 21);
            this.btnTon.TabIndex = 26;
            this.btnTon.Text = "&Ton einstellen";
            this.btnTon.UseVisualStyleBackColor = true;
            this.btnTon.Click += new System.EventHandler(this.btnTon_Click);
            // 
            // btnWeiter
            // 
            this.btnWeiter.Enabled = false;
            this.btnWeiter.Location = new System.Drawing.Point(453, 12);
            this.btnWeiter.Name = "btnWeiter";
            this.btnWeiter.Size = new System.Drawing.Size(101, 81);
            this.btnWeiter.TabIndex = 22;
            this.btnWeiter.Text = "&Weiter";
            this.btnWeiter.UseVisualStyleBackColor = true;
            this.btnWeiter.Click += new System.EventHandler(this.btnWeiter_Click);
            // 
            // rdoRichtungAb
            // 
            this.rdoRichtungAb.AutoSize = true;
            this.rdoRichtungAb.Checked = true;
            this.rdoRichtungAb.Location = new System.Drawing.Point(154, 52);
            this.rdoRichtungAb.Name = "rdoRichtungAb";
            this.rdoRichtungAb.Size = new System.Drawing.Size(63, 17);
            this.rdoRichtungAb.TabIndex = 19;
            this.rdoRichtungAb.TabStop = true;
            this.rdoRichtungAb.Text = "A&bwärts";
            this.rdoRichtungAb.UseVisualStyleBackColor = true;
            // 
            // rdoRichtungAuf
            // 
            this.rdoRichtungAuf.AutoSize = true;
            this.rdoRichtungAuf.Location = new System.Drawing.Point(154, 29);
            this.rdoRichtungAuf.Name = "rdoRichtungAuf";
            this.rdoRichtungAuf.Size = new System.Drawing.Size(66, 17);
            this.rdoRichtungAuf.TabIndex = 17;
            this.rdoRichtungAuf.Text = "A&ufwärts";
            this.rdoRichtungAuf.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Richtung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "&Zeit";
            // 
            // txtZeit
            // 
            this.txtZeit.Location = new System.Drawing.Point(89, 29);
            this.txtZeit.MaxLength = 5;
            this.txtZeit.Name = "txtZeit";
            this.txtZeit.Size = new System.Drawing.Size(51, 20);
            this.txtZeit.TabIndex = 15;
            this.txtZeit.Text = "5:00";
            // 
            // btnStop
            // 
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(340, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(107, 81);
            this.btnStop.TabIndex = 20;
            this.btnStop.Text = "Sto&p";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(233, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 81);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(7, 52);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(75, 23);
            this.btnFive.TabIndex = 24;
            this.btnFive.Text = "&5 min";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(6, 71);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 23);
            this.btnTen.TabIndex = 25;
            this.btnTen.Text = "1&0 min";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(7, 13);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(75, 23);
            this.btnOne.TabIndex = 21;
            this.btnOne.Text = "&1 min";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(7, 32);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(75, 23);
            this.btnTwo.TabIndex = 23;
            this.btnTwo.Text = "&2 min";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btnHeimP1
            // 
            this.btnHeimP1.Location = new System.Drawing.Point(12, 7);
            this.btnHeimP1.Name = "btnHeimP1";
            this.btnHeimP1.Size = new System.Drawing.Size(101, 81);
            this.btnHeimP1.TabIndex = 0;
            this.btnHeimP1.Text = "&Heim +1";
            this.toolTip1.SetToolTip(this.btnHeimP1, "Heimpunktzahl um eins erhöhen");
            this.btnHeimP1.UseVisualStyleBackColor = true;
            this.btnHeimP1.Click += new System.EventHandler(this.btnHeimP1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(591, 7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 81);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "P&unkte auf 0";
            this.toolTip1.SetToolTip(this.btnReset, "Punkte beider Mannschaften auf 0 setzen");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tonFileDialog
            // 
            this.tonFileDialog.DefaultExt = "wav";
            this.tonFileDialog.FileName = "fileDialog";
            this.tonFileDialog.InitialDirectory = "c:\\windows\\media";
            this.tonFileDialog.Title = "Ton für Ende auswählen";
            // 
            // panPunkte
            // 
            this.panPunkte.Controls.Add(this.btnReset);
            this.panPunkte.Controls.Add(this.btnGastM1);
            this.panPunkte.Controls.Add(this.btnGastP1);
            this.panPunkte.Controls.Add(this.btnHeimM1);
            this.panPunkte.Controls.Add(this.btnHeimP1);
            this.panPunkte.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panPunkte.Location = new System.Drawing.Point(0, 121);
            this.panPunkte.Name = "panPunkte";
            this.panPunkte.Size = new System.Drawing.Size(702, 100);
            this.panPunkte.TabIndex = 30;
            this.panPunkte.Visible = false;
            // 
            // btnGastM1
            // 
            this.btnGastM1.Location = new System.Drawing.Point(392, 7);
            this.btnGastM1.Name = "btnGastM1";
            this.btnGastM1.Size = new System.Drawing.Size(101, 81);
            this.btnGastM1.TabIndex = 7;
            this.btnGastM1.Text = "Gast -1";
            this.btnGastM1.UseVisualStyleBackColor = true;
            this.btnGastM1.Click += new System.EventHandler(this.btnGastM1_Click);
            // 
            // btnGastP1
            // 
            this.btnGastP1.Location = new System.Drawing.Point(285, 7);
            this.btnGastP1.Name = "btnGastP1";
            this.btnGastP1.Size = new System.Drawing.Size(101, 81);
            this.btnGastP1.TabIndex = 6;
            this.btnGastP1.Text = "&Gast +1";
            this.btnGastP1.UseVisualStyleBackColor = true;
            this.btnGastP1.Click += new System.EventHandler(this.btnGastP1_Click);
            // 
            // btnHeimM1
            // 
            this.btnHeimM1.Location = new System.Drawing.Point(119, 7);
            this.btnHeimM1.Name = "btnHeimM1";
            this.btnHeimM1.Size = new System.Drawing.Size(101, 81);
            this.btnHeimM1.TabIndex = 5;
            this.btnHeimM1.Text = "Heim -1";
            this.btnHeimM1.UseVisualStyleBackColor = true;
            this.btnHeimM1.Click += new System.EventHandler(this.btnHeimM1_Click);
            // 
            // SteuerungFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 221);
            this.Controls.Add(this.panPunkte);
            this.Controls.Add(this.chkPunkte);
            this.Controls.Add(this.chkCountdown);
            this.Controls.Add(this.lblTon);
            this.Controls.Add(this.btnTon);
            this.Controls.Add(this.btnWeiter);
            this.Controls.Add(this.rdoRichtungAb);
            this.Controls.Add(this.rdoRichtungAuf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZeit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnTwo);
            this.Name = "SteuerungFenster";
            this.Text = "Steuerungsfenster - www.cvjm-feriendorf.de";
            this.Load += new System.EventHandler(this.SteuerungFenster_Load);
            this.panPunkte.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPunkte;
        public System.Windows.Forms.CheckBox chkCountdown;
        private System.Windows.Forms.Label lblTon;
        private System.Windows.Forms.Button btnTon;
        private System.Windows.Forms.Button btnWeiter;
        public System.Windows.Forms.RadioButton rdoRichtungAb;
        private System.Windows.Forms.RadioButton rdoRichtungAuf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZeit;
        public System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog tonFileDialog;
        private System.Windows.Forms.Panel panPunkte;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGastM1;
        private System.Windows.Forms.Button btnGastP1;
        private System.Windows.Forms.Button btnHeimM1;
        private System.Windows.Forms.Button btnHeimP1;

    }
}