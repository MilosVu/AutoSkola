
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCGrupaZaPolaganje));
            this.dataGridGrupeZaPolaganje = new System.Windows.Forms.DataGridView();
            this.lblGrupeZaPolaganje = new System.Windows.Forms.Label();
            this.btnStrelicaUNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrupeZaPolaganje)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGrupeZaPolaganje
            // 
            this.dataGridGrupeZaPolaganje.AllowUserToAddRows = false;
            this.dataGridGrupeZaPolaganje.AllowUserToDeleteRows = false;
            this.dataGridGrupeZaPolaganje.AllowUserToOrderColumns = true;
            this.dataGridGrupeZaPolaganje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridGrupeZaPolaganje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGrupeZaPolaganje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridGrupeZaPolaganje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGrupeZaPolaganje.Location = new System.Drawing.Point(5, 76);
            this.dataGridGrupeZaPolaganje.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridGrupeZaPolaganje.Name = "dataGridGrupeZaPolaganje";
            this.dataGridGrupeZaPolaganje.ReadOnly = true;
            this.dataGridGrupeZaPolaganje.RowHeadersWidth = 51;
            this.dataGridGrupeZaPolaganje.RowTemplate.Height = 24;
            this.dataGridGrupeZaPolaganje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridGrupeZaPolaganje.Size = new System.Drawing.Size(1213, 454);
            this.dataGridGrupeZaPolaganje.TabIndex = 18;
            this.dataGridGrupeZaPolaganje.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGrupeZaPolaganje_CellDoubleClick);
            // 
            // lblGrupeZaPolaganje
            // 
            this.lblGrupeZaPolaganje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGrupeZaPolaganje.AutoSize = true;
            this.lblGrupeZaPolaganje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblGrupeZaPolaganje.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupeZaPolaganje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGrupeZaPolaganje.Location = new System.Drawing.Point(5, 32);
            this.lblGrupeZaPolaganje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrupeZaPolaganje.Name = "lblGrupeZaPolaganje";
            this.lblGrupeZaPolaganje.Size = new System.Drawing.Size(272, 40);
            this.lblGrupeZaPolaganje.TabIndex = 17;
            this.lblGrupeZaPolaganje.Text = "Grupe za polaganje";
            // 
            // btnStrelicaUNazad
            // 
            this.btnStrelicaUNazad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStrelicaUNazad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStrelicaUNazad.FlatAppearance.BorderSize = 0;
            this.btnStrelicaUNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrelicaUNazad.Image = ((System.Drawing.Image)(resources.GetObject("btnStrelicaUNazad.Image")));
            this.btnStrelicaUNazad.Location = new System.Drawing.Point(1132, 32);
            this.btnStrelicaUNazad.Name = "btnStrelicaUNazad";
            this.btnStrelicaUNazad.Size = new System.Drawing.Size(76, 37);
            this.btnStrelicaUNazad.TabIndex = 19;
            this.btnStrelicaUNazad.UseVisualStyleBackColor = true;
            this.btnStrelicaUNazad.Visible = false;
            this.btnStrelicaUNazad.Click += new System.EventHandler(this.btnStrelicaUNazad_Click);
            // 
            // UCGrupaZaPolaganje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.btnStrelicaUNazad);
            this.Controls.Add(this.dataGridGrupeZaPolaganje);
            this.Controls.Add(this.lblGrupeZaPolaganje);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCGrupaZaPolaganje";
            this.Size = new System.Drawing.Size(1223, 620);
            this.Load += new System.EventHandler(this.UCGrupaZaPolaganje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrupeZaPolaganje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridGrupeZaPolaganje;
        private System.Windows.Forms.Label lblGrupeZaPolaganje;
        private System.Windows.Forms.Button btnStrelicaUNazad;
    }
}
