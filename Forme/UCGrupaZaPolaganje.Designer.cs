
namespace Forme
{
    partial class UCGrupaZaPolaganje
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
            this.lblPretraga = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.btnKreirajVoznju = new System.Windows.Forms.Button();
            this.dataGridVoznje = new System.Windows.Forms.DataGridView();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polaznik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInstruktor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Realizovan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Automobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVoznje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVoznje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPretraga
            // 
            this.lblPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblPretraga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPretraga.Location = new System.Drawing.Point(731, 48);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(77, 24);
            this.lblPretraga.TabIndex = 22;
            this.lblPretraga.Text = "Pretraga:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretraga.Location = new System.Drawing.Point(814, 42);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(202, 30);
            this.txtPretraga.TabIndex = 21;
            // 
            // cbKategorija
            // 
            this.cbKategorija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKategorija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cbKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(1046, 42);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(151, 32);
            this.cbKategorija.TabIndex = 20;
            // 
            // btnKreirajVoznju
            // 
            this.btnKreirajVoznju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreirajVoznju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajVoznju.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajVoznju.ForeColor = System.Drawing.Color.White;
            this.btnKreirajVoznju.Location = new System.Drawing.Point(61, 549);
            this.btnKreirajVoznju.Name = "btnKreirajVoznju";
            this.btnKreirajVoznju.Size = new System.Drawing.Size(148, 39);
            this.btnKreirajVoznju.TabIndex = 19;
            this.btnKreirajVoznju.Text = "Kreiraj vožnju";
            this.btnKreirajVoznju.UseVisualStyleBackColor = true;
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
            this.Realizovan,
            this.Automobil});
            this.dataGridVoznje.Location = new System.Drawing.Point(5, 76);
            this.dataGridVoznje.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridVoznje.Name = "dataGridVoznje";
            this.dataGridVoznje.RowHeadersWidth = 51;
            this.dataGridVoznje.RowTemplate.Height = 24;
            this.dataGridVoznje.Size = new System.Drawing.Size(1213, 454);
            this.dataGridVoznje.TabIndex = 18;
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "Kategorija";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MinimumWidth = 6;
            this.Kategorija.Name = "Kategorija";
            // 
            // Polaznik
            // 
            this.Polaznik.DataPropertyName = "Polaznik";
            this.Polaznik.HeaderText = "Polaznik";
            this.Polaznik.MinimumWidth = 6;
            this.Polaznik.Name = "Polaznik";
            // 
            // txtInstruktor
            // 
            this.txtInstruktor.DataPropertyName = "Instruktor";
            this.txtInstruktor.HeaderText = "Instruktor";
            this.txtInstruktor.MinimumWidth = 6;
            this.txtInstruktor.Name = "txtInstruktor";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            // 
            // BrojCasa
            // 
            this.BrojCasa.DataPropertyName = "BrojCasa";
            this.BrojCasa.HeaderText = "Broja casa";
            this.BrojCasa.MinimumWidth = 6;
            this.BrojCasa.Name = "BrojCasa";
            // 
            // Realizovan
            // 
            this.Realizovan.DataPropertyName = "Realizovan";
            this.Realizovan.HeaderText = "Realizovan";
            this.Realizovan.MinimumWidth = 6;
            this.Realizovan.Name = "Realizovan";
            // 
            // Automobil
            // 
            this.Automobil.DataPropertyName = "Automobil";
            this.Automobil.HeaderText = "Automobil";
            this.Automobil.MinimumWidth = 6;
            this.Automobil.Name = "Automobil";
            // 
            // lblVoznje
            // 
            this.lblVoznje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVoznje.AutoSize = true;
            this.lblVoznje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblVoznje.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoznje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVoznje.Location = new System.Drawing.Point(5, 32);
            this.lblVoznje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoznje.Name = "lblVoznje";
            this.lblVoznje.Size = new System.Drawing.Size(106, 40);
            this.lblVoznje.TabIndex = 17;
            this.lblVoznje.Text = "Vožnje";
            // 
            // UCGrupaZaPolaganje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.btnKreirajVoznju);
            this.Controls.Add(this.dataGridVoznje);
            this.Controls.Add(this.lblVoznje);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCGrupaZaPolaganje";
            this.Size = new System.Drawing.Size(1223, 620);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVoznje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Button btnKreirajVoznju;
        private System.Windows.Forms.DataGridView dataGridVoznje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polaznik;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInstruktor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojCasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Realizovan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Automobil;
        private System.Windows.Forms.Label lblVoznje;
    }
}
