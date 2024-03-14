namespace HastaneOtomasyon.Forms
{
    partial class DoktorEkleForm
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
            this.dataGridViewDoktor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDogum = new System.Windows.Forms.DateTimePicker();
            this.comboBoxKlinikID = new System.Windows.Forms.ComboBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxDoktorID = new System.Windows.Forms.TextBox();
            this.textBoxDoktorTC = new System.Windows.Forms.TextBox();
            this.textBoxDoktorDogumTarihi = new System.Windows.Forms.TextBox();
            this.textBoxDoktorCinsiyet = new System.Windows.Forms.TextBox();
            this.textBoxDoktorSoyad = new System.Windows.Forms.TextBox();
            this.textBoxDoktorAdi = new System.Windows.Forms.TextBox();
            this.textBoxArama = new System.Windows.Forms.TextBox();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDoktor
            // 
            this.dataGridViewDoktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoktor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoktor.Location = new System.Drawing.Point(358, 100);
            this.dataGridViewDoktor.Name = "dataGridViewDoktor";
            this.dataGridViewDoktor.RowTemplate.Height = 25;
            this.dataGridViewDoktor.Size = new System.Drawing.Size(870, 439);
            this.dataGridViewDoktor.TabIndex = 0;
            this.dataGridViewDoktor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoktor_CellClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerDogum);
            this.groupBox1.Controls.Add(this.comboBoxKlinikID);
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.buttonEkle);
            this.groupBox1.Controls.Add(this.textBoxDoktorID);
            this.groupBox1.Controls.Add(this.textBoxDoktorTC);
            this.groupBox1.Controls.Add(this.textBoxDoktorDogumTarihi);
            this.groupBox1.Controls.Add(this.textBoxDoktorCinsiyet);
            this.groupBox1.Controls.Add(this.textBoxDoktorSoyad);
            this.groupBox1.Controls.Add(this.textBoxDoktorAdi);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(53, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 555);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor İşlemleri";
            // 
            // dateTimePickerDogum
            // 
            this.dateTimePickerDogum.CalendarFont = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDogum.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDogum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDogum.Location = new System.Drawing.Point(16, 205);
            this.dateTimePickerDogum.MaxDate = new System.DateTime(2023, 1, 6, 0, 0, 0, 0);
            this.dateTimePickerDogum.Name = "dateTimePickerDogum";
            this.dateTimePickerDogum.Size = new System.Drawing.Size(192, 27);
            this.dateTimePickerDogum.TabIndex = 20;
            this.dateTimePickerDogum.Value = new System.DateTime(2023, 1, 6, 0, 0, 0, 0);
            this.dateTimePickerDogum.ValueChanged += new System.EventHandler(this.dateTimePickerDogum_ValueChanged);
            // 
            // comboBoxKlinikID
            // 
            this.comboBoxKlinikID.FormattingEnabled = true;
            this.comboBoxKlinikID.Location = new System.Drawing.Point(16, 334);
            this.comboBoxKlinikID.Name = "comboBoxKlinikID";
            this.comboBoxKlinikID.Size = new System.Drawing.Size(192, 27);
            this.comboBoxKlinikID.TabIndex = 12;
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.Indigo;
            this.buttonGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuncelle.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGuncelle.ForeColor = System.Drawing.Color.White;
            this.buttonGuncelle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGuncelle.Location = new System.Drawing.Point(16, 491);
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
            this.buttonSil.Location = new System.Drawing.Point(16, 434);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(192, 51);
            this.buttonSil.TabIndex = 9;
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
            this.buttonEkle.Location = new System.Drawing.Point(16, 377);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(192, 51);
            this.buttonEkle.TabIndex = 8;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxDoktorID
            // 
            this.textBoxDoktorID.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDoktorID.Location = new System.Drawing.Point(16, 34);
            this.textBoxDoktorID.Name = "textBoxDoktorID";
            this.textBoxDoktorID.PlaceholderText = "ID";
            this.textBoxDoktorID.Size = new System.Drawing.Size(39, 27);
            this.textBoxDoktorID.TabIndex = 5;
            this.textBoxDoktorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDoktorTC
            // 
            this.textBoxDoktorTC.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDoktorTC.Location = new System.Drawing.Point(16, 290);
            this.textBoxDoktorTC.MaxLength = 11;
            this.textBoxDoktorTC.Name = "textBoxDoktorTC";
            this.textBoxDoktorTC.PlaceholderText = "TC";
            this.textBoxDoktorTC.Size = new System.Drawing.Size(192, 27);
            this.textBoxDoktorTC.TabIndex = 5;
            this.textBoxDoktorTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDoktorTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDoktorTC_KeyPress);
            // 
            // textBoxDoktorDogumTarihi
            // 
            this.textBoxDoktorDogumTarihi.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDoktorDogumTarihi.Location = new System.Drawing.Point(16, 248);
            this.textBoxDoktorDogumTarihi.Name = "textBoxDoktorDogumTarihi";
            this.textBoxDoktorDogumTarihi.PlaceholderText = "Doğum Tarihi";
            this.textBoxDoktorDogumTarihi.Size = new System.Drawing.Size(192, 27);
            this.textBoxDoktorDogumTarihi.TabIndex = 5;
            this.textBoxDoktorDogumTarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDoktorDogumTarihi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDoktorDogumTarihi_KeyPress);
            // 
            // textBoxDoktorCinsiyet
            // 
            this.textBoxDoktorCinsiyet.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDoktorCinsiyet.Location = new System.Drawing.Point(16, 154);
            this.textBoxDoktorCinsiyet.Name = "textBoxDoktorCinsiyet";
            this.textBoxDoktorCinsiyet.PlaceholderText = "Cinsiyet";
            this.textBoxDoktorCinsiyet.Size = new System.Drawing.Size(192, 27);
            this.textBoxDoktorCinsiyet.TabIndex = 5;
            this.textBoxDoktorCinsiyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDoktorCinsiyet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDoktorCinsiyet_KeyPress);
            // 
            // textBoxDoktorSoyad
            // 
            this.textBoxDoktorSoyad.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDoktorSoyad.Location = new System.Drawing.Point(16, 112);
            this.textBoxDoktorSoyad.Name = "textBoxDoktorSoyad";
            this.textBoxDoktorSoyad.PlaceholderText = "Doktor Soyadı";
            this.textBoxDoktorSoyad.Size = new System.Drawing.Size(192, 27);
            this.textBoxDoktorSoyad.TabIndex = 5;
            this.textBoxDoktorSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDoktorAdi
            // 
            this.textBoxDoktorAdi.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDoktorAdi.Location = new System.Drawing.Point(16, 73);
            this.textBoxDoktorAdi.Name = "textBoxDoktorAdi";
            this.textBoxDoktorAdi.PlaceholderText = "Doktor Adı";
            this.textBoxDoktorAdi.Size = new System.Drawing.Size(192, 27);
            this.textBoxDoktorAdi.TabIndex = 5;
            this.textBoxDoktorAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxArama
            // 
            this.textBoxArama.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxArama.Location = new System.Drawing.Point(358, 70);
            this.textBoxArama.Name = "textBoxArama";
            this.textBoxArama.Size = new System.Drawing.Size(205, 27);
            this.textBoxArama.TabIndex = 10;
            this.textBoxArama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Items.AddRange(new object[] {
            "Ad\'a Göre",
            "Soyad\'a Göre",
            "Cinsiyet\' Göre",
            "TC\'ye Göre"});
            this.comboBoxDoktor.Location = new System.Drawing.Point(358, 41);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(138, 23);
            this.comboBoxDoktor.TabIndex = 11;
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(569, 74);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(95, 23);
            this.buttonAra.TabIndex = 12;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonYenile
            // 
            this.buttonYenile.Location = new System.Drawing.Point(670, 74);
            this.buttonYenile.Name = "buttonYenile";
            this.buttonYenile.Size = new System.Drawing.Size(95, 23);
            this.buttonYenile.TabIndex = 15;
            this.buttonYenile.Text = "Yenile";
            this.buttonYenile.UseVisualStyleBackColor = true;
            this.buttonYenile.Click += new System.EventHandler(this.buttonYenile_Click);
            // 
            // DoktorEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 594);
            this.Controls.Add(this.buttonYenile);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.comboBoxDoktor);
            this.Controls.Add(this.textBoxArama);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewDoktor);
            this.Name = "DoktorEkleForm";
            this.Text = "DoktorEkleForm";
            this.Load += new System.EventHandler(this.DoktorEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewDoktor;
        private GroupBox groupBox1;
        private TextBox textBoxDoktorAdi;
        private TextBox textBoxDoktorSoyad;
        private TextBox textBoxDoktorDogumTarihi;
        private TextBox textBoxDoktorCinsiyet;
        private TextBox textBoxDoktorTC;
        private TextBox textBoxDoktorID;
        private Button buttonEkle;
        private Button buttonSil;
        private Button buttonGuncelle;
        private TextBox textBoxArama;
        private ComboBox comboBoxKlinikID;
        private DateTimePicker dateTimePickerDogum;
        private ComboBox comboBoxDoktor;
        private Button buttonAra;
        private Button buttonYenile;
    }
}