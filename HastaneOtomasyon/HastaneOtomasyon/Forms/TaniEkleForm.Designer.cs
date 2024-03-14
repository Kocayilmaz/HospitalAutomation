namespace HastaneOtomasyon.Forms
{
    partial class TaniEkleForm
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
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.dataGridViewRandevu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTani = new System.Windows.Forms.DataGridView();
            this.textBoxHastaAdi = new System.Windows.Forms.TextBox();
            this.textBoxHastaTC = new System.Windows.Forms.TextBox();
            this.textBoxTaniAciklama = new System.Windows.Forms.TextBox();
            this.textBoxTaniAdi = new System.Windows.Forms.TextBox();
            this.textBoxHastaSoyadi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxLabID = new System.Windows.Forms.TextBox();
            this.textBoxHastaID = new System.Windows.Forms.TextBox();
            this.labelRandevular = new System.Windows.Forms.Label();
            this.labelTanilar = new System.Windows.Forms.Label();
            this.buttonTestIste = new System.Windows.Forms.Button();
            this.buttonTestSonucGor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTani)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.Indigo;
            this.buttonGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuncelle.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGuncelle.ForeColor = System.Drawing.Color.White;
            this.buttonGuncelle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGuncelle.Location = new System.Drawing.Point(42, 497);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(192, 51);
            this.buttonGuncelle.TabIndex = 12;
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
            this.buttonSil.Location = new System.Drawing.Point(42, 440);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(192, 51);
            this.buttonSil.TabIndex = 11;
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
            this.buttonEkle.Location = new System.Drawing.Point(42, 383);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(192, 51);
            this.buttonEkle.TabIndex = 10;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // dataGridViewRandevu
            // 
            this.dataGridViewRandevu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRandevu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRandevu.Location = new System.Drawing.Point(42, 52);
            this.dataGridViewRandevu.Name = "dataGridViewRandevu";
            this.dataGridViewRandevu.RowTemplate.Height = 25;
            this.dataGridViewRandevu.Size = new System.Drawing.Size(567, 307);
            this.dataGridViewRandevu.TabIndex = 13;
            this.dataGridViewRandevu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRandevu_CellClick);
            // 
            // dataGridViewTani
            // 
            this.dataGridViewTani.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTani.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTani.Location = new System.Drawing.Point(626, 52);
            this.dataGridViewTani.Name = "dataGridViewTani";
            this.dataGridViewTani.RowTemplate.Height = 25;
            this.dataGridViewTani.Size = new System.Drawing.Size(576, 307);
            this.dataGridViewTani.TabIndex = 14;
            this.dataGridViewTani.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTani_CellClick);
            // 
            // textBoxHastaAdi
            // 
            this.textBoxHastaAdi.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHastaAdi.Location = new System.Drawing.Point(22, 96);
            this.textBoxHastaAdi.Name = "textBoxHastaAdi";
            this.textBoxHastaAdi.PlaceholderText = "Hasta Adı";
            this.textBoxHastaAdi.Size = new System.Drawing.Size(209, 27);
            this.textBoxHastaAdi.TabIndex = 15;
            this.textBoxHastaAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHastaTC
            // 
            this.textBoxHastaTC.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHastaTC.Location = new System.Drawing.Point(22, 162);
            this.textBoxHastaTC.Name = "textBoxHastaTC";
            this.textBoxHastaTC.PlaceholderText = "Hasta TC";
            this.textBoxHastaTC.Size = new System.Drawing.Size(209, 27);
            this.textBoxHastaTC.TabIndex = 16;
            this.textBoxHastaTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTaniAciklama
            // 
            this.textBoxTaniAciklama.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTaniAciklama.Location = new System.Drawing.Point(6, 65);
            this.textBoxTaniAciklama.Multiline = true;
            this.textBoxTaniAciklama.Name = "textBoxTaniAciklama";
            this.textBoxTaniAciklama.PlaceholderText = "Tanı Açıklama";
            this.textBoxTaniAciklama.Size = new System.Drawing.Size(555, 114);
            this.textBoxTaniAciklama.TabIndex = 17;
            // 
            // textBoxTaniAdi
            // 
            this.textBoxTaniAdi.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTaniAdi.Location = new System.Drawing.Point(6, 26);
            this.textBoxTaniAdi.Name = "textBoxTaniAdi";
            this.textBoxTaniAdi.PlaceholderText = "Tanı Adı";
            this.textBoxTaniAdi.Size = new System.Drawing.Size(186, 27);
            this.textBoxTaniAdi.TabIndex = 18;
            // 
            // textBoxHastaSoyadi
            // 
            this.textBoxHastaSoyadi.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHastaSoyadi.Location = new System.Drawing.Point(22, 129);
            this.textBoxHastaSoyadi.Name = "textBoxHastaSoyadi";
            this.textBoxHastaSoyadi.PlaceholderText = "Hasta Soyadi";
            this.textBoxHastaSoyadi.Size = new System.Drawing.Size(209, 27);
            this.textBoxHastaSoyadi.TabIndex = 19;
            this.textBoxHastaSoyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTaniAdi);
            this.groupBox1.Controls.Add(this.textBoxTaniAciklama);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(626, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 195);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tanı İşlemleri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxLabID);
            this.groupBox2.Controls.Add(this.textBoxHastaID);
            this.groupBox2.Controls.Add(this.textBoxHastaAdi);
            this.groupBox2.Controls.Add(this.textBoxHastaTC);
            this.groupBox2.Controls.Add(this.textBoxHastaSoyadi);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(256, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 195);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Bilgileri";
            // 
            // textBoxLabID
            // 
            this.textBoxLabID.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLabID.Location = new System.Drawing.Point(103, 63);
            this.textBoxLabID.Name = "textBoxLabID";
            this.textBoxLabID.PlaceholderText = "LabID";
            this.textBoxLabID.Size = new System.Drawing.Size(44, 27);
            this.textBoxLabID.TabIndex = 21;
            this.textBoxLabID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHastaID
            // 
            this.textBoxHastaID.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHastaID.Location = new System.Drawing.Point(103, 26);
            this.textBoxHastaID.Name = "textBoxHastaID";
            this.textBoxHastaID.PlaceholderText = "ID";
            this.textBoxHastaID.Size = new System.Drawing.Size(44, 27);
            this.textBoxHastaID.TabIndex = 20;
            this.textBoxHastaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRandevular
            // 
            this.labelRandevular.AutoSize = true;
            this.labelRandevular.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRandevular.Location = new System.Drawing.Point(241, 9);
            this.labelRandevular.Name = "labelRandevular";
            this.labelRandevular.Size = new System.Drawing.Size(83, 23);
            this.labelRandevular.TabIndex = 22;
            this.labelRandevular.Text = "Randevular";
            // 
            // labelTanilar
            // 
            this.labelTanilar.AutoSize = true;
            this.labelTanilar.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTanilar.Location = new System.Drawing.Point(887, 9);
            this.labelTanilar.Name = "labelTanilar";
            this.labelTanilar.Size = new System.Drawing.Size(54, 23);
            this.labelTanilar.TabIndex = 23;
            this.labelTanilar.Text = "Tanılar";
            // 
            // buttonTestIste
            // 
            this.buttonTestIste.BackColor = System.Drawing.Color.Indigo;
            this.buttonTestIste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTestIste.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTestIste.ForeColor = System.Drawing.Color.White;
            this.buttonTestIste.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonTestIste.Location = new System.Drawing.Point(42, 554);
            this.buttonTestIste.Name = "buttonTestIste";
            this.buttonTestIste.Size = new System.Drawing.Size(192, 51);
            this.buttonTestIste.TabIndex = 24;
            this.buttonTestIste.Text = "Test İste";
            this.buttonTestIste.UseVisualStyleBackColor = false;
            this.buttonTestIste.Click += new System.EventHandler(this.buttonTestIste_Click);
            // 
            // buttonTestSonucGor
            // 
            this.buttonTestSonucGor.BackColor = System.Drawing.Color.Indigo;
            this.buttonTestSonucGor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTestSonucGor.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTestSonucGor.ForeColor = System.Drawing.Color.White;
            this.buttonTestSonucGor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonTestSonucGor.Location = new System.Drawing.Point(42, 611);
            this.buttonTestSonucGor.Name = "buttonTestSonucGor";
            this.buttonTestSonucGor.Size = new System.Drawing.Size(192, 51);
            this.buttonTestSonucGor.TabIndex = 25;
            this.buttonTestSonucGor.Text = "Test Sonuçlarını Gör";
            this.buttonTestSonucGor.UseVisualStyleBackColor = false;
            this.buttonTestSonucGor.Click += new System.EventHandler(this.buttonTestSonucGor_Click);
            // 
            // TaniEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 691);
            this.Controls.Add(this.buttonTestSonucGor);
            this.Controls.Add(this.buttonTestIste);
            this.Controls.Add(this.labelTanilar);
            this.Controls.Add(this.labelRandevular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewTani);
            this.Controls.Add(this.dataGridViewRandevu);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Name = "TaniEkleForm";
            this.Text = "Tanı Ekle";
            this.Load += new System.EventHandler(this.TaniEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTani)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonGuncelle;
        private Button buttonSil;
        private Button buttonEkle;
        private DataGridView dataGridViewRandevu;
        private DataGridView dataGridViewTani;
        private TextBox textBoxHastaAdi;
        private TextBox textBoxHastaTC;
        private TextBox textBoxTaniAciklama;
        private TextBox textBoxTaniAdi;
        private TextBox textBoxHastaSoyadi;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxHastaID;
        private Label labelRandevular;
        private Label labelTanilar;
        private Button buttonTestIste;
        private TextBox textBoxLabID;
        private Button buttonTestSonucGor;
    }
}