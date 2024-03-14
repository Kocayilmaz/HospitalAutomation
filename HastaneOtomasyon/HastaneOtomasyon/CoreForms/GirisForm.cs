using System;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using HastaneOtomasyon.CoreForms;

namespace HastaneOtomasyon
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }
        private void GirisForm_Load(object sender, EventArgs e)
        {
      
        }
        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            string user = textBoxKullaniciAdi.Text;
            string password = textBoxParola.Text;
            string admin = "ADM";
            string doktor = "DOK";
            string veznedar = "VEZ";
            string laborant = "LAB";
            Baglanti.hastaneConnection.Open();

            SqlCommand hastaneCommand = new SqlCommand();
            hastaneCommand.Connection = Baglanti.hastaneConnection;
            hastaneCommand.CommandText = "SELECT * FROM Kullanici";
            SqlDataReader hastaneReader = hastaneCommand.ExecuteReader();

            while (hastaneReader.Read())
            {
                if (user == hastaneReader["KullaniciAdi"].ToString() && password == hastaneReader["KullaniciParola"].ToString() && admin == hastaneReader["KullaniciTur"].ToString())
                {
                    AdminForm adminForm = new AdminForm();
                    MessageBox.Show("Başarılı Giriş");
                    adminForm.Show();
                    Hide();
                }

                else if (user == hastaneReader["KullaniciAdi"].ToString() && password == hastaneReader["KullaniciParola"].ToString() && doktor == hastaneReader["KullaniciTur"].ToString())
                {
                    DoktorForm doktorForm = new DoktorForm();
                    MessageBox.Show("Başarılı Giriş");
                    doktorForm.Show();
                    Hide();
                }

                else if (user == hastaneReader["KullaniciAdi"].ToString() && password == hastaneReader["KullaniciParola"].ToString() && veznedar == hastaneReader["KullaniciTur"].ToString())
                {
                    VeznedarForm veznedarForm = new VeznedarForm();
                    MessageBox.Show("Başarılı Giriş");
                    veznedarForm.Show();
                    Hide();
                }

                else if (user == hastaneReader["KullaniciAdi"].ToString() && password == hastaneReader["KullaniciParola"].ToString() && laborant == hastaneReader["KullaniciTur"].ToString())
                {
                    LaborantForm  laborantForm = new LaborantForm();
                    MessageBox.Show("Başarılı Giriş");
                    laborantForm.Show();
                    Hide();
                }

                else  if(user == "" || password == ""){ 

                    MessageBox.Show("Boş giriş yapmayınız.");
                }
            }
            Baglanti.hastaneConnection.Close();
        }

        private void textBoxParola_TextChanged(object sender, EventArgs e)
        {

        }
    }
}