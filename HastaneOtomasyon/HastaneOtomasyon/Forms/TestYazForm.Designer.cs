namespace HastaneOtomasyon.Forms
{
    partial class TestYazForm
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
            this.labelTestler = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.textBoxTestSonuc = new System.Windows.Forms.TextBox();
            this.dataGridViewTest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTestler
            // 
            this.labelTestler.AutoSize = true;
            this.labelTestler.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTestler.Location = new System.Drawing.Point(511, 9);
            this.labelTestler.Name = "labelTestler";
            this.labelTestler.Size = new System.Drawing.Size(68, 23);
            this.labelTestler.TabIndex = 1;
            this.labelTestler.Text = "Testler";
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Indigo;
            this.buttonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEkle.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEkle.ForeColor = System.Drawing.Color.White;
            this.buttonEkle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEkle.Location = new System.Drawing.Point(640, 398);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(365, 51);
            this.buttonEkle.TabIndex = 10;
            this.buttonEkle.Text = "Açıklama Ekle ve Değiştir";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Indigo;
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSil.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSil.ForeColor = System.Drawing.Color.White;
            this.buttonSil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSil.Location = new System.Drawing.Point(640, 455);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(365, 51);
            this.buttonSil.TabIndex = 11;
            this.buttonSil.Text = "Testi Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // textBoxTestSonuc
            // 
            this.textBoxTestSonuc.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTestSonuc.Location = new System.Drawing.Point(35, 369);
            this.textBoxTestSonuc.Multiline = true;
            this.textBoxTestSonuc.Name = "textBoxTestSonuc";
            this.textBoxTestSonuc.PlaceholderText = "Test Sonuc";
            this.textBoxTestSonuc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTestSonuc.Size = new System.Drawing.Size(477, 191);
            this.textBoxTestSonuc.TabIndex = 14;
            // 
            // dataGridViewTest
            // 
            this.dataGridViewTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTest.Location = new System.Drawing.Point(35, 39);
            this.dataGridViewTest.Name = "dataGridViewTest";
            this.dataGridViewTest.RowTemplate.Height = 25;
            this.dataGridViewTest.Size = new System.Drawing.Size(1105, 293);
            this.dataGridViewTest.TabIndex = 15;
            this.dataGridViewTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTest_CellClick);
            // 
            // TestYazForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 589);
            this.Controls.Add(this.dataGridViewTest);
            this.Controls.Add(this.textBoxTestSonuc);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.labelTestler);
            this.Name = "TestYazForm";
            this.Text = "Test Yaz";
            this.Load += new System.EventHandler(this.TestYazForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelTestler;
        private Button buttonEkle;
        private Button buttonSil;
        private TextBox textBoxTestSonuc;
        private DataGridView dataGridViewTest;
    }
}