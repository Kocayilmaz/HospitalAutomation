namespace HastaneOtomasyon.CoreForms
{
    partial class DoktorForm
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
            this.buttonTaniEkle = new System.Windows.Forms.Button();
            this.panelLeftAdmin = new System.Windows.Forms.Panel();
            this.buttonReceteYaz = new System.Windows.Forms.Button();
            this.panelTopAdmin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelLeftAdmin.SuspendLayout();
            this.panelTopAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTaniEkle
            // 
            this.buttonTaniEkle.BackColor = System.Drawing.Color.Indigo;
            this.buttonTaniEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTaniEkle.FlatAppearance.BorderSize = 0;
            this.buttonTaniEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTaniEkle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTaniEkle.ForeColor = System.Drawing.Color.White;
            this.buttonTaniEkle.Image = global::HastaneOtomasyon.Properties.Resources.outline_medication_white_36dp;
            this.buttonTaniEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTaniEkle.Location = new System.Drawing.Point(0, 163);
            this.buttonTaniEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTaniEkle.Name = "buttonTaniEkle";
            this.buttonTaniEkle.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonTaniEkle.Size = new System.Drawing.Size(233, 84);
            this.buttonTaniEkle.TabIndex = 6;
            this.buttonTaniEkle.Text = "Tanı Ekle";
            this.buttonTaniEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTaniEkle.UseVisualStyleBackColor = false;
            this.buttonTaniEkle.Click += new System.EventHandler(this.buttonTaniEkle_Click);
            // 
            // panelLeftAdmin
            // 
            this.panelLeftAdmin.BackColor = System.Drawing.Color.Indigo;
            this.panelLeftAdmin.Controls.Add(this.buttonTaniEkle);
            this.panelLeftAdmin.Controls.Add(this.buttonReceteYaz);
            this.panelLeftAdmin.Controls.Add(this.panelTopAdmin);
            this.panelLeftAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelLeftAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLeftAdmin.Name = "panelLeftAdmin";
            this.panelLeftAdmin.Size = new System.Drawing.Size(233, 909);
            this.panelLeftAdmin.TabIndex = 2;
            // 
            // buttonReceteYaz
            // 
            this.buttonReceteYaz.BackColor = System.Drawing.Color.Indigo;
            this.buttonReceteYaz.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReceteYaz.FlatAppearance.BorderSize = 0;
            this.buttonReceteYaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReceteYaz.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReceteYaz.ForeColor = System.Drawing.Color.White;
            this.buttonReceteYaz.Image = global::HastaneOtomasyon.Properties.Resources.baseline_draw_white_36dp;
            this.buttonReceteYaz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReceteYaz.Location = new System.Drawing.Point(0, 79);
            this.buttonReceteYaz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReceteYaz.Name = "buttonReceteYaz";
            this.buttonReceteYaz.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonReceteYaz.Size = new System.Drawing.Size(233, 84);
            this.buttonReceteYaz.TabIndex = 5;
            this.buttonReceteYaz.Text = "Reçete Yaz";
            this.buttonReceteYaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReceteYaz.UseVisualStyleBackColor = false;
            this.buttonReceteYaz.Click += new System.EventHandler(this.buttonReceteYaz_Click);
            // 
            // panelTopAdmin
            // 
            this.panelTopAdmin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelTopAdmin.Controls.Add(this.label1);
            this.panelTopAdmin.Controls.Add(this.labelAdmin);
            this.panelTopAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelTopAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTopAdmin.Name = "panelTopAdmin";
            this.panelTopAdmin.Size = new System.Drawing.Size(233, 79);
            this.panelTopAdmin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doktor";
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Bahnschrift Condensed", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdmin.ForeColor = System.Drawing.Color.White;
            this.labelAdmin.Location = new System.Drawing.Point(282, 11);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(0, 45);
            this.labelAdmin.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(233, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1390, 909);
            this.panelBody.TabIndex = 3;
            // 
            // DoktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 909);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelLeftAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DoktorForm";
            this.Text = "DoktorForm";
            this.Load += new System.EventHandler(this.DoktorForm_Load);
            this.panelLeftAdmin.ResumeLayout(false);
            this.panelTopAdmin.ResumeLayout(false);
            this.panelTopAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonTaniEkle;
        private Panel panelLeftAdmin;
        private Button buttonReceteYaz;
        private Panel panelTopAdmin;
        private Label label1;
        private Label labelAdmin;
        private Panel panelBody;
    }
}