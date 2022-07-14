namespace eProdaja.WinUI
{
    partial class Ispit30062022
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
            this.cmbProizvodi = new System.Windows.Forms.ComboBox();
            this.txtMinimalniIznosNovca = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dgvKupci = new System.Windows.Forms.DataGridView();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupci)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProizvodi
            // 
            this.cmbProizvodi.FormattingEnabled = true;
            this.cmbProizvodi.Location = new System.Drawing.Point(12, 12);
            this.cmbProizvodi.Name = "cmbProizvodi";
            this.cmbProizvodi.Size = new System.Drawing.Size(151, 28);
            this.cmbProizvodi.TabIndex = 0;
            // 
            // txtMinimalniIznosNovca
            // 
            this.txtMinimalniIznosNovca.Location = new System.Drawing.Point(12, 46);
            this.txtMinimalniIznosNovca.Name = "txtMinimalniIznosNovca";
            this.txtMinimalniIznosNovca.Size = new System.Drawing.Size(125, 27);
            this.txtMinimalniIznosNovca.TabIndex = 1;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(12, 79);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(94, 29);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "button1";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dgvKupci
            // 
            this.dgvKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKupci.Location = new System.Drawing.Point(12, 114);
            this.dgvKupci.Name = "dgvKupci";
            this.dgvKupci.RowHeadersWidth = 51;
            this.dgvKupci.RowTemplate.Height = 29;
            this.dgvKupci.Size = new System.Drawing.Size(776, 289);
            this.dgvKupci.TabIndex = 3;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(12, 409);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(94, 29);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "button2";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // Ispit30062022
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dgvKupci);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtMinimalniIznosNovca);
            this.Controls.Add(this.cmbProizvodi);
            this.Name = "Ispit30062022";
            this.Text = "Ispit30062022";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbProizvodi;
        private TextBox txtMinimalniIznosNovca;
        private Button btnPretraga;
        private DataGridView dgvKupci;
        private Button btnSacuvaj;
    }
}