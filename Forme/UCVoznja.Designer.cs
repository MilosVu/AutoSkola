
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCVoznja));
            this.btnPretraziVoznju = new System.Windows.Forms.Button();
            this.btnKreirajVoznju = new System.Windows.Forms.Button();
            this.dataGridVoznje = new System.Windows.Forms.DataGridView();
            this.lblVoznje = new System.Windows.Forms.Label();
            this.IdPolaznika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeIPrezimePolaznika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdPolaznik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeIPrezimeInstruktora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Realizovan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAutomobila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Automobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVoznje)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPretraziVoznju
            // 
            this.btnPretraziVoznju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretraziVoznju.Location = new System.Drawing.Point(744, 557);
            this.btnPretraziVoznju.Name = "btnPretraziVoznju";
            this.btnPretraziVoznju.Size = new System.Drawing.Size(197, 39);
            this.btnPretraziVoznju.TabIndex = 13;
            this.btnPretraziVoznju.Text = "Pretrazi Voznju";
            this.btnPretraziVoznju.UseVisualStyleBackColor = true;
            // 
            // btnKreirajVoznju
            // 
            this.btnKreirajVoznju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreirajVoznju.Location = new System.Drawing.Point(269, 557);
            this.btnKreirajVoznju.Name = "btnKreirajVoznju";
            this.btnKreirajVoznju.Size = new System.Drawing.Size(197, 39);
            this.btnKreirajVoznju.TabIndex = 12;
            this.btnKreirajVoznju.Text = "Kreiraj Voznju";
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
            this.IdPolaznika,
            this.ImeIPrezimePolaznika,
            this.txtIdPolaznik,
            this.ImeIPrezimeInstruktora,
            this.Datum,
            this.BrojCasa,
            this.Realizovan,
            this.IdAutomobila,
            this.Automobil});
            this.dataGridVoznje.Location = new System.Drawing.Point(4, 84);
            this.dataGridVoznje.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridVoznje.Name = "dataGridVoznje";
            this.dataGridVoznje.RowHeadersWidth = 51;
            this.dataGridVoznje.RowTemplate.Height = 24;
            this.dataGridVoznje.Size = new System.Drawing.Size(1213, 454);
            this.dataGridVoznje.TabIndex = 11;
            // 
            // lblVoznje
            // 
            this.lblVoznje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVoznje.AutoSize = true;
            this.lblVoznje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVoznje.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoznje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVoznje.Location = new System.Drawing.Point(53, 25);
            this.lblVoznje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoznje.Name = "lblVoznje";
            this.lblVoznje.Size = new System.Drawing.Size(106, 40);
            this.lblVoznje.TabIndex = 10;
            this.lblVoznje.Text = "Voznje";
            // 
            // IdPolaznika
            // 
            this.IdPolaznika.DataPropertyName = "IdPolaznika";
            this.IdPolaznika.HeaderText = "IdPolaznika";
            this.IdPolaznika.MinimumWidth = 6;
            this.IdPolaznika.Name = "IdPolaznika";
            this.IdPolaznika.Visible = false;
            // 
            // ImeIPrezimePolaznika
            // 
            this.ImeIPrezimePolaznika.DataPropertyName = "ImeIPrezimePolaznika";
            this.ImeIPrezimePolaznika.HeaderText = "Ime i prezime polaznika";
            this.ImeIPrezimePolaznika.MinimumWidth = 6;
            this.ImeIPrezimePolaznika.Name = "ImeIPrezimePolaznika";
            // 
            // txtIdPolaznik
            // 
            this.txtIdPolaznik.DataPropertyName = "IdInstruktora";
            this.txtIdPolaznik.HeaderText = "IdInstruktora";
            this.txtIdPolaznik.MinimumWidth = 6;
            this.txtIdPolaznik.Name = "txtIdPolaznik";
            this.txtIdPolaznik.Visible = false;
            // 
            // ImeIPrezimeInstruktora
            // 
            this.ImeIPrezimeInstruktora.DataPropertyName = "ImeIPrezimeInstruktora";
            this.ImeIPrezimeInstruktora.HeaderText = "Ime i prezime instruktora";
            this.ImeIPrezimeInstruktora.MinimumWidth = 6;
            this.ImeIPrezimeInstruktora.Name = "ImeIPrezimeInstruktora";
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
            // IdAutomobila
            // 
            this.IdAutomobila.DataPropertyName = "IdAutomobila";
            this.IdAutomobila.HeaderText = "IdAutomobila";
            this.IdAutomobila.MinimumWidth = 6;
            this.IdAutomobila.Name = "IdAutomobila";
            this.IdAutomobila.Visible = false;
            // 
            // Automobil
            // 
            this.Automobil.DataPropertyName = "Automobil";
            this.Automobil.HeaderText = "Automobil";
            this.Automobil.MinimumWidth = 6;
            this.Automobil.Name = "Automobil";
            // 
            // UCVoznja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnPretraziVoznju);
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

        private System.Windows.Forms.Button btnPretraziVoznju;
        private System.Windows.Forms.Button btnKreirajVoznju;
        private System.Windows.Forms.DataGridView dataGridVoznje;
        private System.Windows.Forms.Label lblVoznje;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPolaznika;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeIPrezimePolaznika;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdPolaznik;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeIPrezimeInstruktora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojCasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Realizovan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAutomobila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Automobil;
    }
}
