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
    public partial class KlinikEkleForm : Form
    {
        public KlinikEkleForm()
        {
            InitializeComponent();
        }
        private void KlinikGetir()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand klinikGetir = new SqlCommand();
            klinikGetir.CommandText = "sp_KlinikGetir";
            klinikGetir.CommandType = CommandType.StoredProcedure;
            klinikGetir.Connection = Baglanti.hastaneConnection;

            sqlDataAdapter.SelectCommand = klinikGetir;
            DataTable klinikTable = new DataTable();
            sqlDataAdapter.Fill(klinikTable);
            dataGridViewKlinik.DataSource = klinikTable;
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string klinikAdi = textBoxKlinikAdi.Text;

            SqlCommand klinikGetir = new SqlCommand();

            klinikGetir.CommandText = "sp_KlinikEkle";
            klinikGetir.CommandType = CommandType.StoredProcedure;
            klinikGetir.Connection = Baglanti.hastaneConnection;

            klinikGetir.Parameters.AddWithValue("@KlinikAdi", klinikAdi);

            Baglanti.hastaneConnection.Open();

            int etkilenenSatirSayisi = klinikGetir.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kayıt Başarılı");
                KlinikGetir();
            }

            else
            {
                MessageBox.Show("Kayıt Ekleme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand klinikSil = new SqlCommand();

            klinikSil.CommandText = "sp_KlinikSil";
            klinikSil.CommandType = CommandType.StoredProcedure;
            klinikSil.Connection = Baglanti.hastaneConnection;

            klinikSil.Parameters.AddWithValue("@KlinikID", textBoxKlinikAdi.Tag);

            Baglanti.hastaneConnection.Open();

            int etkilenenSatirSayisi = klinikSil.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Silme Başarılı");
                KlinikGetir();
            }

            else
            {
                MessageBox.Show("Kayıt Silme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand klinikGuncelle = new SqlCommand();

            klinikGuncelle.CommandText = "sp_KlinikGuncelle";
            klinikGuncelle.CommandType = CommandType.StoredProcedure;
            klinikGuncelle.Connection = Baglanti.hastaneConnection;

            klinikGuncelle.Parameters.AddWithValue("@KlinikAdi", textBoxKlinikAdi.Text);
            klinikGuncelle.Parameters.AddWithValue("@KlinikID", textBoxKlinikAdi.Tag);

            Baglanti.hastaneConnection.Open();

            int etkilenenSatirSayisi = klinikGuncelle.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Güncelleme Başarılı");
                KlinikGetir();
            }

            else
            {
                MessageBox.Show("Güncelleme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();
        }

        private void KlinikEkleForm_Load(object sender, EventArgs e)
        {
            KlinikGetir();
        }

        private void dataGridViewKlinik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxKlinikAdi.Text = dataGridViewKlinik.CurrentRow.Cells["KlinikAdi"].Value.ToString();
            textBoxKlinikAdi.Tag = dataGridViewKlinik.CurrentRow.Cells["KlinikID"].Value;
        }
    }
}
