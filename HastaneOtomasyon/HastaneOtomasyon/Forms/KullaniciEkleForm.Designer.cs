namespace HastaneOtomasyon.Forms
{
    partial class KullaniciEkleForm
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
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.listBoxTur = new System.Windows.Forms.ListBox();
            this.textBoxKullaniciTur = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.dataGridViewKullanici = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanici)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(33, 70);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PlaceholderText = "Parola";
            this.textBoxParola.Size = new System.Drawing.Size(192, 27);
            this.textBoxParola.TabIndex = 0;
            this.textBoxParola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBoxTur
            // 
            this.listBoxTur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTur.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTur.ForeColor = System.Drawing.Color.Indigo;
            this.listBoxTur.FormattingEnabled = true;
            this.listBoxTur.ItemHeight = 19;
            this.listBoxTur.Items.AddRange(new object[] {
            "DOK",
            "VEZ ",
            "LAB",
            "ADM"});
            this.listBoxTur.Location = new System.Drawing.Point(33, 136);
            this.listBoxTur.Name = "listBoxTur";
            this.listBoxTur.Size = new System.Drawing.Size(192, 97);
            this.listBoxTur.TabIndex = 1;
            this.listBoxTur.SelectedIndexChanged += new System.EventHandler(this.listBoxTur_SelectedIndexChanged);
            // 
            // textBoxKullaniciTur
            // 
            this.textBoxKullaniciTur.Location = new System.Drawing.Point(33, 103);
            this.textBoxKullaniciTur.Name = "textBoxKullaniciTur";
            this.textBoxKullaniciTur.PlaceholderText = "Kullanıcı Türü";
            this.textBoxKullaniciTur.Size = new System.Drawing.Size(192, 27);
            this.textBoxKullaniciTur.TabIndex = 2;
            this.textBoxKullaniciTur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(33, 37);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(192, 27);
            this.textBoxKullaniciAdi.TabIndex = 4;
            this.textBoxKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewKullanici
            // 
            this.dataGridViewKullanici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKullanici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanici.Location = new System.Drawing.Point(393, 40);
            this.dataGridViewKullanici.Name = "dataGridViewKullanici";
            this.dataGridViewKullanici.RowTemplate.Height = 25;
            this.dataGridViewKullanici.Size = new System.Drawing.Size(677, 423);
            this.dataGridViewKullanici.TabIndex = 5;
            this.dataGridViewKullanici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKullanici_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.buttonEkle);
            this.groupBox1.Controls.Add(this.textBoxKullaniciAdi);
            this.groupBox1.Controls.Add(this.textBoxParola);
            this.groupBox1.Controls.Add(this.textBoxKullaniciTur);
            this.groupBox1.Controls.Add(this.listBoxTur);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(28, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 423);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı İşlemleri";
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Indigo;
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSil.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSil.ForeColor = System.Drawing.Color.White;
            this.buttonSil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSil.Location = new System.Drawing.Point(33, 321);
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
            this.buttonEkle.Location = new System.Drawing.Point(33, 255);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(192, 51);
            this.buttonEkle.TabIndex = 7;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // KullaniciEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewKullanici);
            this.Name = "KullaniciEkleForm";
            this.Text = "Kullanıcı Ekle";
            this.Load += new System.EventHandler(this.KullaniciEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanici)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBoxParola;
        private ListBox listBoxTur;
        private TextBox textBoxKullaniciTur;
        private TextBox textBoxKullaniciAdi;
        private DataGridView dataGridViewKullanici;
        private GroupBox groupBox1;
        private Button buttonEkle;
        private Button buttonSil;
    }
}