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
    public partial class RandevuEkleForm : Form
    {
        public RandevuEkleForm()
        {
            InitializeComponent();
        }

        private void RandevuGetir()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand randevuGetir = new SqlCommand();
            randevuGetir.CommandText = "SELECT Hasta.HastaID,HastaAd,HastaSoyad,HastaTC,Randevu.RandevuID,Randevu.KlinikID,Randevu.RandevuDoktorID,Randevu.RandevuTarih FROM Hasta INNER JOIN Randevu ON Hasta.HastaID = Randevu.HastaID";
            randevuGetir.Connection = Baglanti.hastaneConnection;

            sqlDataAdapter.SelectCommand = randevuGetir;
            DataTable randevuTable = new DataTable();
            sqlDataAdapter.Fill(randevuTable);
            dataGridViewRandevu.DataSource = randevuTable;
            dataGridViewRandevu.Columns["RandevuID"].Visible = false;
            dataGridViewRandevu.Columns["HastaID"].Visible = false;
            dataGridViewRandevu.Columns["KlinikID"].Visible = false;
            dataGridViewRandevu.Columns["RandevuDoktorID"].Visible = false;
        }

        private void DoktorlariGetir()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand doktorGetirCommand = new SqlCommand();
            doktorGetirCommand.CommandText = "sp_KlinikDoktorGetir";
            doktorGetirCommand.CommandType = CommandType.StoredProcedure;
            doktorGetirCommand.Connection = Baglanti.hastaneConnection;
            doktorGetirCommand.Parameters.AddWithValue("@KlinikID", textBoxKlinikID.Text);

            sqlDataAdapter.SelectCommand= doktorGetirCommand;
            DataTable doktorTable = new DataTable();
            sqlDataAdapter.Fill(doktorTable);
            dataGridViewDoktor.DataSource = doktorTable;
            dataGridViewDoktor.Columns["DoktorID"].Visible = false;
        }

        private void HastalariGetir()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand hastaGetirCommand = new SqlCommand();
            hastaGetirCommand.CommandText = "sp_HastaGetir";
            hastaGetirCommand.CommandType = CommandType.StoredProcedure;
            hastaGetirCommand.Connection = Baglanti.hastaneConnection;

            sqlDataAdapter.SelectCommand = hastaGetirCommand;
            DataTable hastaTable = new DataTable();
            sqlDataAdapter.Fill(hastaTable);
            dataGridViewHasta.DataSource = hastaTable;
            dataGridViewHasta.Columns["HastaBabaAdi"].Visible = false;
            dataGridViewHasta.Columns["HastaAnneAdi"].Visible = false;
            dataGridViewHasta.Columns["HastaDogum"].Visible = false;
            dataGridViewHasta.Columns["HastaID"].Visible = false;
            dataGridViewHasta.Columns["HastaCinsiyet"].Visible = false;
            dataGridViewHasta.Columns["HastaPosta"].Visible = false;
            dataGridViewHasta.Columns["HastaAdres"].Visible = false;
        }

        private void KlinikleriGetir()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand klinikGetirCommand = new SqlCommand();
            klinikGetirCommand.CommandText = "SELECT * FROM Klinik";
            klinikGetirCommand.Connection = Baglanti.hastaneConnection;

            sqlDataAdapter.SelectCommand = klinikGetirCommand;
            DataTable klinikTable = new DataTable();
            sqlDataAdapter.Fill(klinikTable);
            dataGridViewKlinik.DataSource = klinikTable;
            dataGridViewKlinik.Columns["KlinikID"].Visible = false;
        }

        private void RandevuEkleForm_Load_1(object sender, EventArgs e)
        {
            DoktorlariGetir();
            HastalariGetir();
            KlinikleriGetir();
            RandevuGetir();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string doktorID = textBoxDoktorID.Text;
            string hastaID= textBoxHastaID.Text;
            string klinikID = textBoxKlinikID.Text;
            string randevuTarih = dateTimePickerRandevu.Value.ToString("yyyy-MM-dd");


            SqlCommand randevuEkleCommand = new SqlCommand();

            randevuEkleCommand.CommandText = "sp_RandevuEkle";
            randevuEkleCommand.CommandType = CommandType.StoredProcedure;
            randevuEkleCommand.Connection = Baglanti.hastaneConnection;

            randevuEkleCommand.Parameters.AddWithValue("@RandevuDoktorID", doktorID);
            randevuEkleCommand.Parameters.AddWithValue("@HastaID", hastaID);
            randevuEkleCommand.Parameters.AddWithValue("@KlinikID", klinikID);
            randevuEkleCommand.Parameters.AddWithValue("@RandevuTarih", randevuTarih);

            Baglanti.hastaneConnection.Open();

            int etkilenenSatirSayisi = randevuEkleCommand.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kayıt Başarılı");
                RandevuGetir();
            }

            else
            {
                MessageBox.Show("Kayıt Ekleme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand randevuSil = new SqlCommand();

            randevuSil.CommandText = string.Format("DELETE FROM Randevu WHERE RandevuID = {0}", textBoxHastaAdi.Tag);
            randevuSil.Connection = Baglanti.hastaneConnection;

            Baglanti.hastaneConnection.Open();

            int etkilenenSatirSayisi = randevuSil.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Silme Başarılı");
                RandevuGetir();
            }

            else
            {
                MessageBox.Show("Silme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {

            string doktorID = textBoxDoktorID.Text;
            string hastaID = textBoxHastaID.Text;
            string klinikID = textBoxKlinikID.Text;
            string randevuTarih = dateTimePickerRandevu.Value.ToString("yyyy-MM-dd");

            SqlCommand randevuGuncelle = new SqlCommand();

            randevuGuncelle.CommandText = string.Format("UPDATE Randevu SET HastaID = {0}, RandevuDoktorID = {1}, KlinikID = {2}, RandevuTarih = '{3}' WHERE RandevuID = {4} ",hastaID,doktorID,klinikID,randevuTarih, textBoxHastaAdi.Tag);
            randevuGuncelle.Connection = Baglanti.hastaneConnection;

            Baglanti.hastaneConnection.Open();

            int etkilenenSatirSayisi = randevuGuncelle.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Güncelleme Başarılı");
                RandevuGetir();
            }

            else
            {
                MessageBox.Show("Güncelleme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();
        }

        private void dataGridViewDoktor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxDoktorID.Text = dataGridViewDoktor.CurrentRow.Cells["DoktorID"].Value.ToString();
            textBoxDoktorAdi.Text = dataGridViewDoktor.CurrentRow.Cells["DoktorAd"].Value.ToString() + " " + dataGridViewDoktor.CurrentRow.Cells["DoktorSoyad"].Value.ToString();
        }

        private void dataGridViewHasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxHastaID.Text = dataGridViewHasta.CurrentRow.Cells["HastaID"].Value.ToString();
            textBoxHastaAdi.Text = dataGridViewHasta.CurrentRow.Cells["HastaAd"].Value.ToString() + " " + dataGridViewHasta.CurrentRow.Cells["HastaSoyad"].Value.ToString();
        }

        private void dataGridViewKlinik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxKlinikAdi.Text = dataGridViewKlinik.CurrentRow.Cells["KlinikAdi"].Value.ToString();
            textBoxKlinikID.Text = dataGridViewKlinik.CurrentRow.Cells["KlinikID"].Value.ToString();
            DoktorlariGetir();
        }

        private void dateTimePickerRandevu_ValueChanged(object sender, EventArgs e)
        {
            textBoxRandevuTarih.Text = dateTimePickerRandevu.Value.ToString("yyyy-MM-dd");
        }

        private void dataGridViewRandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxHastaAdi.Tag = dataGridViewRandevu.CurrentRow.Cells["RandevuID"].Value;
            textBoxHastaID.Text = dataGridViewRandevu.CurrentRow.Cells["HastaID"].Value.ToString();
            textBoxKlinikID.Text = dataGridViewRandevu.CurrentRow.Cells["KlinikID"].Value.ToString();
            textBoxDoktorID.Text = dataGridViewRandevu.CurrentRow.Cells["RandevuDoktorID"].Value.ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
