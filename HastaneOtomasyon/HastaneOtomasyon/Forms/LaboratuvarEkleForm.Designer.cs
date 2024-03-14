namespace HastaneOtomasyon.Forms
{
    partial class LaboratuvarEkleForm
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
            this.textBoxLaboratuvarAdi = new System.Windows.Forms.TextBox();
            this.dataGridViewLaboratuvar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaboratuvar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.buttonEkle);
            this.groupBox1.Controls.Add(this.textBoxLaboratuvarAdi);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(30, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 423);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laboratuvar İşlemleri";
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
            // textBoxLaboratuvarAdi
            // 
            this.textBoxLaboratuvarAdi.Location = new System.Drawing.Point(6, 52);
            this.textBoxLaboratuvarAdi.Name = "textBoxLaboratuvarAdi";
            this.textBoxLaboratuvarAdi.PlaceholderText = "Laboratuvar Adı";
            this.textBoxLaboratuvarAdi.Size = new System.Drawing.Size(192, 27);
            this.textBoxLaboratuvarAdi.TabIndex = 4;
            this.textBoxLaboratuvarAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewLaboratuvar
            // 
            this.dataGridViewLaboratuvar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLaboratuvar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewLaboratuvar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaboratuvar.Location = new System.Drawing.Point(267, 25);
            this.dataGridViewLaboratuvar.Name = "dataGridViewLaboratuvar";
            this.dataGridViewLaboratuvar.RowHeadersWidth = 62;
            this.dataGridViewLaboratuvar.RowTemplate.Height = 25;
            this.dataGridViewLaboratuvar.Size = new System.Drawing.Size(677, 423);
            this.dataGridViewLaboratuvar.TabIndex = 10;
            this.dataGridViewLaboratuvar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLaboratuvar_CellClick);
            // 
            // LaboratuarEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewLaboratuvar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LaboratuarEkleForm";
            this.Text = "LaboratuarEkle";
            this.Load += new System.EventHandler(this.LaboratuarEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaboratuvar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonGuncelle;
        private Button buttonSil;
        private Button buttonEkle;
        private TextBox textBoxLaboratuvarAdi;
        private DataGridView dataGridViewLaboratuvar;
    }
}