namespace HastaneOtomasyon.Forms
{
    partial class RandevuEkleForm
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
            this.dataGridViewKlinik = new System.Windows.Forms.DataGridView();
            this.dataGridViewHasta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRandevuTarih = new System.Windows.Forms.TextBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.textBoxKlinikAdi = new System.Windows.Forms.TextBox();
            this.textBoxHastaAdi = new System.Windows.Forms.TextBox();
            this.textBoxDoktorAdi = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerRandevu = new System.Windows.Forms.DateTimePicker();
            this.textBoxKlinikID = new System.Windows.Forms.TextBox();
            this.textBoxHastaID = new System.Windows.Forms.TextBox();
            this.textBoxDoktorID = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.dataGridViewDoktor = new System.Windows.Forms.DataGridView();
            this.dataGridViewRandevu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlinik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKlinik
            // 
            this.dataGridViewKlinik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKlinik.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewKlinik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlinik.Location = new System.Drawing.Point(650, 85);
            this.dataGridViewKlinik.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewKlinik.Name = "dataGridViewKlinik";
            this.dataGridViewKlinik.RowHeadersWidth = 62;
            this.dataGridViewKlinik.RowTemplate.Height = 25;
            this.dataGridViewKlinik.Size = new System.Drawing.Size(225, 565);
            this.dataGridViewKlinik.TabIndex = 18;
            this.dataGridViewKlinik.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKlinik_CellClick);
            // 
            // dataGridViewHasta
            // 
            this.dataGridViewHasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHasta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasta.Location = new System.Drawing.Point(35, 85);
            this.dataGridViewHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewHasta.Name = "dataGridViewHasta";
            this.dataGridViewHasta.RowHeadersWidth = 62;
            this.dataGridViewHasta.RowTemplate.Height = 25;
            this.dataGridViewHasta.Size = new System.Drawing.Size(607, 565);
            this.dataGridViewHasta.TabIndex = 17;
            this.dataGridViewHasta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHasta_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRandevuTarih);
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.textBoxKlinikAdi);
            this.groupBox1.Controls.Add(this.textBoxHastaAdi);
            this.groupBox1.Controls.Add(this.textBoxDoktorAdi);
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerRandevu);
            this.groupBox1.Controls.Add(this.textBoxKlinikID);
            this.groupBox1.Controls.Add(this.textBoxHastaID);
            this.groupBox1.Controls.Add(this.textBoxDoktorID);
            this.groupBox1.Controls.Add(this.buttonEkle);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(60, 748);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(721, 470);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxRandevuTarih
            // 
            this.textBoxRandevuTarih.Location = new System.Drawing.Point(119, 215);
            this.textBoxRandevuTarih.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRandevuTarih.Name = "textBoxRandevuTarih";
            this.textBoxRandevuTarih.PlaceholderText = "Randevu Tarih";
            this.textBoxRandevuTarih.Size = new System.Drawing.Size(257, 36);
            this.textBoxRandevuTarih.TabIndex = 22;
            this.textBoxRandevuTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.Indigo;
            this.buttonGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuncelle.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGuncelle.ForeColor = System.Drawing.Color.White;
            this.buttonGuncelle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGuncelle.Location = new System.Drawing.Point(399, 238);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(289, 85);
            this.buttonGuncelle.TabIndex = 21;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // textBoxKlinikAdi
            // 
            this.textBoxKlinikAdi.Location = new System.Drawing.Point(119, 160);
            this.textBoxKlinikAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxKlinikAdi.Name = "textBoxKlinikAdi";
            this.textBoxKlinikAdi.PlaceholderText = "Klinik Adı";
            this.textBoxKlinikAdi.Size = new System.Drawing.Size(257, 36);
            this.textBoxKlinikAdi.TabIndex = 20;
            this.textBoxKlinikAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHastaAdi
            // 
            this.textBoxHastaAdi.Location = new System.Drawing.Point(119, 105);
            this.textBoxHastaAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHastaAdi.Name = "textBoxHastaAdi";
            this.textBoxHastaAdi.PlaceholderText = "Hasta Adı";
            this.textBoxHastaAdi.Size = new System.Drawing.Size(257, 36);
            this.textBoxHastaAdi.TabIndex = 19;
            this.textBoxHastaAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDoktorAdi
            // 
            this.textBoxDoktorAdi.Location = new System.Drawing.Point(119, 50);
            this.textBoxDoktorAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDoktorAdi.Name = "textBoxDoktorAdi";
            this.textBoxDoktorAdi.PlaceholderText = "Doktor Adı";
            this.textBoxDoktorAdi.Size = new System.Drawing.Size(257, 36);
            this.textBoxDoktorAdi.TabIndex = 18;
            this.textBoxDoktorAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Indigo;
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSil.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSil.ForeColor = System.Drawing.Color.White;
            this.buttonSil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSil.Location = new System.Drawing.Point(399, 143);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(289, 85);
            this.buttonSil.TabIndex = 17;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(230, 351);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Randevu Tarihi :";
            // 
            // dateTimePickerRandevu
            // 
            this.dateTimePickerRandevu.CustomFormat = "yy-MM-dd";
            this.dateTimePickerRandevu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerRandevu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRandevu.Location = new System.Drawing.Point(420, 351);
            this.dateTimePickerRandevu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerRandevu.Name = "dateTimePickerRandevu";
            this.dateTimePickerRandevu.Size = new System.Drawing.Size(280, 44);
            this.dateTimePickerRandevu.TabIndex = 15;
            this.dateTimePickerRandevu.ValueChanged += new System.EventHandler(this.dateTimePickerRandevu_ValueChanged);
            // 
            // textBoxKlinikID
            // 
            this.textBoxKlinikID.Location = new System.Drawing.Point(9, 180);
            this.textBoxKlinikID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxKlinikID.Name = "textBoxKlinikID";
            this.textBoxKlinikID.PlaceholderText = "Klinik ID";
            this.textBoxKlinikID.Size = new System.Drawing.Size(100, 36);
            this.textBoxKlinikID.TabIndex = 13;
            this.textBoxKlinikID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHastaID
            // 
            this.textBoxHastaID.Location = new System.Drawing.Point(9, 125);
            this.textBoxHastaID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHastaID.Name = "textBoxHastaID";
            this.textBoxHastaID.PlaceholderText = "Hasta ID";
            this.textBoxHastaID.Size = new System.Drawing.Size(100, 36);
            this.textBoxHastaID.TabIndex = 12;
            this.textBoxHastaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDoktorID
            // 
            this.textBoxDoktorID.Location = new System.Drawing.Point(9, 70);
            this.textBoxDoktorID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDoktorID.Name = "textBoxDoktorID";
            this.textBoxDoktorID.PlaceholderText = "Doktor ID";
            this.textBoxDoktorID.Size = new System.Drawing.Size(100, 36);
            this.textBoxDoktorID.TabIndex = 4;
            this.textBoxDoktorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Indigo;
            this.buttonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEkle.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEkle.ForeColor = System.Drawing.Color.White;
            this.buttonEkle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEkle.Location = new System.Drawing.Point(399, 43);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(289, 85);
            this.buttonEkle.TabIndex = 11;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // dataGridViewDoktor
            // 
            this.dataGridViewDoktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoktor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoktor.Location = new System.Drawing.Point(883, 85);
            this.dataGridViewDoktor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDoktor.Name = "dataGridViewDoktor";
            this.dataGridViewDoktor.RowHeadersWidth = 62;
            this.dataGridViewDoktor.RowTemplate.Height = 25;
            this.dataGridViewDoktor.Size = new System.Drawing.Size(853, 565);
            this.dataGridViewDoktor.TabIndex = 15;
            this.dataGridViewDoktor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoktor_CellClick);
            // 
            // dataGridViewRandevu
            // 
            this.dataGridViewRandevu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRandevu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRandevu.Location = new System.Drawing.Point(789, 758);
            this.dataGridViewRandevu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewRandevu.Name = "dataGridViewRandevu";
            this.dataGridViewRandevu.RowHeadersWidth = 62;
            this.dataGridViewRandevu.RowTemplate.Height = 25;
            this.dataGridViewRandevu.Size = new System.Drawing.Size(947, 451);
            this.dataGridViewRandevu.TabIndex = 19;
            this.dataGridViewRandevu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRandevu_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(269, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 35);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hastalar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1242, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 35);
            this.label3.TabIndex = 21;
            this.label3.Text = "Doktorlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(723, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 35);
            this.label4.TabIndex = 22;
            this.label4.Text = "Klinik";
            // 
            // RandevuEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2164, 1410);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewRandevu);
            this.Controls.Add(this.dataGridViewKlinik);
            this.Controls.Add(this.dataGridViewHasta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewDoktor);
            this.Name = "RandevuEkleForm";
            this.Text = "RandevuEkleForm";
            this.Load += new System.EventHandler(this.RandevuEkleForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlinik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewKlinik;
        private DataGridView dataGridViewHasta;
        private GroupBox groupBox1;
        private TextBox textBoxKlinikID;
        private TextBox textBoxHastaID;
        private TextBox textBoxDoktorID;
        private Button buttonEkle;
        private DataGridView dataGridViewDoktor;
        private DateTimePicker dateTimePickerRandevu;
        private TextBox textBoxKlinikAdi;
        private TextBox textBoxHastaAdi;
        private TextBox textBoxDoktorAdi;
        private Button buttonSil;
        private Label label1;
        private Button buttonGuncelle;
        private TextBox textBoxRandevuTarih;
        private DataGridView dataGridViewRandevu;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}