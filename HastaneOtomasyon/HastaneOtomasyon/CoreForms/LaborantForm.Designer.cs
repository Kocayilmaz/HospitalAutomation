namespace HastaneOtomasyon.CoreForms
{
    partial class LaborantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaborantForm));
            this.panelLeftAdmin = new System.Windows.Forms.Panel();
            this.buttonTestYaz = new System.Windows.Forms.Button();
            this.panelTopAdmin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelLeftAdmin.SuspendLayout();
            this.panelTopAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftAdmin
            // 
            this.panelLeftAdmin.BackColor = System.Drawing.Color.Indigo;
            this.panelLeftAdmin.Controls.Add(this.buttonTestYaz);
            this.panelLeftAdmin.Controls.Add(this.panelTopAdmin);
            this.panelLeftAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelLeftAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLeftAdmin.Name = "panelLeftAdmin";
            this.panelLeftAdmin.Size = new System.Drawing.Size(375, 609);
            this.panelLeftAdmin.TabIndex = 4;
            // 
            // buttonTestYaz
            // 
            this.buttonTestYaz.BackColor = System.Drawing.Color.Indigo;
            this.buttonTestYaz.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTestYaz.FlatAppearance.BorderSize = 0;
            this.buttonTestYaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTestYaz.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTestYaz.ForeColor = System.Drawing.Color.White;
            this.buttonTestYaz.Image = ((System.Drawing.Image)(resources.GetObject("buttonTestYaz.Image")));
            this.buttonTestYaz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTestYaz.Location = new System.Drawing.Point(0, 79);
            this.buttonTestYaz.Name = "buttonTestYaz";
            this.buttonTestYaz.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonTestYaz.Size = new System.Drawing.Size(375, 63);
            this.buttonTestYaz.TabIndex = 11;
            this.buttonTestYaz.Text = "Test Yaz";
            this.buttonTestYaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTestYaz.UseVisualStyleBackColor = false;
            this.buttonTestYaz.Click += new System.EventHandler(this.buttonTestYaz_Click);
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
            this.panelTopAdmin.Size = new System.Drawing.Size(375, 79);
            this.panelTopAdmin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Laborant";
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
            this.panelBody.Location = new System.Drawing.Point(375, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(927, 609);
            this.panelBody.TabIndex = 5;
            // 
            // LaborantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 609);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelLeftAdmin);
            this.Name = "LaborantForm";
            this.Text = "LaborantForm";
            this.Load += new System.EventHandler(this.LaborantForm_Load);
            this.panelLeftAdmin.ResumeLayout(false);
            this.panelTopAdmin.ResumeLayout(false);
            this.panelTopAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelLeftAdmin;
        private Panel panelTopAdmin;
        private Label label1;
        private Label labelAdmin;
        private Button buttonTestYaz;
        private Panel panelBody;
    }
}