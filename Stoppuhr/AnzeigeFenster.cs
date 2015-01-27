using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stoppuhr
{
    public partial class AnzeigeFenster : Form
    {
        public TimeSpan zeit;
        public TimeSpan zeroZeit;
        public TimeSpan subZeit;
        public TimeSpan countdownzeit;
        private SteuerungFenster steuerung;
        public SteuerungFenster Steuerung
        {
            set
            {
                steuerung = value;
            }
            get
            {
                return steuerung ;
            }
        }
        
        public System.Media.SoundPlayer simpleSound;

        public AnzeigeFenster()
        {
            InitializeComponent();
        }

        
        private void Form1_Resize(object sender, EventArgs e)
        {
            lblZeit.Width = this.Width;
            lblZeit.Height = this.Height;
            if (tblPanel.Visible)
            {
                lblZeit.Height = this.Height / 3*2;
                tblPanel.Height = this.Height / 3;
            }
            lblZeit.Font = new Font(lblZeit.Font.Name, (lblZeit.Width-lblZeit.Margin.Left-lblZeit.Margin.Right)/4,
                lblZeit.Font.Style, GraphicsUnit.Pixel);
            lblPunkte1.Font = new Font(lblPunkte1.Font.Name, (lblPunkte1.Width - lblPunkte1.Margin.Left - lblPunkte1.Margin.Right) / 4,
                lblPunkte1.Font.Style, GraphicsUnit.Pixel);
            lblPunkte2.Font = new Font(lblPunkte2.Font.Name, (lblPunkte2.Width - lblPunkte2.Margin.Left - lblPunkte2.Margin.Right) / 4,
                lblPunkte2.Font.Style, GraphicsUnit.Pixel);
        }
        private void changeColor()
        {
            if (lblZeit.BackColor == Color.Black)
            {
                lblZeit.BackColor = Color.DimGray;
            }
            else
            {
                lblZeit.BackColor = Color.Black;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ( Steuerung.rdoRichtungAb.Checked)
            {
                zeit = zeit.Subtract(subZeit);
                if (zeit.CompareTo(countdownzeit) < 0 && Steuerung.chkCountdown.Checked)
                {
                    // Countdown anzeigen
                    changeColor();
                    System.Media.SystemSounds.Beep.Play();
                }
            }
            else
            {
                zeit = zeit.Add(subZeit);
                if (zeit.CompareTo(countdownzeit) > 0 && Steuerung.chkCountdown.Checked )
                {
                    // Countdown anzeigen
                    changeColor();
                    System.Media.SystemSounds.Beep.Play();
                }
            }                       
            lblZeit.Text = zeit.ToString().Substring(3);
            if (zeit.Equals(zeroZeit))
            {
                timer1.Stop();                
                simpleSound.Play();
                Steuerung.btnStop.Enabled = false;
            }
        }

        private void AnzeigeFenster_Load(object sender, EventArgs e)
        {

        }

      
    }
}