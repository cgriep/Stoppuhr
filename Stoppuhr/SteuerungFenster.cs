using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stoppuhr
{
    public partial class SteuerungFenster : Form
    {
        private AnzeigeFenster anzeigeFenster = null;
        public SteuerungFenster()
        {
            InitializeComponent();
        }
        public SteuerungFenster(AnzeigeFenster anzeige)
        {
            InitializeComponent();
            anzeigeFenster = anzeige;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtZeit.Text = "1:00";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtZeit.Text = "2:00";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtZeit.Text = "5:00";
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            txtZeit.Text = "10:00";
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            string[] a = txtZeit.Text.Split(new Char[] { ':' });
            anzeigeFenster.timer1.Interval = 1000;
            btnWeiter.Enabled = false;
            anzeigeFenster.subZeit = new TimeSpan(0, 0, 1);
            try
            {
                TimeSpan ts;
                if (rdoRichtungAb.Checked)
                {
                    anzeigeFenster.zeit = new TimeSpan(0, Convert.ToInt16(a[0]), Convert.ToInt16(a[1]));
                    anzeigeFenster.zeroZeit = new TimeSpan(0, 0, 0);
                    anzeigeFenster.countdownzeit = new TimeSpan(0, 0, 10);
                }
                else
                {
                    anzeigeFenster.zeit = new TimeSpan(0, 0, 0);
                    anzeigeFenster.zeroZeit = new TimeSpan(0, Convert.ToInt16(a[0]), Convert.ToInt16(a[1]));
                    ts = anzeigeFenster.zeroZeit;
                    anzeigeFenster.countdownzeit = ts.Subtract(new TimeSpan(0, 0, 10));
                }
                ts = anzeigeFenster.zeit;
                anzeigeFenster.lblZeit.Text = ts.ToString().Substring(3);
                ts = anzeigeFenster.zeroZeit; 
                this.Text = "Zähle bis " + ts.ToString().Substring(3);
                btnStop.Enabled = true;
                anzeigeFenster.lblZeit.BackColor = Color.Black;
                anzeigeFenster.simpleSound = new System.Media.SoundPlayer(@lblTon.Text);
                anzeigeFenster.timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ungültige Zeitangabe: " + a[0] + "/" + a[1] + "! ("+ex.Message+")", "Stoppuhr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            anzeigeFenster.timer1.Stop();
            btnWeiter.Enabled = true;
            btnStop.Enabled = false;
        }
        private void btnWeiter_Click(object sender, EventArgs e)
        {
            btnWeiter.Enabled = false;
            btnStop.Enabled = true;
            anzeigeFenster.timer1.Start();
        }

        private void btnTon_Click(object sender, EventArgs e)
        {
            tonFileDialog.FileName = lblTon.Text;
            if (tonFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblTon.Text = tonFileDialog.FileName;
                anzeigeFenster.simpleSound = new System.Media.SoundPlayer(@lblTon.Text);
                anzeigeFenster.simpleSound.Play();
            }

        }

        private void SteuerungFenster_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnStart, "Startet die Uhr mit der angebenen Zeit");
            toolTip1.SetToolTip(btnStop, "Hält die Uhr an");
            toolTip1.SetToolTip(btnWeiter, "Lässt die Uhr weiterlaufen");
            toolTip1.SetToolTip(btnTon, "Zum Auswählen eines Ton, der am Ende der Zeit abgespielt wird");
            toolTip1.SetToolTip(btnOne, "Setzt die Uhr auf eine Minute");
            toolTip1.SetToolTip(btnTwo, "Setzt die Uhr auf zwei Minuten");
            toolTip1.SetToolTip(btnFive, "Setzt die Uhr auf fünf Minuten");
            toolTip1.SetToolTip(btnTen, "Setzt die Uhr auf 10 Minuten");
            toolTip1.SetToolTip(lblTon, "Die aktuell gewählt Tondatei");
            toolTip1.SetToolTip(txtZeit, "Geben Sie die Zeit in der Form Minuten:Sekunden an. Nach dem Start wird die Zeit in die Uhr übernommen.");
            anzeigeFenster.Show();
        }

        private void chkPunkte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPunkte.Checked)
            {
                anzeigeFenster.tblPanel.Visible = true;
                panPunkte.Visible = true;
            }
            else
            {
                anzeigeFenster.tblPanel.Visible = false;
                panPunkte.Visible = false;
            }
            anzeigeFenster.Width = anzeigeFenster.Width + 1;
        }

        private void btnGastP1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(anzeigeFenster.lblPunkte2.Text);
            anzeigeFenster.lblPunkte2.Text = Convert.ToString(i + 1);
        }

        private void btnHeimP1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(anzeigeFenster.lblPunkte1.Text);
            anzeigeFenster.lblPunkte1.Text = Convert.ToString(i + 1);
        }

        private void btnHeimM1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(anzeigeFenster.lblPunkte1.Text);
            anzeigeFenster.lblPunkte1.Text = Convert.ToString(i - 1);
        }

        private void btnGastM1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(anzeigeFenster.lblPunkte2.Text);
            anzeigeFenster.lblPunkte2.Text = Convert.ToString(i - 1);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            anzeigeFenster.lblPunkte2.Text = "0";
            anzeigeFenster.lblPunkte1.Text = "0";            
        }
    }
}