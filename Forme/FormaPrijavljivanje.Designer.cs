
namespace Forme
{
    partial class FormaPrijavljivanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPrijavljivanje));
            this.lblFormaZaPrijavljivanje = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.cbPrikazLoznike = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblFormaZaPrijavljivanje
            // 
            this.lblFormaZaPrijavljivanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFormaZaPrijavljivanje.AutoSize = true;
            this.lblFormaZaPrijavljivanje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFormaZaPrijavljivanje.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaZaPrijavljivanje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFormaZaPrijavljivanje.Location = new System.Drawing.Point(204, 74);
            this.lblFormaZaPrijavljivanje.Name = "lblFormaZaPrijavljivanje";
            this.lblFormaZaPrijavljivanje.Size = new System.Drawing.Size(386, 42);
            this.lblFormaZaPrijavljivanje.TabIndex = 0;
            this.lblFormaZaPrijavljivanje.Text = "Forma za prijavljivanje";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(161, 178);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(140, 29);
            this.lblKorisnickoIme.TabIndex = 1;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // lblLozinka
            // 
            this.lblLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLozinka.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLozinka.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLozinka.Location = new System.Drawing.Point(220, 261);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(81, 29);
            this.lblLozinka.TabIndex = 2;
            this.lblLozinka.Text = "Lozinka";
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrijaviSe.BackColor = System.Drawing.Color.SeaShell;
            this.btnPrijaviSe.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijaviSe.Location = new System.Drawing.Point(271, 385);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(243, 47);
            this.btnPrijaviSe.TabIndex = 3;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(328, 177);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(262, 30);
            this.txtKorisnickoIme.TabIndex = 4;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLozinka.Location = new System.Drawing.Point(328, 259);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(262, 30);
            this.txtLozinka.TabIndex = 5;
            // 
            // cbPrikazLoznike
            // 
            this.cbPrikazLoznike.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPrikazLoznike.AutoSize = true;
            this.cbPrikazLoznike.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbPrikazLoznike.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbPrikazLoznike.Location = new System.Drawing.Point(613, 261);
            this.cbPrikazLoznike.Name = "cbPrikazLoznike";
            this.cbPrikazLoznike.Size = new System.Drawing.Size(133, 28);
            this.cbPrikazLoznike.TabIndex = 6;
            this.cbPrikazLoznike.Text = "Prikazi lozniku";
            this.cbPrikazLoznike.UseVisualStyleBackColor = false;
            this.cbPrikazLoznike.CheckedChanged += new System.EventHandler(this.cbPrikazLoznike_CheckedChanged);
            // 
            // FormaPrijavljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 466);
            this.Controls.Add(this.cbPrikazLoznike);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.lblFormaZaPrijavljivanje);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaPrijavljivanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma za prijavljivanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormaZaPrijavljivanje;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.CheckBox cbPrikazLoznike;
    }
}

