
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
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.cbPrikazLoznike = new System.Windows.Forms.CheckBox();
            this.pictureKorisnickoIme = new System.Windows.Forms.PictureBox();
            this.pictureLozinka = new System.Windows.Forms.PictureBox();
            this.lblFormaZaPrijavljivanje = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKorisnickoIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLozinka)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrijaviSe.BackColor = System.Drawing.Color.SeaShell;
            this.btnPrijaviSe.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijaviSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnPrijaviSe.Location = new System.Drawing.Point(115, 307);
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
            this.txtKorisnickoIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtKorisnickoIme.ForeColor = System.Drawing.Color.White;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(158, 141);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(200, 30);
            this.txtKorisnickoIme.TabIndex = 4;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLozinka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtLozinka.ForeColor = System.Drawing.Color.White;
            this.txtLozinka.Location = new System.Drawing.Point(158, 204);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(200, 30);
            this.txtLozinka.TabIndex = 5;
            // 
            // cbPrikazLoznike
            // 
            this.cbPrikazLoznike.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPrikazLoznike.AutoSize = true;
            this.cbPrikazLoznike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cbPrikazLoznike.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbPrikazLoznike.Location = new System.Drawing.Point(158, 251);
            this.cbPrikazLoznike.Name = "cbPrikazLoznike";
            this.cbPrikazLoznike.Size = new System.Drawing.Size(133, 28);
            this.cbPrikazLoznike.TabIndex = 6;
            this.cbPrikazLoznike.Text = "Prikaži lozniku";
            this.cbPrikazLoznike.UseVisualStyleBackColor = false;
            this.cbPrikazLoznike.CheckedChanged += new System.EventHandler(this.cbPrikazLoznike_CheckedChanged);
            // 
            // pictureKorisnickoIme
            // 
            this.pictureKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureKorisnickoIme.Image = ((System.Drawing.Image)(resources.GetObject("pictureKorisnickoIme.Image")));
            this.pictureKorisnickoIme.Location = new System.Drawing.Point(97, 138);
            this.pictureKorisnickoIme.Name = "pictureKorisnickoIme";
            this.pictureKorisnickoIme.Size = new System.Drawing.Size(45, 33);
            this.pictureKorisnickoIme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureKorisnickoIme.TabIndex = 19;
            this.pictureKorisnickoIme.TabStop = false;
            // 
            // pictureLozinka
            // 
            this.pictureLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureLozinka.Image = ((System.Drawing.Image)(resources.GetObject("pictureLozinka.Image")));
            this.pictureLozinka.Location = new System.Drawing.Point(97, 194);
            this.pictureLozinka.Name = "pictureLozinka";
            this.pictureLozinka.Size = new System.Drawing.Size(45, 40);
            this.pictureLozinka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLozinka.TabIndex = 20;
            this.pictureLozinka.TabStop = false;
            // 
            // lblFormaZaPrijavljivanje
            // 
            this.lblFormaZaPrijavljivanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFormaZaPrijavljivanje.AutoSize = true;
            this.lblFormaZaPrijavljivanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblFormaZaPrijavljivanje.Font = new System.Drawing.Font("Arial Narrow", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaZaPrijavljivanje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFormaZaPrijavljivanje.Location = new System.Drawing.Point(89, 53);
            this.lblFormaZaPrijavljivanje.Name = "lblFormaZaPrijavljivanje";
            this.lblFormaZaPrijavljivanje.Size = new System.Drawing.Size(369, 46);
            this.lblFormaZaPrijavljivanje.TabIndex = 21;
            this.lblFormaZaPrijavljivanje.Text = "Forma za prijavljivanje";
            this.lblFormaZaPrijavljivanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(39, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 1);
            this.panel1.TabIndex = 22;
            // 
            // FormaPrijavljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFormaZaPrijavljivanje);
            this.Controls.Add(this.pictureLozinka);
            this.Controls.Add(this.pictureKorisnickoIme);
            this.Controls.Add(this.cbPrikazLoznike);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.btnPrijaviSe);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaPrijavljivanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma za prijavljivanje";
            this.Load += new System.EventHandler(this.FormaPrijavljivanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureKorisnickoIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLozinka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.CheckBox cbPrikazLoznike;
        private System.Windows.Forms.PictureBox pictureKorisnickoIme;
        private System.Windows.Forms.PictureBox pictureLozinka;
        private System.Windows.Forms.Label lblFormaZaPrijavljivanje;
        private System.Windows.Forms.Panel panel1;
    }
}

