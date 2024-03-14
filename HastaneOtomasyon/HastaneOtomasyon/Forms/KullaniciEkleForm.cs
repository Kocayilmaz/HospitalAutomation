using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.Forms
{
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }
        private void KullanicilariGetir()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand kullaniciGetirCommand = new SqlCommand();
            kullaniciGetirCommand.CommandText = "sp_KullaniciGetir";
            kullaniciGetirCommand.CommandType = CommandType.StoredProcedure;
            kullaniciGetirCommand.Connection = Baglanti.hastaneConnection;

            sqlDataAdapter.SelectCommand = kullaniciGetirCommand;
            DataTable kullaniciTable = new DataTable();
            sqlDataAdapter.Fill(kullaniciTable);
            dataGridViewKullanici.DataSource = kullaniciTable;
            dataGridViewKullanici.Columns["KullaniciID"].Visible = false;
        }
        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            KullanicilariGetir();
        }
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxKullaniciAdi.Text;
            string kullaniciParola = textBoxParola.Text;
            string kullaniciTur = textBoxKullaniciTur.Text;

            if (kullaniciAdi == "" || kullaniciParola == "" || kullaniciTur == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            SqlCommand kullaniciEkleCommand = new SqlCommand();

            kullaniciEkleCommand.CommandText = "sp_KullaniciEkle";
            kullaniciEkleCommand.CommandType = CommandType.StoredProcedure;
            kullaniciEkleCommand.Connection = Baglanti.hastaneConnection;

            kullaniciEkleCommand.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
            kullaniciEkleCommand.Parameters.AddWithValue("@KullaniciParola", kullaniciParola);
            kullaniciEkleCommand.Parameters.AddWithValue("@KullaniciTur", kullaniciTur);

            Baglanti.hastaneConnection.Open();

            int etkilenenSatirSayisi = kullaniciEkleCommand.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kayıt Başarılı");
                KullanicilariGetir();
            }

            else
            {
                MessageBox.Show("Kayıt Ekleme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxKullaniciAdi.Text;
            string kullaniciParola = textBoxParola.Text;
            string kullaniciTur = textBoxKullaniciTur.Text;
            
            if (kullaniciAdi == "" || kullaniciParola == "" || kullaniciTur == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            SqlCommand kullaniciSilCommand = new SqlCommand();

            kullaniciSilCommand.CommandText = "sp_KullaniciSil";
            kullaniciSilCommand.CommandType = CommandType.StoredProcedure;
            kullaniciSilCommand.Connection = Baglanti.hastaneConnection;

            kullaniciSilCommand.Parameters.AddWithValue("@KullaniciID", textBoxKullaniciAdi.Tag);
            kullaniciSilCommand.Connection = Baglanti.hastaneConnection;

            Baglanti.hastaneConnection.Open();

            int etkilenenSatirSayisi = kullaniciSilCommand.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Silme İşlemi Başarılı");
                KullanicilariGetir();
            }

            else
            {
                MessageBox.Show("Silme İşlemi Sırasında Bir Şeyler Ters Gitti");
            }
            Baglanti.hastaneConnection.Close();
        }


        private void dataGridViewKullanici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxKullaniciAdi.Tag = dataGridViewKullanici.CurrentRow.Cells["KullaniciID"].Value;
            textBoxKullaniciAdi.Text = dataGridViewKullanici.CurrentRow.Cells["KullaniciAdi"].Value.ToString();
            textBoxParola.Text = dataGridViewKullanici.CurrentRow.Cells["KullaniciParola"].Value.ToString();
            textBoxKullaniciTur.Text = dataGridViewKullanici.CurrentRow.Cells["KullaniciTur"].Value.ToString();
        }

        private void listBoxTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxKullaniciTur.Text = listBoxTur.SelectedItem.ToString();
        }

    }
}
