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
    public partial class TaniEkleForm : Form
    {
        public TaniEkleForm()
        {
            InitializeComponent();
        }
        private void RandevuGetir()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand randevuGetir = new SqlCommand();
            randevuGetir.CommandText = "SELECT Hasta.HastaID,HastaAd,HastaSoyad,HastaTC FROM Hasta INNER JOIN Randevu ON Hasta.HastaID = Randevu.HastaID";
            randevuGetir.Connection = Baglanti.hastaneConnection;

            sqlDataAdapter.SelectCommand = randevuGetir;
            DataTable randevuTable = new DataTable();
            sqlDataAdapter.Fill(randevuTable);
            dataGridViewRandevu.DataSource = randevuTable;
        }
        private void TaniGetir()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand taniGetir = new SqlCommand();
            taniGetir.CommandText = string.Format("SELECT TaniID, TaniAdi,TaniAciklama FROM Tani INNER JOIN Hasta ON Tani.HastaID = Hasta.HastaID WHERE Hasta.HastaID = '{0}'", textBoxHastaID.Text);
            taniGetir.Connection = Baglanti.hastaneConnection;

            sqlDataAdapter.SelectCommand = taniGetir;
            DataTable randevuTable = new DataTable();
            sqlDataAdapter.Fill(randevuTable);
            dataGridViewTani.DataSource = randevuTable;
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            int hastaID = Convert.ToInt32(textBoxHastaID.Text);
            string taniAdi = textBoxTaniAdi.Text;
            string taniAciklama = textBoxTaniAciklama.Text;

            SqlCommand taniEkle = new SqlCommand();
            taniEkle.CommandText = string.Format("INSERT INTO Tani VALUES ({0},'{1}','{2}')", hastaID,taniAdi,taniAciklama);
            taniEkle.Connection = Baglanti.hastaneConnection;

            Baglanti.hastaneConnection.Open();
            int etkilenenSatirSayisi = taniEkle.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kayıt Başarılı");
                RandevuGetir();
                TaniGetir();
            }

            else
            {
                MessageBox.Show("Kayıt Ekleme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand taniSil = new SqlCommand();
            taniSil.CommandText = string.Format("DELETE FROM Tani WHERE TaniID = {0}", textBoxTaniAdi.Tag);
            taniSil.Connection = Baglanti.hastaneConnection;

            Baglanti.hastaneConnection.Open();
            int etkilenenSatirSayisi = taniSil.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Silme Başarılı");
                RandevuGetir();
                TaniGetir();
            }

            else
            {
                MessageBox.Show("Silme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand taniGuncelle = new SqlCommand();
            taniGuncelle.CommandText = string.Format("UPDATE Tani SET TaniAdi = '{0}', TaniAciklama = '{1}' WHERE TaniID = {2}",textBoxTaniAdi.Text, textBoxTaniAciklama.Text,textBoxTaniAdi.Tag);
            taniGuncelle.Connection = Baglanti.hastaneConnection;

            Baglanti.hastaneConnection.Open();
            int etkilenenSatirSayisi = taniGuncelle.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Güncelleme Başarılı");
                RandevuGetir();
                TaniGetir();
            }

            else
            {
                MessageBox.Show("Silme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();
        }

        private void dataGridViewRandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxHastaID.Text = dataGridViewRandevu.CurrentRow.Cells["HastaID"].Value.ToString();
            textBoxHastaAdi.Text = dataGridViewRandevu.CurrentRow.Cells["HastaAd"].Value.ToString();
            textBoxHastaSoyadi.Text = dataGridViewRandevu.CurrentRow.Cells["HastaSoyad"].Value.ToString();
            textBoxHastaTC.Text = dataGridViewRandevu.CurrentRow.Cells["HastaTC"].Value.ToString();
            TaniGetir();
        }

        private void dataGridViewTani_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTaniAdi.Tag = dataGridViewTani.CurrentRow.Cells["TaniID"].Value.ToString();
            textBoxTaniAdi.Text = dataGridViewTani.CurrentRow.Cells["TaniAdi"].Value.ToString();
            textBoxTaniAciklama.Text = dataGridViewTani.CurrentRow.Cells["TaniAciklama"].Value.ToString();
        }

        private void TaniEkleForm_Load(object sender, EventArgs e)
        {
            RandevuGetir();
            TaniGetir();
            textBoxHastaID.ReadOnly = true;
            textBoxHastaTC.ReadOnly = true;
            textBoxHastaAdi.ReadOnly = true;
            textBoxHastaSoyadi.ReadOnly = true;
        }

        private void buttonTestIste_Click(object sender, EventArgs e)
        {
          
                SqlCommand testGonder = new SqlCommand();
                testGonder.CommandText = string.Format("INSERT INTO Test VALUES ({0},{1},'{2}')", textBoxHastaID.Text, textBoxLabID.Text, " ");
                testGonder.Connection = Baglanti.hastaneConnection;

                Baglanti.hastaneConnection.Open();
                int etkilenenSatirSayisi = testGonder.ExecuteNonQuery();

                if (etkilenenSatirSayisi > 0)
                {
                    MessageBox.Show("Test'e Gönderildi");
                    RandevuGetir();
                    TaniGetir();
                }

                else
                {
                    MessageBox.Show("Test'e Gönderirken Bir Şeyler Ters Gitti Lütfen Tekrar Deneyin");
                }

                Baglanti.hastaneConnection.Close();
            

        }

        private void buttonTestSonucGor_Click(object sender, EventArgs e)
        {
            TestSonucForm testSonucForm = new TestSonucForm();
            testSonucForm.Show();
        }
    }
   }

