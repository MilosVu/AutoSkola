
namespace Forme
{
    partial class UCInstruktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCInstruktor));
            this.btnPretraziInstruktora = new System.Windows.Forms.Button();
            this.btnIzbrisiInstruktora = new System.Windows.Forms.Button();
            this.dataGridInstruktori = new System.Windows.Forms.DataGridView();
            this.txtIdPolaznik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbKategorija = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lblInstruktori = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInstruktori)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPretraziInstruktora
            // 
            this.btnPretraziInstruktora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretraziInstruktora.Location = new System.Drawing.Point(615, 557);
            this.btnPretraziInstruktora.Name = "btnPretraziInstruktora";
            this.btnPretraziInstruktora.Size = new System.Drawing.Size(197, 39);
            this.btnPretraziInstruktora.TabIndex = 9;
            this.btnPretraziInstruktora.Text = "Pretrazi Instruktora";
            this.btnPretraziInstruktora.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiInstruktora
            // 
            this.btnIzbrisiInstruktora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzbrisiInstruktora.Location = new System.Drawing.Point(140, 557);
            this.btnIzbrisiInstruktora.Name = "btnIzbrisiInstruktora";
            this.btnIzbrisiInstruktora.Size = new System.Drawing.Size(197, 39);
            this.btnIzbrisiInstruktora.TabIndex = 8;
            this.btnIzbrisiInstruktora.Text = "Izbrisi Instruktora";
            this.btnIzbrisiInstruktora.UseVisualStyleBackColor = true;
            this.btnIzbrisiInstruktora.Click += new System.EventHandler(this.btnIzbrisiInstruktora_Click);
            // 
            // dataGridInstruktori
            // 
            this.dataGridInstruktori.AllowUserToAddRows = false;
            this.dataGridInstruktori.AllowUserToDeleteRows = false;
            this.dataGridInstruktori.AllowUserToOrderColumns = true;
            this.dataGridInstruktori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridInstruktori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridInstruktori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridInstruktori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInstruktori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdPolaznik,
            this.txtIme,
            this.txtPrezime,
            this.cbKategorija});
            this.dataGridInstruktori.Location = new System.Drawing.Point(4, 84);
            this.dataGridInstruktori.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridInstruktori.Name = "dataGridInstruktori";
            this.dataGridInstruktori.RowHeadersWidth = 51;
            this.dataGridInstruktori.RowTemplate.Height = 24;
            this.dataGridInstruktori.Size = new System.Drawing.Size(954, 454);
            this.dataGridInstruktori.TabIndex = 6;
            this.dataGridInstruktori.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInstruktori_CellValueChanged);
            this.dataGridInstruktori.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridInstruktori_MouseDoubleClick);
            // 
            // txtIdPolaznik
            // 
            this.txtIdPolaznik.DataPropertyName = "IdInstruktora";
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
            // cbKategorija
            // 
            this.cbKategorija.DataPropertyName = "Kategorija";
            this.cbKategorija.HeaderText = "Kategorija";
            this.cbKategorija.MinimumWidth = 6;
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbKategorija.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblInstruktori
            // 
            this.lblInstruktori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInstruktori.AutoSize = true;
            this.lblInstruktori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInstruktori.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruktori.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInstruktori.Location = new System.Drawing.Point(54, 25);
            this.lblInstruktori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstruktori.Name = "lblInstruktori";
            this.lblInstruktori.Size = new System.Drawing.Size(154, 40);
            this.lblInstruktori.TabIndex = 5;
            this.lblInstruktori.Text = "Instruktori";
            // 
            // UCInstruktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnPretraziInstruktora);
            this.Controls.Add(this.btnIzbrisiInstruktora);
            this.Controls.Add(this.dataGridInstruktori);
            this.Controls.Add(this.lblInstruktori);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCInstruktor";
            this.Size = new System.Drawing.Size(962, 621);
            this.Load += new System.EventHandler(this.UCInstruktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInstruktori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPretraziInstruktora;
        private System.Windows.Forms.Button btnIzbrisiInstruktora;
        private System.Windows.Forms.DataGridView dataGridInstruktori;
        private System.Windows.Forms.Label lblInstruktori;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdPolaznik;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrezime;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbKategorija;
    }
}
