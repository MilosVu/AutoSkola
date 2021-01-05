
namespace Forme
{
    partial class UCPolaznici
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPolaznici));
            this.lblPolaznici = new System.Windows.Forms.Label();
            this.dataGridPolaznici = new System.Windows.Forms.DataGridView();
            this.txtIdPolaznik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbKategorija = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnKreirajPolaznika = new System.Windows.Forms.Button();
            this.btnIzbrisiPolaznika = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDodajGrupuZaPolaganje = new System.Windows.Forms.Button();
            this.cbKategorijeZaPretragu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPolaznici)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPolaznici
            // 
            this.lblPolaznici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPolaznici.AutoSize = true;
            this.lblPolaznici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblPolaznici.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolaznici.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPolaznici.Location = new System.Drawing.Point(6, 25);
            this.lblPolaznici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPolaznici.Name = "lblPolaznici";
            this.lblPolaznici.Size = new System.Drawing.Size(137, 40);
            this.lblPolaznici.TabIndex = 0;
            this.lblPolaznici.Text = "Polaznici";
            // 
            // dataGridPolaznici
            // 
            this.dataGridPolaznici.AllowUserToAddRows = false;
            this.dataGridPolaznici.AllowUserToDeleteRows = false;
            this.dataGridPolaznici.AllowUserToOrderColumns = true;
            this.dataGridPolaznici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridPolaznici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPolaznici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPolaznici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPolaznici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdPolaznik,
            this.txtIme,
            this.txtPrezime,
            this.txtDatumRodjenja,
            this.cbKategorija});
            this.dataGridPolaznici.Location = new System.Drawing.Point(7, 91);
            this.dataGridPolaznici.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridPolaznici.Name = "dataGridPolaznici";
            this.dataGridPolaznici.RowHeadersWidth = 51;
            this.dataGridPolaznici.RowTemplate.Height = 24;
            this.dataGridPolaznici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPolaznici.Size = new System.Drawing.Size(954, 454);
            this.dataGridPolaznici.TabIndex = 1;
            this.dataGridPolaznici.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPolaznici_CellValueChanged);
            this.dataGridPolaznici.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridPolaznici_DataBindingComplete);
            this.dataGridPolaznici.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridPolaznici_DataError);
            this.dataGridPolaznici.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridPolaznici_MouseDoubleClick);
            // 
            // txtIdPolaznik
            // 
            this.txtIdPolaznik.DataPropertyName = "IdPolaznika";
            this.txtIdPolaznik.HeaderText = "Id";
            this.txtIdPolaznik.MinimumWidth = 6;
            this.txtIdPolaznik.Name = "txtIdPolaznik";
            this.txtIdPolaznik.Visible = false;
            // 
            // txtIme
            // 
            this.txtIme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtIme.DataPropertyName = "Ime";
            this.txtIme.HeaderText = "Ime";
            this.txtIme.MinimumWidth = 6;
            this.txtIme.Name = "txtIme";
            // 
            // txtPrezime
            // 
            this.txtPrezime.DataPropertyName = "Prezime";
            this.txtPrezime.HeaderText = "Prezime";
            this.txtPrezime.MinimumWidth = 6;
            this.txtPrezime.Name = "txtPrezime";
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.txtDatumRodjenja.HeaderText = "Datum Rodjenja";
            this.txtDatumRodjenja.MinimumWidth = 6;
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            // 
            // cbKategorija
            // 
            this.cbKategorija.DataPropertyName = "Kategorija";
            this.cbKategorija.HeaderText = "Kategorija";
            this.cbKategorija.MinimumWidth = 6;
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbKategorija.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnKreirajPolaznika
            // 
            this.btnKreirajPolaznika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreirajPolaznika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKreirajPolaznika.FlatAppearance.BorderSize = 0;
            this.btnKreirajPolaznika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajPolaznika.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKreirajPolaznika.Image = ((System.Drawing.Image)(resources.GetObject("btnKreirajPolaznika.Image")));
            this.btnKreirajPolaznika.Location = new System.Drawing.Point(790, 555);
            this.btnKreirajPolaznika.Name = "btnKreirajPolaznika";
            this.btnKreirajPolaznika.Size = new System.Drawing.Size(79, 72);
            this.btnKreirajPolaznika.TabIndex = 2;
            this.btnKreirajPolaznika.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKreirajPolaznika.UseVisualStyleBackColor = true;
            this.btnKreirajPolaznika.Click += new System.EventHandler(this.btnKreirajPolaznika_Click);
            // 
            // btnIzbrisiPolaznika
            // 
            this.btnIzbrisiPolaznika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzbrisiPolaznika.FlatAppearance.BorderSize = 0;
            this.btnIzbrisiPolaznika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiPolaznika.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzbrisiPolaznika.Image = ((System.Drawing.Image)(resources.GetObject("btnIzbrisiPolaznika.Image")));
            this.btnIzbrisiPolaznika.Location = new System.Drawing.Point(875, 552);
            this.btnIzbrisiPolaznika.Name = "btnIzbrisiPolaznika";
            this.btnIzbrisiPolaznika.Size = new System.Drawing.Size(79, 75);
            this.btnIzbrisiPolaznika.TabIndex = 3;
            this.btnIzbrisiPolaznika.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIzbrisiPolaznika.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzbrisiPolaznika.UseVisualStyleBackColor = true;
            this.btnIzbrisiPolaznika.Click += new System.EventHandler(this.btnIzbrisiPolaznika_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(13, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 1);
            this.panel1.TabIndex = 4;
            // 
            // btnDodajGrupuZaPolaganje
            // 
            this.btnDodajGrupuZaPolaganje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajGrupuZaPolaganje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajGrupuZaPolaganje.FlatAppearance.BorderSize = 0;
            this.btnDodajGrupuZaPolaganje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajGrupuZaPolaganje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajGrupuZaPolaganje.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajGrupuZaPolaganje.Image")));
            this.btnDodajGrupuZaPolaganje.Location = new System.Drawing.Point(7, 547);
            this.btnDodajGrupuZaPolaganje.Name = "btnDodajGrupuZaPolaganje";
            this.btnDodajGrupuZaPolaganje.Size = new System.Drawing.Size(79, 72);
            this.btnDodajGrupuZaPolaganje.TabIndex = 5;
            this.btnDodajGrupuZaPolaganje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajGrupuZaPolaganje.UseVisualStyleBackColor = true;
            this.btnDodajGrupuZaPolaganje.Click += new System.EventHandler(this.btnDodajGrupuZaPolaganje_Click);
            // 
            // cbKategorijeZaPretragu
            // 
            this.cbKategorijeZaPretragu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKategorijeZaPretragu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cbKategorijeZaPretragu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorijeZaPretragu.ForeColor = System.Drawing.Color.White;
            this.cbKategorijeZaPretragu.FormattingEnabled = true;
            this.cbKategorijeZaPretragu.Location = new System.Drawing.Point(803, 33);
            this.cbKategorijeZaPretragu.Name = "cbKategorijeZaPretragu";
            this.cbKategorijeZaPretragu.Size = new System.Drawing.Size(151, 32);
            this.cbKategorijeZaPretragu.TabIndex = 6;
            this.cbKategorijeZaPretragu.SelectedIndexChanged += new System.EventHandler(this.cbKategorije_SelectedIndexChanged);
            // 
            // UCPolaznici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.cbKategorijeZaPretragu);
            this.Controls.Add(this.btnDodajGrupuZaPolaganje);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIzbrisiPolaznika);
            this.Controls.Add(this.btnKreirajPolaznika);
            this.Controls.Add(this.dataGridPolaznici);
            this.Controls.Add(this.lblPolaznici);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCPolaznici";
            this.Size = new System.Drawing.Size(968, 622);
            this.Load += new System.EventHandler(this.UCPolaznici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPolaznici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPolaznici;
        private System.Windows.Forms.DataGridView dataGridPolaznici;
        private System.Windows.Forms.Button btnKreirajPolaznika;
        private System.Windows.Forms.Button btnIzbrisiPolaznika;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdPolaznik;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDatumRodjenja;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbKategorija;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDodajGrupuZaPolaganje;
        private System.Windows.Forms.ComboBox cbKategorijeZaPretragu;
    }
}
