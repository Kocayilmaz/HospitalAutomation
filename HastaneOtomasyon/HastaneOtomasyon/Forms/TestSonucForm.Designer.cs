namespace HastaneOtomasyon.Forms
{
    partial class TestSonucForm
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
            this.dataGridViewTestSonuc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTestSonuc
            // 
            this.dataGridViewTestSonuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTestSonuc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTestSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTestSonuc.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTestSonuc.Name = "dataGridViewTestSonuc";
            this.dataGridViewTestSonuc.RowTemplate.Height = 25;
            this.dataGridViewTestSonuc.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewTestSonuc.TabIndex = 0;
            // 
            // TestSonucForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTestSonuc);
            this.Name = "TestSonucForm";
            this.Text = "TestSonucForm";
            this.Load += new System.EventHandler(this.TestSonucForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestSonuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewTestSonuc;
    }
}