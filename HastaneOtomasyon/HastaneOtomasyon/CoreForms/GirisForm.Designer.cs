namespace HastaneOtomasyon
{
    partial class GirisForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.panelGiris = new System.Windows.Forms.Panel();
            this.labelHastaneAdi = new System.Windows.Forms.Label();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.panelGiris.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGiris
            // 
            resources.ApplyResources(this.panelGiris, "panelGiris");
            this.panelGiris.BackColor = System.Drawing.Color.Indigo;
            this.panelGiris.Controls.Add(this.labelHastaneAdi);
            this.panelGiris.Name = "panelGiris";
            // 
            // labelHastaneAdi
            // 
            resources.ApplyResources(this.labelHastaneAdi, "labelHastaneAdi");
            this.labelHastaneAdi.ForeColor = System.Drawing.Color.White;
            this.labelHastaneAdi.Name = "labelHastaneAdi";
            // 
            // buttonGirisYap
            // 
            resources.ApplyResources(this.buttonGirisYap, "buttonGirisYap");
            this.buttonGirisYap.BackColor = System.Drawing.Color.Indigo;
            this.buttonGirisYap.ForeColor = System.Drawing.Color.White;
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.UseVisualStyleBackColor = false;
            this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // textBoxKullaniciAdi
            // 
            resources.ApplyResources(this.textBoxKullaniciAdi, "textBoxKullaniciAdi");
            this.textBoxKullaniciAdi.BackColor = System.Drawing.Color.Indigo;
            this.textBoxKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxKullaniciAdi);
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::HastaneOtomasyon.Properties.Resources.outline_person_white_36dp;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.textBoxParola);
            this.panel2.Name = "panel2";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::HastaneOtomasyon.Properties.Resources.outline_key_white_36dp;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // textBoxParola
            // 
            resources.ApplyResources(this.textBoxParola, "textBoxParola");
            this.textBoxParola.BackColor = System.Drawing.Color.Indigo;
            this.textBoxParola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParola.ForeColor = System.Drawing.Color.White;
            this.textBoxParola.Name = "textBoxParola";
            // 
            // GirisForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.panelGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GirisForm";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            this.panelGiris.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelGiris;
        private Label labelHastaneAdi;
        private Button buttonGirisYap;
        private TextBox textBoxKullaniciAdi;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox textBoxParola;
    }
}