
namespace Forme
{
    partial class FormaGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaGlavna));
            this.panelGlavni = new System.Windows.Forms.Panel();
            this.lblUlogovanKorisnik = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.polazniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazPolaznikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instruktoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazInstruktoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voznjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupeZaPolaganjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajGrupuZaPolaganjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGlavni.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGlavni
            // 
            this.panelGlavni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGlavni.BackgroundImage")));
            this.panelGlavni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelGlavni.Controls.Add(this.lblUlogovanKorisnik);
            this.panelGlavni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGlavni.Location = new System.Drawing.Point(0, 0);
            this.panelGlavni.Margin = new System.Windows.Forms.Padding(4);
            this.panelGlavni.Name = "panelGlavni";
            this.panelGlavni.Size = new System.Drawing.Size(1259, 801);
            this.panelGlavni.TabIndex = 0;
            // 
            // lblUlogovanKorisnik
            // 
            this.lblUlogovanKorisnik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUlogovanKorisnik.AutoSize = true;
            this.lblUlogovanKorisnik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUlogovanKorisnik.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUlogovanKorisnik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUlogovanKorisnik.Location = new System.Drawing.Point(109, 167);
            this.lblUlogovanKorisnik.Name = "lblUlogovanKorisnik";
            this.lblUlogovanKorisnik.Size = new System.Drawing.Size(167, 29);
            this.lblUlogovanKorisnik.TabIndex = 2;
            this.lblUlogovanKorisnik.Text = "Ulogovan korisnik";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polazniciToolStripMenuItem,
            this.instruktoriToolStripMenuItem,
            this.voznjeToolStripMenuItem,
            this.grupeZaPolaganjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1259, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // polazniciToolStripMenuItem
            // 
            this.polazniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazPolaznikaToolStripMenuItem});
            this.polazniciToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polazniciToolStripMenuItem.Name = "polazniciToolStripMenuItem";
            this.polazniciToolStripMenuItem.Size = new System.Drawing.Size(87, 28);
            this.polazniciToolStripMenuItem.Text = "Polaznici";
            // 
            // prikazPolaznikaToolStripMenuItem
            // 
            this.prikazPolaznikaToolStripMenuItem.Name = "prikazPolaznikaToolStripMenuItem";
            this.prikazPolaznikaToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.prikazPolaznikaToolStripMenuItem.Text = "Prikaz polaznika";
            this.prikazPolaznikaToolStripMenuItem.Click += new System.EventHandler(this.prikazPolaznikaToolStripMenuItem_Click);
            // 
            // instruktoriToolStripMenuItem
            // 
            this.instruktoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazInstruktoraToolStripMenuItem});
            this.instruktoriToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruktoriToolStripMenuItem.Name = "instruktoriToolStripMenuItem";
            this.instruktoriToolStripMenuItem.Size = new System.Drawing.Size(95, 28);
            this.instruktoriToolStripMenuItem.Text = "Instruktori";
            // 
            // prikazInstruktoraToolStripMenuItem
            // 
            this.prikazInstruktoraToolStripMenuItem.Name = "prikazInstruktoraToolStripMenuItem";
            this.prikazInstruktoraToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.prikazInstruktoraToolStripMenuItem.Text = "Prikaz instruktora";
            this.prikazInstruktoraToolStripMenuItem.Click += new System.EventHandler(this.prikazInstruktoraToolStripMenuItem_Click);
            // 
            // voznjeToolStripMenuItem
            // 
            this.voznjeToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voznjeToolStripMenuItem.Name = "voznjeToolStripMenuItem";
            this.voznjeToolStripMenuItem.Size = new System.Drawing.Size(73, 28);
            this.voznjeToolStripMenuItem.Text = "Voznje";
            // 
            // grupeZaPolaganjeToolStripMenuItem
            // 
            this.grupeZaPolaganjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajGrupuZaPolaganjeToolStripMenuItem});
            this.grupeZaPolaganjeToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupeZaPolaganjeToolStripMenuItem.Name = "grupeZaPolaganjeToolStripMenuItem";
            this.grupeZaPolaganjeToolStripMenuItem.Size = new System.Drawing.Size(165, 28);
            this.grupeZaPolaganjeToolStripMenuItem.Text = "Grupe za polaganje";
            // 
            // kreirajGrupuZaPolaganjeToolStripMenuItem
            // 
            this.kreirajGrupuZaPolaganjeToolStripMenuItem.Name = "kreirajGrupuZaPolaganjeToolStripMenuItem";
            this.kreirajGrupuZaPolaganjeToolStripMenuItem.Size = new System.Drawing.Size(281, 28);
            this.kreirajGrupuZaPolaganjeToolStripMenuItem.Text = "Kreiraj grupu za polaganje";
            // 
            // FormaGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 801);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelGlavni);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaGlavna";
            this.Load += new System.EventHandler(this.FormaGlavna_Load);
            this.panelGlavni.ResumeLayout(false);
            this.panelGlavni.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGlavni;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem polazniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instruktoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voznjeToolStripMenuItem;
        private System.Windows.Forms.Label lblUlogovanKorisnik;
        private System.Windows.Forms.ToolStripMenuItem prikazPolaznikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazInstruktoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupeZaPolaganjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajGrupuZaPolaganjeToolStripMenuItem;
    }
}