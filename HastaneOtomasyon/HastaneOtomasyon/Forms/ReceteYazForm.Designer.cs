namespace HastaneOtomasyon.Forms
{
    partial class ReceteYazForm
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
            this.dataGridViewHasta = new System.Windows.Forms.DataGridView();
            this.textBoxHastaID = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.textBoxReceteYaz = new System.Windows.Forms.TextBox();
            this.dataGridViewRecete = new System.Windows.Forms.DataGridView();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonDosyaYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHasta
            // 
            this.dataGridViewHasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHasta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasta.Location = new System.Drawing.Point(704, 115);
            this.dataGridViewHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewHasta.Name = "dataGridViewHasta";
            this.dataGridViewHasta.RowHeadersWidth = 62;
            this.dataGridViewHasta.RowTemplate.Height = 25;
            this.dataGridViewHasta.Size = new System.Drawing.Size(508, 709);
            this.dataGridViewHasta.TabIndex = 18;
            this.dataGridViewHasta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHasta_CellClick);
            // 
            // textBoxHastaID
            // 
            this.textBoxHastaID.Location = new System.Drawing.Point(212, 66);
            this.textBoxHastaID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHastaID.Name = "textBoxHastaID";
            this.textBoxHastaID.PlaceholderText = "Hasta ID";
            this.textBoxHastaID.Size = new System.Drawing.Size(273, 31);
            this.textBoxHastaID.TabIndex = 19;
            this.textBoxHastaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.Color.Indigo;
            this.buttonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKaydet.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonKaydet.ForeColor = System.Drawing.Color.White;
            this.buttonKaydet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonKaydet.Location = new System.Drawing.Point(40, 854);
            this.buttonKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(196, 85);
            this.buttonKaydet.TabIndex = 20;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // textBoxReceteYaz
            // 
            this.textBoxReceteYaz.Location = new System.Drawing.Point(40, 115);
            this.textBoxReceteYaz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxReceteYaz.Multiline = true;
            this.textBoxReceteYaz.Name = "textBoxReceteYaz";
            this.textBoxReceteYaz.PlaceholderText = "Reçete";
            this.textBoxReceteYaz.Size = new System.Drawing.Size(614, 705);
            this.textBoxReceteYaz.TabIndex = 21;
            this.textBoxReceteYaz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewRecete
            // 
            this.dataGridViewRecete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecete.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRecete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecete.Location = new System.Drawing.Point(1256, 115);
            this.dataGridViewRecete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewRecete.Name = "dataGridViewRecete";
            this.dataGridViewRecete.RowHeadersWidth = 62;
            this.dataGridViewRecete.RowTemplate.Height = 25;
            this.dataGridViewRecete.Size = new System.Drawing.Size(508, 709);
            this.dataGridViewRecete.TabIndex = 22;
            this.dataGridViewRecete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReçete_CellClick);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Indigo;
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSil.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSil.ForeColor = System.Drawing.Color.White;
            this.buttonSil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSil.Location = new System.Drawing.Point(261, 854);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(196, 85);
            this.buttonSil.TabIndex = 23;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonDosyaYap
            // 
            this.buttonDosyaYap.BackColor = System.Drawing.Color.Indigo;
            this.buttonDosyaYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDosyaYap.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDosyaYap.ForeColor = System.Drawing.Color.White;
            this.buttonDosyaYap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDosyaYap.Location = new System.Drawing.Point(486, 854);
            this.buttonDosyaYap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDosyaYap.Name = "buttonDosyaYap";
            this.buttonDosyaYap.Size = new System.Drawing.Size(299, 85);
            this.buttonDosyaYap.TabIndex = 24;
            this.buttonDosyaYap.Text = "Worde Kaydet";
            this.buttonDosyaYap.UseVisualStyleBackColor = false;
            this.buttonDosyaYap.Click += new System.EventHandler(this.buttonDosyaYap_Click);
            // 
            // ReceteYazForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1818, 1136);
            this.Controls.Add(this.buttonDosyaYap);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.dataGridViewRecete);
            this.Controls.Add(this.textBoxReceteYaz);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.textBoxHastaID);
            this.Controls.Add(this.dataGridViewHasta);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "ReceteYazForm";
            this.Text = "ReceteYaz";
            this.Load += new System.EventHandler(this.ReceteYaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewHasta;
        private TextBox textBoxHastaID;
        private Button buttonKaydet;
        private TextBox textBoxReceteYaz;
        private DataGridView dataGridViewRecete;
        private Button buttonSil;
        private Button buttonDosyaYap;
    }
}