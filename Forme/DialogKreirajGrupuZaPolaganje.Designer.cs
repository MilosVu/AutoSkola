
namespace Forme
{
    partial class DialogKreirajGrupuZaPolaganje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogKreirajGrupuZaPolaganje));
            this.dataGridPolaznici = new System.Windows.Forms.DataGridView();
            this.lblGrupa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbVrstaIspita = new System.Windows.Forms.ComboBox();
            this.lblVrstaIspita = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.btnDodajGrupuZaPolaganje = new System.Windows.Forms.Button();
            this.IdPolaznika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPolaznici)).BeginInit();
            this.SuspendLayout();
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
            this.IdPolaznika});
            this.dataGridPolaznici.Location = new System.Drawing.Point(64, 85);
            this.dataGridPolaznici.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridPolaznici.Name = "dataGridPolaznici";
            this.dataGridPolaznici.RowHeadersWidth = 51;
            this.dataGridPolaznici.RowTemplate.Height = 24;
            this.dataGridPolaznici.Size = new System.Drawing.Size(954, 454);
            this.dataGridPolaznici.TabIndex = 2;
            // 
            // lblGrupa
            // 
            this.lblGrupa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGrupa.AutoSize = true;
            this.lblGrupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblGrupa.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGrupa.Location = new System.Drawing.Point(57, 16);
            this.lblGrupa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrupa.Name = "lblGrupa";
            this.lblGrupa.Size = new System.Drawing.Size(258, 40);
            this.lblGrupa.TabIndex = 3;
            this.lblGrupa.Text = "Izabrani polaznici:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(64, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 1);
            this.panel1.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.Location = new System.Drawing.Point(175, 562);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(291, 30);
            this.dateTimePicker.TabIndex = 12;
            // 
            // cbVrstaIspita
            // 
            this.cbVrstaIspita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbVrstaIspita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cbVrstaIspita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVrstaIspita.ForeColor = System.Drawing.Color.White;
            this.cbVrstaIspita.FormattingEnabled = true;
            this.cbVrstaIspita.Location = new System.Drawing.Point(175, 607);
            this.cbVrstaIspita.Name = "cbVrstaIspita";
            this.cbVrstaIspita.Size = new System.Drawing.Size(291, 32);
            this.cbVrstaIspita.TabIndex = 11;
            // 
            // lblVrstaIspita
            // 
            this.lblVrstaIspita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVrstaIspita.AutoSize = true;
            this.lblVrstaIspita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblVrstaIspita.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVrstaIspita.Location = new System.Drawing.Point(79, 615);
            this.lblVrstaIspita.Name = "lblVrstaIspita";
            this.lblVrstaIspita.Size = new System.Drawing.Size(90, 24);
            this.lblVrstaIspita.TabIndex = 10;
            this.lblVrstaIspita.Text = "Vrsta ispita";
            this.lblVrstaIspita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDatum
            // 
            this.lblDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblDatum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDatum.Location = new System.Drawing.Point(109, 567);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(60, 24);
            this.lblDatum.TabIndex = 9;
            this.lblDatum.Text = "Datum";
            this.lblDatum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSala
            // 
            this.lblSala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSala.AutoSize = true;
            this.lblSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblSala.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSala.Location = new System.Drawing.Point(127, 664);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(42, 24);
            this.lblSala.TabIndex = 13;
            this.lblSala.Text = "Sala";
            this.lblSala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSala
            // 
            this.txtSala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSala.BackColor = System.Drawing.Color.White;
            this.txtSala.ForeColor = System.Drawing.Color.Black;
            this.txtSala.Location = new System.Drawing.Point(175, 658);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(291, 30);
            this.txtSala.TabIndex = 14;
            // 
            // btnDodajGrupuZaPolaganje
            // 
            this.btnDodajGrupuZaPolaganje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajGrupuZaPolaganje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajGrupuZaPolaganje.FlatAppearance.BorderSize = 0;
            this.btnDodajGrupuZaPolaganje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajGrupuZaPolaganje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajGrupuZaPolaganje.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajGrupuZaPolaganje.Image")));
            this.btnDodajGrupuZaPolaganje.Location = new System.Drawing.Point(939, 567);
            this.btnDodajGrupuZaPolaganje.Name = "btnDodajGrupuZaPolaganje";
            this.btnDodajGrupuZaPolaganje.Size = new System.Drawing.Size(79, 72);
            this.btnDodajGrupuZaPolaganje.TabIndex = 15;
            this.btnDodajGrupuZaPolaganje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajGrupuZaPolaganje.UseVisualStyleBackColor = true;
            this.btnDodajGrupuZaPolaganje.Click += new System.EventHandler(this.btnDodajGrupuZaPolaganje_Click);
            // 
            // IdPolaznika
            // 
            this.IdPolaznika.DataPropertyName = "IdPolaznika";
            this.IdPolaznika.HeaderText = "IdPolaznika";
            this.IdPolaznika.MinimumWidth = 6;
            this.IdPolaznika.Name = "IdPolaznika";
            this.IdPolaznika.Visible = false;
            // 
            // DialogKreirajGrupuZaPolaganje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1094, 741);
            this.Controls.Add(this.btnDodajGrupuZaPolaganje);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cbVrstaIspita);
            this.Controls.Add(this.lblVrstaIspita);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGrupa);
            this.Controls.Add(this.dataGridPolaznici);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DialogKreirajGrupuZaPolaganje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogKreirajGrupuZaPolaganje";
            this.Load += new System.EventHandler(this.DialogKreirajGrupuZaPolaganje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPolaznici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPolaznici;
        private System.Windows.Forms.Label lblGrupa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cbVrstaIspita;
        private System.Windows.Forms.Label lblVrstaIspita;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Button btnDodajGrupuZaPolaganje;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPolaznika;
    }
}