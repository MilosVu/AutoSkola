
namespace Forme
{
    partial class DialogKreirajPolaznika
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIme.AutoSize = true;
            this.lblIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblIme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIme.Location = new System.Drawing.Point(123, 55);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(44, 29);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime";
            this.lblIme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrezime
            // 
            this.lblPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblPrezime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrezime.Location = new System.Drawing.Point(82, 117);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(85, 29);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime";
            this.lblPrezime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblDatumRodjenja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(26, 181);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(141, 29);
            this.lblDatumRodjenja.TabIndex = 2;
            this.lblDatumRodjenja.Text = "Datum rođenja";
            this.lblDatumRodjenja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKategorija
            // 
            this.lblKategorija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblKategorija.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKategorija.Location = new System.Drawing.Point(66, 250);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(101, 29);
            this.lblKategorija.TabIndex = 3;
            this.lblKategorija.Text = "Kategorija";
            this.lblKategorija.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(189, 345);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(133, 42);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.BackColor = System.Drawing.Color.White;
            this.txtIme.ForeColor = System.Drawing.Color.Black;
            this.txtIme.Location = new System.Drawing.Point(173, 50);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(330, 34);
            this.txtIme.TabIndex = 5;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.BackColor = System.Drawing.Color.White;
            this.txtPrezime.ForeColor = System.Drawing.Color.Black;
            this.txtPrezime.Location = new System.Drawing.Point(173, 112);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(330, 34);
            this.txtPrezime.TabIndex = 6;
            // 
            // cbKategorija
            // 
            this.cbKategorija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKategorija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cbKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorija.ForeColor = System.Drawing.Color.Black;
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(173, 244);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(330, 35);
            this.cbKategorija.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.Location = new System.Drawing.Point(173, 176);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(330, 34);
            this.dateTimePicker.TabIndex = 8;
            // 
            // DialogKreirajPolaznika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 455);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.lblPrezime);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DialogKreirajPolaznika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogKreirajPolaznika";
            this.Load += new System.EventHandler(this.DialogKreirajPolaznika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}