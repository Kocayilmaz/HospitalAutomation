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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneOtomasyon.Forms
{
    public partial class HastaEkleForm : Form
    {
        private void HastaGetir()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand hastaGetirCommand = new SqlCommand();
            hastaGetirCommand.CommandText = "SELECT * FROM Hasta";
            hastaGetirCommand.Connection = Baglanti.hastaneConnection;


            sqlDataAdapter.SelectCommand = hastaGetirCommand;
            DataTable hastaTable = new DataTable();
            sqlDataAdapter.Fill(hastaTable);
            dataGridViewHasta.DataSource = hastaTable;
            dataGridViewHasta.Columns["HastaID"].Visible = false;
        }
        public HastaEkleForm()
        {
            InitializeComponent();
        }


        private void HastaEkleForm_Load(object sender, EventArgs e)
        {
            HastaGetir();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            long hastaTC = Convert.ToInt64(textBoxHastaTC.Text);
            string hastaAd = textBoxHastaAd.Text;
            string hastaSoyad = textBoxHastaSoyad.Text;
            char hastaCinsiyet = Convert.ToChar(textBoxHastaCinsiyet.Text);
            string hastaBabaAdi = textBoxHastaBabaAd.Text;
            string hastaAnneAdi = textBoxHastaAnneAd.Text;
            string hastaCepTel = textBoxHastaCepTelefon.Text;
            string hastaPosta = textBoxHastaEposta.Text;
            string hastaAdres = textBoxHastaAdresi.Text;
            string hastaDogum = dateTimePickerDogum.Value.ToString("yyyy-MM-dd");
            string hastaKanGrup = textBoxHastaKanGrup.Text;

            if (textBoxHastaTC.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            SqlCommand hastaEkleCommand = new SqlCommand();
            hastaEkleCommand.Connection = Baglanti.hastaneConnection;

            hastaEkleCommand.CommandText = string.Format("INSERT Hasta (HastaTC,HastaAd,HastaSoyad,HastaAnneAdi,HastaBabaAdi,HastaCepTel,HastaAdres,HastaDogum,HastaCinsiyet,HastaKanGrup,HastaPosta) " +
                "VALUES({0},'{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}')", hastaTC, hastaAd, hastaSoyad, hastaAnneAdi, hastaBabaAdi, hastaCepTel, hastaAdres, hastaDogum, hastaCinsiyet, hastaKanGrup, hastaPosta);

            { }
            Baglanti.hastaneConnection.Open();

            int etkilenenSatirSayisi = hastaEkleCommand.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kayıt Başarılı");
                HastaGetir();
            }

            else
            {
                MessageBox.Show("Kayıt Ekleme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand hastaSilCommand = new SqlCommand();
            hastaSilCommand.Connection = Baglanti.hastaneConnection;
            hastaSilCommand.CommandText = string.Format("DELETE FROM Hasta WHERE HastaID = {0}", textBoxHastaTC.Tag);

            Baglanti.hastaneConnection.Open();
            int etkilenenSatirSayisi = hastaSilCommand.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Silme Başarılı");
                HastaGetir();
            }

            else
            {
                MessageBox.Show("Kayıt Silme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {

            long hastaTC = Convert.ToInt64(textBoxHastaTC.Text);
            string hastaAd = textBoxHastaAd.Text;
            string hastaSoyad = textBoxHastaSoyad.Text;
            char hastaCinsiyet = Convert.ToChar(textBoxHastaCinsiyet.Text);
            string hastaBabaAdi = textBoxHastaBabaAd.Text;
            string hastaAnneAdi = textBoxHastaAnneAd.Text;
            string hastaCepTel = textBoxHastaCepTelefon.Text;
            string hastaPosta = textBoxHastaEposta.Text;
            string hastaAdres = textBoxHastaAdresi.Text;
            string hastaDogum = dateTimePickerDogum.Value.ToString("yyyy-MM-dd");
            string hastaKanGrup = textBoxHastaKanGrup.Text;

            SqlCommand hastaGuncelleCommand = new SqlCommand();
            hastaGuncelleCommand.Connection = Baglanti.hastaneConnection;
            hastaGuncelleCommand.CommandText = string.Format("UPDATE Hasta SET HastaTC = {0},HastaAd = '{1}',HastaSoyad = '{2}' ,HastaAnneAdi = '{3}',HastaBabaAdi = '{4}', HastaCepTel = {5},HastaAdres = '{6}',HastaDogum = '{7}',HastaCinsiyet = '{8}',HastaKanGrup = '{9}',HastaPosta = '{10}'" +
        " WHERE HastaID = {11}", hastaTC, hastaAd, hastaSoyad, hastaAnneAdi, hastaBabaAdi, hastaCepTel, hastaAdres, hastaDogum, hastaCinsiyet, hastaKanGrup, hastaPosta, textBoxHastaTC.Tag);

            Baglanti.hastaneConnection.Open();
            int etkilenenSatirSayisi = hastaGuncelleCommand.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Güncelleme Başarılı");
                HastaGetir();
            }

            else
            {
                MessageBox.Show("Kayıt Guncelleme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();
        }
         private void buttonAra_Click(object sender, EventArgs e)
        {
            try
            {
                string hastaTC = textBoxTCArama.Text;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                SqlCommand hastaGetirCommand = new SqlCommand();
                hastaGetirCommand.CommandText = "sp_HastaTCAra";
                hastaGetirCommand.CommandType = CommandType.StoredProcedure;
                hastaGetirCommand.Connection = Baglanti.hastaneConnection;
                hastaGetirCommand.Parameters.AddWithValue("@HastaTC", hastaTC);


                sqlDataAdapter.SelectCommand = hastaGetirCommand;
                DataTable hastaTable = new DataTable();
                sqlDataAdapter.Fill(hastaTable);
                dataGridViewHasta.DataSource = hastaTable;
                dataGridViewHasta.Columns["HastaID"].Visible = false;
            }
            catch
            {
                MessageBox.Show("Böyle bir TC Yok");
            }

        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            HastaGetir();
            textBoxTCArama.Text = "";

        }

        private void listBoxKanGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxHastaKanGrup.Text = listBoxKanGrup.SelectedItem.ToString();
        }

        private void dateTimePickerDogum_ValueChanged(object sender, EventArgs e)
        {
            textBoxHastaDogumTarihi.Text = dateTimePickerDogum.Value.ToString("yyyy-MM-dd");
        }

        private void dataGridViewHasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxHastaTC.Tag = dataGridViewHasta.CurrentRow.Cells["HastaID"].Value;
            textBoxHastaTC.Text = dataGridViewHasta.CurrentRow.Cells["HastaTC"].Value.ToString();
            textBoxHastaAd.Text = dataGridViewHasta.CurrentRow.Cells["HastaAd"].Value.ToString();
            textBoxHastaSoyad.Text = dataGridViewHasta.CurrentRow.Cells["HastaSoyad"].Value.ToString();
            textBoxHastaAnneAd.Text = dataGridViewHasta.CurrentRow.Cells["HastaAnneAdi"].Value.ToString();
            textBoxHastaBabaAd.Text = dataGridViewHasta.CurrentRow.Cells["HastaBabaAdi"].Value.ToString();
            textBoxHastaCepTelefon.Text = dataGridViewHasta.CurrentRow.Cells["HastaCepTel"].Value.ToString();
            textBoxHastaEposta.Text = dataGridViewHasta.CurrentRow.Cells["HastaPosta"].Value.ToString();
            textBoxHastaAdresi.Text = dataGridViewHasta.CurrentRow.Cells["HastaAdres"].Value.ToString();
            textBoxHastaDogumTarihi.Text = dataGridViewHasta.CurrentRow.Cells["HastaDogum"].Value.ToString();
            textBoxHastaCinsiyet.Text = dataGridViewHasta.CurrentRow.Cells["HastaCinsiyet"].Value.ToString();
            textBoxHastaKanGrup.Text = dataGridViewHasta.CurrentRow.Cells["HastaKanGrup"].Value.ToString();
            dateTimePickerDogum.Text = dataGridViewHasta.CurrentRow.Cells["HastaDogum"].Value.ToString();
        }

        private void textBoxHastaTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Harf Girmeyiniz.");
            }
        }

        private void textBoxHastaCepTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Harf Girmeyiniz.");
            }
        }


        private void textBoxHastaDogumTarihi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Harf Girmeyiniz.");
            }
        }

        private void textBoxHastaCinsiyet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Rakam Girmeyiniz.");
            }
            else if (!char.IsControl(e.KeyChar) && ((e.KeyChar.ToString() != "E") && (e.KeyChar.ToString() != "K")))
            {
                e.Handled = true;
                MessageBox.Show("Sadece E veya K harfini giriniz.");
            }
        }
    }
    }
