using HastaneOtomasyon.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.CoreForms
{
    public partial class LaborantForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        public LaborantForm()
        {
            InitializeComponent();
        }
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Purple;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelLeftAdmin.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Indigo;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelBody.Controls.Add(childForm);
            this.panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void LaborantForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonTestYaz_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            TestYazForm testYazForm = new TestYazForm();
            OpenChildForm(testYazForm, sender);
        }
    }
}
