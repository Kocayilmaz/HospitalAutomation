namespace HastaneOtomasyon.Forms
{
    partial class HastaEkleForm
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
            this.textBoxHastaEposta = new System.Windows.Forms.TextBox();
            this.textBoxHastaCinsiyet = new System.Windows.Forms.TextBox();
            this.listBoxKanGrup = new System.Windows.Forms.ListBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.dateTimePickerDogum = new System.Windows.Forms.DateTimePicker();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxHastaKanGrup = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.textBoxHastaDogumTarihi = new System.Windows.Forms.TextBox();
            this.textBoxHastaAdresi = new System.Windows.Forms.TextBox();
            this.textBoxHastaCepTelefon = new System.Windows.Forms.TextBox();
            this.textBoxHastaBabaAd = new System.Windows.Forms.TextBox();
            this.textBoxHastaAnneAd = new System.Windows.Forms.TextBox();
            this.textBoxHastaAd = new System.Windows.Forms.TextBox();
            this.textBoxHastaTC = new System.Windows.Forms.TextBox();
            this.textBoxHastaSoyad = new System.Windows.Forms.TextBox();
            this.dataGridViewHasta = new System.Windows.Forms.DataGridView();
            this.textBoxTCArama = new System.Windows.Forms.TextBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonYenile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxHastaEposta);
            this.groupBox1.Controls.Add(this.textBoxHastaCinsiyet);
            this.groupBox1.Controls.Add(this.listBoxKanGrup);
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.dateTimePickerDogum);
            this.groupBox1.Controls.Add(this.buttonEkle);
            this.groupBox1.Controls.Add(this.textBoxHastaKanGrup);
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.textBoxHastaDogumTarihi);
            this.groupBox1.Controls.Add(this.textBoxHastaAdresi);
            this.groupBox1.Controls.Add(this.textBoxHastaCepTelefon);
            this.groupBox1.Controls.Add(this.textBoxHastaBabaAd);
            this.groupBox1.Controls.Add(this.textBoxHastaAnneAd);
            this.groupBox1.Controls.Add(this.textBoxHastaAd);
            this.groupBox1.Controls.Add(this.textBoxHastaTC);
            this.groupBox1.Controls.Add(this.textBoxHastaSoyad);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 440);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta İşlemleri";
            // 
            // textBoxHastaEposta
            // 
            this.textBoxHastaEposta.Location = new System.Drawing.Point(234, 104);
            this.textBoxHastaEposta.Name = "textBoxHastaEposta";
            this.textBoxHastaEposta.PlaceholderText = "Hasta E-Posta";
            this.textBoxHastaEposta.Size = new System.Drawing.Size(192, 27);
            this.textBoxHastaEposta.TabIndex = 21;
            this.textBoxHastaEposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHastaCinsiyet
            // 
            this.textBoxHastaCinsiyet.Location = new System.Drawing.Point(234, 71);
            this.textBoxHastaCinsiyet.MaxLength = 1;
            this.textBoxHastaCinsiyet.Name = "textBoxHastaCinsiyet";
            this.textBoxHastaCinsiyet.PlaceholderText = "Hasta Cinsiyeti";
            this.textBoxHastaCinsiyet.Size = new System.Drawing.Size(192, 27);
            this.textBoxHastaCinsiyet.TabIndex = 0;
            this.textBoxHastaCinsiyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHastaCinsiyet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHastaCinsiyet_KeyPress);
            // 
            // listBoxKanGrup
            // 
            this.listBoxKanGrup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxKanGrup.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxKanGrup.ForeColor = System.Drawing.Color.Indigo;
            this.listBoxKanGrup.FormattingEnabled = true;
            this.listBoxKanGrup.ItemHeight = 19;
            this.listBoxKanGrup.Items.AddRange(new object[] {
            "A+",
            "B+",
            "A-",
            "B-",
            "0-",
            "0+",
            "AB-",
            "AB+"});
            this.listBoxKanGrup.Location = new System.Drawing.Point(234, 170);
            this.listBoxKanGrup.Name = "listBoxKanGrup";
            this.listBoxKanGrup.Size = new System.Drawing.Size(192, 192);
            this.listBoxKanGrup.TabIndex = 15;
            this.listBoxKanGrup.SelectedIndexChanged += new System.EventHandler(this.listBoxKanGrup_SelectedIndexChanged);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.Indigo;
            this.buttonGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuncelle.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGuncelle.ForeColor = System.Drawing.Color.White;
            this.buttonGuncelle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGuncelle.Location = new System.Drawing.Point(464, 216);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(192, 51);
            this.buttonGuncelle.TabIndex = 20;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // dateTimePickerDogum
            // 
            this.dateTimePickerDogum.CalendarFont = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDogum.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDogum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDogum.Location = new System.Drawing.Point(234, 38);
            this.dateTimePickerDogum.MaxDate = new System.DateTime(2023, 1, 9, 0, 0, 0, 0);
            this.dateTimePickerDogum.Name = "dateTimePickerDogum";
            this.dateTimePickerDogum.Size = new System.Drawing.Size(192, 27);
            this.dateTimePickerDogum.TabIndex = 19;
            this.dateTimePickerDogum.Value = new System.DateTime(2023, 1, 6, 0, 0, 0, 0);
            this.dateTimePickerDogum.ValueChanged += new System.EventHandler(this.dateTimePickerDogum_ValueChanged);
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Indigo;
            this.buttonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEkle.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEkle.ForeColor = System.Drawing.Color.White;
            this.buttonEkle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEkle.Location = new System.Drawing.Point(464, 88);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(192, 51);
            this.buttonEkle.TabIndex = 7;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxHastaKanGrup
            // 
            this.textBoxHastaKanGrup.Location = new System.Drawing.Point(234, 137);
            this.textBoxHastaKanGrup.MaxLength = 3;
            this.textBoxHastaKanGrup.Name = "textBoxHastaKanGrup";
            this.textBoxHastaKanGrup.PlaceholderText = "Hasta Kan Grubu";
            this.textBoxHastaKanGrup.Size = new System.Drawing.Size(192, 27);
            this.textBoxHastaKanGrup.TabIndex = 17;
            this.textBoxHastaKanGrup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Indigo;
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSil.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSil.ForeColor = System.Drawing.Color.White;
            this.buttonSil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSil.Location = new System.Drawing.Point(464, 154);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(192, 51);
            this.buttonSil.TabIndex = 16;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // textBoxHastaDogumTarihi
            // 
            this.textBoxHastaDogumTarihi.Location = new System.Drawing.Point(464, 41);
            this.textBoxHastaDogumTarihi.Name = "textBoxHastaDogumTarihi";
            this.textBoxHastaDogumTarihi.PlaceholderText = "Hasta Doğum Tarihi";
            this.textBoxHastaDogumTarihi.Size = new System.Drawing.Size(192, 27);
            this.textBoxHastaDogumTarihi.TabIndex = 14;
            this.textBoxHastaDogumTarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHastaDogumTarihi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHastaDogumTarihi_KeyPress);
            // 
            // textBoxHastaAdresi
            // 
            this.textBoxHastaAdresi.AllowDrop = true;
            this.textBoxHastaAdresi.Location = new System.Drawing.Point(15, 236);
            this.textBoxHastaAdresi.Multiline = true;
            this.textBoxHastaAdresi.Name = "textBoxHastaAdresi";
            this.textBoxHastaAdresi.PlaceholderText = "Hasta Adresi";
            this.textBoxHastaAdresi.Size = new System.Drawing.Size(192, 184);
            this.textBoxHastaAdresi.TabIndex = 13;
            this.textBoxHastaAdresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHastaCepTelefon
            // 
            this.textBoxHastaCepTelefon.Location = new System.Drawing.Point(15, 203);
            this.textBoxHastaCepTelefon.MaxLength = 10;
            this.textBoxHastaCepTelefon.Name = "textBoxHastaCepTelefon";
            this.textBoxHastaCepTelefon.PlaceholderText = "Hasta Cep Telefonu Numarası";
            this.textBoxHastaCepTelefon.Size = new System.Drawing.Size(192, 27);
            this.textBoxHastaCepTelefon.TabIndex = 11;
            this.textBoxHastaCepTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHastaCepTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHastaCepTelefon_KeyPress);
            // 
            // textBoxHastaBabaAd
            // 
            this.textBoxHastaBabaAd.Location = new System.Drawing.Point(15, 170);
            this.textBoxHastaBabaAd.Name = "textBoxHastaBabaAd";
            this.textBoxHastaBabaAd.PlaceholderText = "Hasta Baba Adı";
            this.textBoxHastaBabaAd.Size = new System.Drawing.Size(192, 27);
            this.textBoxHastaBabaAd.TabIndex = 10;
            this.textBoxHastaBabaAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHastaAnneAd
            // 
            this.textBoxHastaAnneAd.Location = new System.Drawing.Point(15, 137);
            this.textBoxHastaAnneAd.Name = "textBoxHastaAnneAd";
            this.textBoxHastaAnneAd.PlaceholderText = "Hasta Anne Adı";
            this.textBoxHastaAnneAd.Size = new System.Drawing.Size(192, 27);
            this.textBoxHastaAnneAd.TabIndex = 9;
            this.textBoxHastaAnneAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHastaAd
            // 
            this.textBoxHastaAd.Location = new System.Drawing.Point(15, 71);
            this.textBoxHastaAd.Name = "textBoxHastaAd";
            this.textBoxHastaAd.PlaceholderText = "Hasta Adı";
            this.textBoxHastaAd.Size = new System.Drawing.Size(192, 27);
            this.textBoxHastaAd.TabIndex = 4;
            this.textBoxHastaAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHastaTC
            // 
            this.textBoxHastaTC.Location = new System.Drawing.Point(15, 38);
            this.textBoxHastaTC.MaxLength = 11;
            this.textBoxHastaTC.Name = "textBoxHastaTC";
            this.textBoxHastaTC.PlaceholderText = "HastaTC";
            this.textBoxHastaTC.Size = new System.Drawing.Size(192, 27);
            this.textBoxHastaTC.TabIndex = 0;
            this.textBoxHastaTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHastaTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHastaTC_KeyPress);
            // 
            // textBoxHastaSoyad
            // 
            this.textBoxHastaSoyad.Location = new System.Drawing.Point(15, 104);
            this.textBoxHastaSoyad.Name = "textBoxHastaSoyad";
            this.textBoxHastaSoyad.PlaceholderText = "Hasta Soyadı";
            this.textBoxHastaSoyad.Size = new System.Drawing.Size(192, 27);
            this.textBoxHastaSoyad.TabIndex = 2;
            this.textBoxHastaSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewHasta
            // 
            this.dataGridViewHasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHasta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasta.Location = new System.Drawing.Point(766, 61);
            this.dataGridViewHasta.Name = "dataGridViewHasta";
            this.dataGridViewHasta.RowTemplate.Height = 25;
            this.dataGridViewHasta.Size = new System.Drawing.Size(831, 430);
            this.dataGridViewHasta.TabIndex = 10;
            this.dataGridViewHasta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHasta_CellClick);
            // 
            // textBoxTCArama
            // 
            this.textBoxTCArama.Location = new System.Drawing.Point(766, 33);
            this.textBoxTCArama.MaxLength = 11;
            this.textBoxTCArama.Name = "textBoxTCArama";
            this.textBoxTCArama.PlaceholderText = "TC Girin";
            this.textBoxTCArama.Size = new System.Drawing.Size(152, 23);
            this.textBoxTCArama.TabIndex = 11;
            this.textBoxTCArama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(924, 33);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(90, 23);
            this.buttonAra.TabIndex = 13;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonYenile
            // 
            this.buttonYenile.Location = new System.Drawing.Point(1020, 33);
            this.buttonYenile.Name = "buttonYenile";
            this.buttonYenile.Size = new System.Drawing.Size(90, 23);
            this.buttonYenile.TabIndex = 14;
            this.buttonYenile.Text = "Yenile";
            this.buttonYenile.UseVisualStyleBackColor = true;
            this.buttonYenile.Click += new System.EventHandler(this.buttonYenile_Click);
            // 
            // HastaEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 557);
            this.Controls.Add(this.buttonYenile);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.textBoxTCArama);
            this.Controls.Add(this.dataGridViewHasta);
            this.Controls.Add(this.groupBox1);
            this.Name = "HastaEkleForm";
            this.Text = "Hasta Ekle";
            this.Load += new System.EventHandler(this.HastaEkleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonEkle;
        private TextBox textBoxHastaAd;
        private TextBox textBoxHastaTC;
        private TextBox textBoxHastaSoyad;
        private TextBox textBoxHastaBabaAd;
        private TextBox textBoxHastaAnneAd;
        private TextBox textBoxHastaCepTelefon;
        private TextBox textBoxHastaDogumTarihi;
        private TextBox textBoxHastaAdresi;
        private ListBox listBoxKanGrup;
        private TextBox textBoxHastaKanGrup;
        private Button buttonSil;
        private DateTimePicker dateTimePickerDogum;
        private DataGridView dataGridViewHasta;
        private Button buttonGuncelle;
        private TextBox textBoxHastaCinsiyet;
        private TextBox textBoxHastaEposta;
        private TextBox textBoxTCArama;
        private Button buttonAra;
        private Button buttonYenile;
    }
}