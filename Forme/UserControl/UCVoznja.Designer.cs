
namespace Forme
{
    partial class UCVoznja
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
            this.btnKreirajVoznju = new System.Windows.Forms.Button();
            this.dataGridVoznje = new System.Windows.Forms.DataGridView();
            this.lblVoznje = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polaznik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInstruktor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Automobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVoznje)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKreirajVoznju
            // 
            this.btnKreirajVoznju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreirajVoznju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajVoznju.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajVoznju.ForeColor = System.Drawing.Color.White;
            this.btnKreirajVoznju.Location = new System.Drawing.Point(60, 557);
            this.btnKreirajVoznju.Name = "btnKreirajVoznju";
            this.btnKreirajVoznju.Size = new System.Drawing.Size(148, 39);
            this.btnKreirajVoznju.TabIndex = 12;
            this.btnKreirajVoznju.Text = "Kreiraj vožnju";
            this.btnKreirajVoznju.UseVisualStyleBackColor = true;
            this.btnKreirajVoznju.Click += new System.EventHandler(this.btnKreirajVoznju_Click);
            // 
            // dataGridVoznje
            // 
            this.dataGridVoznje.AllowUserToAddRows = false;
            this.dataGridVoznje.AllowUserToDeleteRows = false;
            this.dataGridVoznje.AllowUserToOrderColumns = true;
            this.dataGridVoznje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridVoznje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVoznje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVoznje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVoznje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kategorija,
            this.Polaznik,
            this.txtInstruktor,
            this.Datum,
            this.BrojCasa,
            this.Automobil});
            this.dataGridVoznje.Location = new System.Drawing.Point(4, 84);
            this.dataGridVoznje.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridVoznje.Name = "dataGridVoznje";
            this.dataGridVoznje.ReadOnly = true;
            this.dataGridVoznje.RowHeadersWidth = 51;
            this.dataGridVoznje.RowTemplate.Height = 24;
            this.dataGridVoznje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVoznje.Size = new System.Drawing.Size(1213, 454);
            this.dataGridVoznje.TabIndex = 11;
            // 
            // lblVoznje
            // 
            this.lblVoznje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVoznje.AutoSize = true;
            this.lblVoznje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblVoznje.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoznje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVoznje.Location = new System.Drawing.Point(4, 40);
            this.lblVoznje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoznje.Name = "lblVoznje";
            this.lblVoznje.Size = new System.Drawing.Size(106, 40);
            this.lblVoznje.TabIndex = 10;
            this.lblVoznje.Text = "Vožnje";
            // 
            // cbKategorija
            // 
            this.cbKategorija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKategorija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cbKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorija.ForeColor = System.Drawing.Color.White;
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(1045, 50);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(151, 32);
            this.cbKategorija.TabIndex = 14;
            this.cbKategorija.SelectedIndexChanged += new System.EventHandler(this.cbKategorija_SelectedIndexChanged);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretraga.Location = new System.Drawing.Point(813, 50);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(202, 30);
            this.txtPretraga.TabIndex = 15;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // lblPretraga
            // 
            this.lblPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblPretraga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPretraga.Location = new System.Drawing.Point(730, 56);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(77, 24);
            this.lblPretraga.TabIndex = 16;
            this.lblPretraga.Text = "Pretraga:";
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "Kategorija";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MinimumWidth = 6;
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            // 
            // Polaznik
            // 
            this.Polaznik.DataPropertyName = "Polaznik";
            this.Polaznik.HeaderText = "Polaznik";
            this.Polaznik.MinimumWidth = 6;
            this.Polaznik.Name = "Polaznik";
            this.Polaznik.ReadOnly = true;
            // 
            // txtInstruktor
            // 
            this.txtInstruktor.DataPropertyName = "Instruktor";
            this.txtInstruktor.HeaderText = "Instruktor";
            this.txtInstruktor.MinimumWidth = 6;
            this.txtInstruktor.Name = "txtInstruktor";
            this.txtInstruktor.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // BrojCasa
            // 
            this.BrojCasa.DataPropertyName = "BrojCasa";
            this.BrojCasa.HeaderText = "Broja casa";
            this.BrojCasa.MinimumWidth = 6;
            this.BrojCasa.Name = "BrojCasa";
            this.BrojCasa.ReadOnly = true;
            // 
            // Automobil
            // 
            this.Automobil.DataPropertyName = "Automobil";
            this.Automobil.HeaderText = "Automobil";
            this.Automobil.MinimumWidth = 6;
            this.Automobil.Name = "Automobil";
            this.Automobil.ReadOnly = true;
            // 
            // UCVoznja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.btnKreirajVoznju);
            this.Controls.Add(this.dataGridVoznje);
            this.Controls.Add(this.lblVoznje);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCVoznja";
            this.Size = new System.Drawing.Size(1221, 621);
            this.Load += new System.EventHandler(this.UCVoznja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVoznje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKreirajVoznju;
        private System.Windows.Forms.DataGridView dataGridVoznje;
        private System.Windows.Forms.Label lblVoznje;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polaznik;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInstruktor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojCasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Automobil;
    }
}
