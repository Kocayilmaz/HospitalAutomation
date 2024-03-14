namespace HastaneOtomasyon.Forms
{
    partial class DisaridanDoktorEklemeForm
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
            this.textBoxCsvDoktorEkle = new System.Windows.Forms.TextBox();
            this.dataGridViewCsvDoktor = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonCsvSqlEklw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCsvDoktor)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCsvDoktorEkle
            // 
            this.textBoxCsvDoktorEkle.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCsvDoktorEkle.Location = new System.Drawing.Point(37, 35);
            this.textBoxCsvDoktorEkle.Name = "textBoxCsvDoktorEkle";
            this.textBoxCsvDoktorEkle.PlaceholderText = "Dosya";
            this.textBoxCsvDoktorEkle.Size = new System.Drawing.Size(381, 27);
            this.textBoxCsvDoktorEkle.TabIndex = 6;
            this.textBoxCsvDoktorEkle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewCsvDoktor
            // 
            this.dataGridViewCsvDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCsvDoktor.Location = new System.Drawing.Point(37, 83);
            this.dataGridViewCsvDoktor.Name = "dataGridViewCsvDoktor";
            this.dataGridViewCsvDoktor.RowTemplate.Height = 25;
            this.dataGridViewCsvDoktor.Size = new System.Drawing.Size(693, 144);
            this.dataGridViewCsvDoktor.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Indigo;
            this.buttonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEkle.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEkle.ForeColor = System.Drawing.Color.White;
            this.buttonEkle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEkle.Location = new System.Drawing.Point(424, 27);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(150, 35);
            this.buttonEkle.TabIndex = 4;
            this.buttonEkle.Text = "CSV aç";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonCsvSqlEklw
            // 
            this.buttonCsvSqlEklw.BackColor = System.Drawing.Color.Indigo;
            this.buttonCsvSqlEklw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCsvSqlEklw.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCsvSqlEklw.ForeColor = System.Drawing.Color.White;
            this.buttonCsvSqlEklw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCsvSqlEklw.Location = new System.Drawing.Point(580, 27);
            this.buttonCsvSqlEklw.Name = "buttonCsvSqlEklw";
            this.buttonCsvSqlEklw.Size = new System.Drawing.Size(150, 35);
            this.buttonCsvSqlEklw.TabIndex = 4;
            this.buttonCsvSqlEklw.Text = "CSV Sql EKle";
            this.buttonCsvSqlEklw.UseVisualStyleBackColor = false;
            this.buttonCsvSqlEklw.Click += new System.EventHandler(this.buttonCsvSqlEklw_Click);
            // 
            // DisaridanDoktorEklemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCsvSqlEklw);
            this.Controls.Add(this.dataGridViewCsvDoktor);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textBoxCsvDoktorEkle);
            this.Name = "DisaridanDoktorEklemeForm";
            this.Text = "DisaridanDoktorEklemeForm1";
            this.Load += new System.EventHandler(this.DisaridanDoktorEklemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCsvDoktor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxCsvDoktorEkle;
        private DataGridView dataGridViewCsvDoktor;
        private OpenFileDialog openFileDialog1;
        private Button buttonEkle;
        private Button buttonCsvSqlEklw;
    }
}