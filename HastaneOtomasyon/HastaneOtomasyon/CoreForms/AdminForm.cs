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

namespace HastaneOtomasyon
{
    public partial class AdminForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        public AdminForm()
        {
            InitializeComponent();
        }
        private void ActiveButton(object btnSender)
        {
            if(btnSender != null) {
               if(currentButton != (Button)btnSender)
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
            foreach(Control previousBtn in panelLeftAdmin.Controls)
            {
               if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Indigo;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
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

        private void buttonKullaniciEkle_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            KullaniciEkleForm kullaniciEkleForm = new KullaniciEkleForm();
            OpenChildForm(kullaniciEkleForm, sender); 
        }

        private void buttonHastaEkle_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            HastaEkleForm hastaEkleForm = new HastaEkleForm();
            OpenChildForm(hastaEkleForm, sender);
        }

        private void buttonDoktorEkle_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            DoktorEkleForm doktorEkleForm = new DoktorEkleForm();
            OpenChildForm(doktorEkleForm, sender);  
        }

        private void buttonRandevuOlustur_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            RandevuEkleForm randevuEkleForm = new RandevuEkleForm();
            OpenChildForm(randevuEkleForm,sender);
        }

        private void buttonReceteYaz_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            ReceteYazForm receteYazForm = new ReceteYazForm();
            OpenChildForm(receteYazForm, sender);
        }

        private void buttonTaniKoy_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            TaniEkleForm taniEkleForm = new TaniEkleForm();
            OpenChildForm(taniEkleForm, sender);
        }

        private void buttonLaboratuvarEkle_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            LaboratuvarEkleForm laboratuarEkleForm = new LaboratuvarEkleForm();
            OpenChildForm(laboratuarEkleForm, sender);
        }
        private void buttonKlinikEkle_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            KlinikEkleForm klinkEkleForm = new KlinikEkleForm();
            OpenChildForm(klinkEkleForm,sender);
        }
        private void buttonTestYaz_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            TestYazForm testYazForm = new TestYazForm();
            OpenChildForm(testYazForm, sender);
        }
        private void buttonYedekle_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            YedeklemeIslemleriForm yedeklemeIslemleriForm = new YedeklemeIslemleriForm();
            OpenChildForm(yedeklemeIslemleriForm, sender);
        }

        private void buttonDisaridanDoktorEkle_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            DisaridanDoktorEklemeForm CsvDoktorEkleme = new DisaridanDoktorEklemeForm();
            OpenChildForm(CsvDoktorEkleme, sender);
        }
    }
}
