namespace HastaneOtomasyon.Forms
{
    partial class KlinikEkleForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxKlinikAdi = new System.Windows.Forms.TextBox();
            this.dataGridViewKlinik = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlinik)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.buttonEkle);
            this.groupBox1.Controls.Add(this.textBoxKlinikAdi);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(42, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 423);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klinik İşlemleri";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.Indigo;
            this.buttonGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuncelle.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGuncelle.ForeColor = System.Drawing.Color.White;
            this.buttonGuncelle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGuncelle.Location = new System.Drawing.Point(6, 258);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(192, 51);
            this.buttonGuncelle.TabIndex = 9;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Indigo;
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSil.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSil.ForeColor = System.Drawing.Color.White;
            this.buttonSil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSil.Location = new System.Drawing.Point(6, 201);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(192, 51);
            this.buttonSil.TabIndex = 8;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Indigo;
            this.buttonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEkle.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEkle.ForeColor = System.Drawing.Color.White;
            this.buttonEkle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEkle.Location = new System.Drawing.Point(6, 144);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(192, 51);
            this.buttonEkle.TabIndex = 7;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxKlinikAdi
            // 
            this.textBoxKlinikAdi.Location = new System.Drawing.Point(6, 52);
            this.textBoxKlinikAdi.Name = "textBoxKlinikAdi";
            this.textBoxKlinikAdi.PlaceholderText = "Klinik Adı";
            this.textBoxKlinikAdi.Size = new System.Drawing.Size(192, 27);
            this.textBoxKlinikAdi.TabIndex = 4;
            this.textBoxKlinikAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewKlinik
            // 
            this.dataGridViewKlinik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKlinik.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewKlinik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlinik.Location = new System.Drawing.Point(279, 40);
            this.dataGridViewKlinik.Name = "dataGridViewKlinik";
            this.dataGridViewKlinik.RowHeadersWidth = 62;
            this.dataGridViewKlinik.RowTemplate.Height = 25;
            this.dataGridViewKlinik.Size = new System.Drawing.Size(677, 423);
            this.dataGridViewKlinik.TabIndex = 8;
            this.dataGridViewKlinik.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKlinik_CellClick);
            // 
            // KlinikEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewKlinik);
            this.Name = "KlinikEkleForm";
            this.Text = "Klinik Ekle ";
            this.Load += new System.EventHandler(this.KlinikEkleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlinik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonSil;
        private Button buttonEkle;
        private TextBox textBoxKlinikAdi;
        private DataGridView dataGridViewKlinik;
        private Button buttonGuncelle;
    }
}