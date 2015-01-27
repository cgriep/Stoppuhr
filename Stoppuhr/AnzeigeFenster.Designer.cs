namespace Stoppuhr
{
    partial class AnzeigeFenster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnzeigeFenster));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblZeit = new System.Windows.Forms.Label();
            this.tblPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblTrennung = new System.Windows.Forms.Label();
            this.lblHeim = new System.Windows.Forms.Label();
            this.lblNone = new System.Windows.Forms.Label();
            this.lblGast = new System.Windows.Forms.Label();
            this.lblPunkte1 = new System.Windows.Forms.Label();
            this.lblDoppelpunkt = new System.Windows.Forms.Label();
            this.lblPunkte2 = new System.Windows.Forms.Label();
            this.tblPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 349);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 0);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblZeit
            // 
            this.lblZeit.BackColor = System.Drawing.Color.Black;
            this.lblZeit.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZeit.ForeColor = System.Drawing.Color.Red;
            this.lblZeit.Location = new System.Drawing.Point(0, 0);
            this.lblZeit.Margin = new System.Windows.Forms.Padding(0);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(660, 349);
            this.lblZeit.TabIndex = 9;
            this.lblZeit.Text = "00:00";
            this.lblZeit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblPanel
            // 
            this.tblPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblPanel.BackColor = System.Drawing.Color.Black;
            this.tblPanel.ColumnCount = 3;
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.Controls.Add(this.lblTrennung, 0, 0);
            this.tblPanel.Controls.Add(this.lblHeim, 0, 1);
            this.tblPanel.Controls.Add(this.lblNone, 1, 1);
            this.tblPanel.Controls.Add(this.lblGast, 2, 1);
            this.tblPanel.Controls.Add(this.lblPunkte1, 0, 2);
            this.tblPanel.Controls.Add(this.lblDoppelpunkt, 1, 2);
            this.tblPanel.Controls.Add(this.lblPunkte2, 2, 2);
            this.tblPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblPanel.Location = new System.Drawing.Point(0, 234);
            this.tblPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tblPanel.Name = "tblPanel";
            this.tblPanel.RowCount = 3;
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel.Size = new System.Drawing.Size(660, 115);
            this.tblPanel.TabIndex = 10;
            this.tblPanel.Visible = false;
            // 
            // lblTrennung
            // 
            this.lblTrennung.AutoSize = true;
            this.lblTrennung.BackColor = System.Drawing.Color.Red;
            this.tblPanel.SetColumnSpan(this.lblTrennung, 3);
            this.lblTrennung.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrennung.Location = new System.Drawing.Point(3, 0);
            this.lblTrennung.Name = "lblTrennung";
            this.lblTrennung.Size = new System.Drawing.Size(654, 5);
            this.lblTrennung.TabIndex = 8;
            // 
            // lblHeim
            // 
            this.lblHeim.AutoSize = true;
            this.lblHeim.BackColor = System.Drawing.Color.Black;
            this.lblHeim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeim.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeim.ForeColor = System.Drawing.Color.Red;
            this.lblHeim.Location = new System.Drawing.Point(3, 5);
            this.lblHeim.Name = "lblHeim";
            this.lblHeim.Size = new System.Drawing.Size(295, 37);
            this.lblHeim.TabIndex = 6;
            this.lblHeim.Text = "Heim";
            this.lblHeim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNone
            // 
            this.lblNone.AutoSize = true;
            this.lblNone.BackColor = System.Drawing.Color.Black;
            this.lblNone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNone.ForeColor = System.Drawing.Color.Red;
            this.lblNone.Location = new System.Drawing.Point(304, 5);
            this.lblNone.Name = "lblNone";
            this.lblNone.Size = new System.Drawing.Size(51, 37);
            this.lblNone.TabIndex = 5;
            this.lblNone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGast
            // 
            this.lblGast.AutoSize = true;
            this.lblGast.BackColor = System.Drawing.Color.Black;
            this.lblGast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGast.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGast.ForeColor = System.Drawing.Color.Red;
            this.lblGast.Location = new System.Drawing.Point(361, 5);
            this.lblGast.Name = "lblGast";
            this.lblGast.Size = new System.Drawing.Size(296, 37);
            this.lblGast.TabIndex = 2;
            this.lblGast.Text = "Gast";
            this.lblGast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPunkte1
            // 
            this.lblPunkte1.BackColor = System.Drawing.Color.Black;
            this.lblPunkte1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPunkte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunkte1.ForeColor = System.Drawing.Color.Red;
            this.lblPunkte1.Location = new System.Drawing.Point(3, 42);
            this.lblPunkte1.Name = "lblPunkte1";
            this.lblPunkte1.Size = new System.Drawing.Size(295, 73);
            this.lblPunkte1.TabIndex = 9;
            this.lblPunkte1.Text = "0";
            this.lblPunkte1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDoppelpunkt
            // 
            this.lblDoppelpunkt.AutoSize = true;
            this.lblDoppelpunkt.BackColor = System.Drawing.Color.Black;
            this.lblDoppelpunkt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoppelpunkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoppelpunkt.ForeColor = System.Drawing.Color.Red;
            this.lblDoppelpunkt.Location = new System.Drawing.Point(304, 42);
            this.lblDoppelpunkt.Name = "lblDoppelpunkt";
            this.lblDoppelpunkt.Size = new System.Drawing.Size(51, 73);
            this.lblDoppelpunkt.TabIndex = 8;
            this.lblDoppelpunkt.Text = ":";
            this.lblDoppelpunkt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPunkte2
            // 
            this.lblPunkte2.BackColor = System.Drawing.Color.Black;
            this.lblPunkte2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPunkte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunkte2.ForeColor = System.Drawing.Color.Red;
            this.lblPunkte2.Location = new System.Drawing.Point(361, 42);
            this.lblPunkte2.Name = "lblPunkte2";
            this.lblPunkte2.Size = new System.Drawing.Size(296, 73);
            this.lblPunkte2.TabIndex = 7;
            this.lblPunkte2.Text = "0";
            this.lblPunkte2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnzeigeFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 349);
            this.Controls.Add(this.tblPanel);
            this.Controls.Add(this.lblZeit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnzeigeFenster";
            this.Text = "Stoppuhr";
            this.SizeChanged += new System.EventHandler(this.Form1_Resize);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Shown += new System.EventHandler(this.Form1_Resize);
            this.Load += new System.EventHandler(this.AnzeigeFenster_Load);
            this.tblPanel.ResumeLayout(false);
            this.tblPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lblZeit;
        public System.Windows.Forms.TableLayoutPanel tblPanel;
        private System.Windows.Forms.Label lblTrennung;
        private System.Windows.Forms.Label lblHeim;
        private System.Windows.Forms.Label lblNone;
        private System.Windows.Forms.Label lblGast;
        public System.Windows.Forms.Label lblPunkte1;
        private System.Windows.Forms.Label lblDoppelpunkt;
        public System.Windows.Forms.Label lblPunkte2;
    }
}

