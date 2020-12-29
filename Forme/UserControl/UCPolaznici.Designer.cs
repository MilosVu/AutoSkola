
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
            this.btnKreirajPolaznika = new System.Windows.Forms.Button();
            this.btnIzbrisiPolaznika = new System.Windows.Forms.Button();
            this.btnPretraziPolaznika = new System.Windows.Forms.Button();
            this.txtIdPolaznik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbKategorija = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPolaznici)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPolaznici
            // 
            this.lblPolaznici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPolaznici.AutoSize = true;
            this.lblPolaznici.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPolaznici.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolaznici.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPolaznici.Location = new System.Drawing.Point(54, 19);
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
            this.dataGridPolaznici.Location = new System.Drawing.Point(4, 78);
            this.dataGridPolaznici.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridPolaznici.Name = "dataGridPolaznici";
            this.dataGridPolaznici.RowHeadersWidth = 51;
            this.dataGridPolaznici.RowTemplate.Height = 24;
            this.dataGridPolaznici.Size = new System.Drawing.Size(954, 454);
            this.dataGridPolaznici.TabIndex = 1;
            this.dataGridPolaznici.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPolaznici_CellValueChanged);
            this.dataGridPolaznici.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridPolaznici_DataError);
            this.dataGridPolaznici.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridPolaznici_MouseDoubleClick);
            // 
            // btnKreirajPolaznika
            // 
            this.btnKreirajPolaznika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreirajPolaznika.Location = new System.Drawing.Point(113, 551);
            this.btnKreirajPolaznika.Name = "btnKreirajPolaznika";
            this.btnKreirajPolaznika.Size = new System.Drawing.Size(149, 39);
            this.btnKreirajPolaznika.TabIndex = 2;
            this.btnKreirajPolaznika.Text = "Kreiraj Polaznika";
            this.btnKreirajPolaznika.UseVisualStyleBackColor = true;
            this.btnKreirajPolaznika.Click += new System.EventHandler(this.btnKreirajPolaznika_Click);
            // 
            // btnIzbrisiPolaznika
            // 
            this.btnIzbrisiPolaznika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzbrisiPolaznika.Location = new System.Drawing.Point(402, 551);
            this.btnIzbrisiPolaznika.Name = "btnIzbrisiPolaznika";
            this.btnIzbrisiPolaznika.Size = new System.Drawing.Size(149, 39);
            this.btnIzbrisiPolaznika.TabIndex = 3;
            this.btnIzbrisiPolaznika.Text = "Izbrisi Polaznika";
            this.btnIzbrisiPolaznika.UseVisualStyleBackColor = true;
            this.btnIzbrisiPolaznika.Click += new System.EventHandler(this.btnIzbrisiPolaznika_Click);
            // 
            // btnPretraziPolaznika
            // 
            this.btnPretraziPolaznika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretraziPolaznika.Location = new System.Drawing.Point(692, 551);
            this.btnPretraziPolaznika.Name = "btnPretraziPolaznika";
            this.btnPretraziPolaznika.Size = new System.Drawing.Size(149, 39);
            this.btnPretraziPolaznika.TabIndex = 4;
            this.btnPretraziPolaznika.Text = "Pretrazi Polaznika";
            this.btnPretraziPolaznika.UseVisualStyleBackColor = true;
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
            // UCPolaznici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.btnPretraziPolaznika);
            this.Controls.Add(this.btnIzbrisiPolaznika);
            this.Controls.Add(this.btnKreirajPolaznika);
            this.Controls.Add(this.dataGridPolaznici);
            this.Controls.Add(this.lblPolaznici);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCPolaznici";
            this.Size = new System.Drawing.Size(962, 614);
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
        private System.Windows.Forms.Button btnPretraziPolaznika;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdPolaznik;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDatumRodjenja;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbKategorija;
    }
}
