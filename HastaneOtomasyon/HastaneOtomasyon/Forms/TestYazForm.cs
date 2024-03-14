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
    public partial class TestYazForm : Form
    {
        public TestYazForm()
        {
            InitializeComponent();
        }
        private void TestGetir()
        {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                SqlCommand testGetir = new SqlCommand();
                testGetir.CommandText = "SELECT * FROM Test";
                testGetir.Connection = Baglanti.hastaneConnection;


                sqlDataAdapter.SelectCommand = testGetir;
                DataTable hastaTable = new DataTable();
                sqlDataAdapter.Fill(hastaTable);
                dataGridViewTest.DataSource = hastaTable;
        }
        private void TestYazForm_Load(object sender, EventArgs e)
        {
            TestGetir();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand testEkle = new SqlCommand();

                testEkle.CommandText = string.Format("UPDATE Test SET TestSonuc = '{0}' WHERE TestID = {1}", textBoxTestSonuc.Text, textBoxTestSonuc.Tag);
                testEkle.Connection = Baglanti.hastaneConnection;

                Baglanti.hastaneConnection.Open();

                int etkilenenSatirSayisi = testEkle.ExecuteNonQuery();

                if (etkilenenSatirSayisi > 0)
                {
                    MessageBox.Show("Test Sonuc Başarıyla Eklendi");
                    TestGetir();
                }

                else
                {
                    MessageBox.Show("Test Sonucu Eklerken Bir Şeyler Ters Gitti");
                }

                Baglanti.hastaneConnection.Close();
            }
            catch
            {
                MessageBox.Show("Bir Hata Meydana Geldi Lütfen Kutucukları Boş Bırakmayın.");
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand testSil = new SqlCommand();

                testSil.CommandText = string.Format("DELETE FROM Test WHERE TestID = {0}", textBoxTestSonuc.Tag);
                testSil.Connection = Baglanti.hastaneConnection;

                Baglanti.hastaneConnection.Open();

                int etkilenenSatirSayisi = testSil.ExecuteNonQuery();

                if (etkilenenSatirSayisi > 0)
                {
                    MessageBox.Show("Test Silinmesi Başarıyla Eklendi");
                    TestGetir();
                }

                else
                {
                    MessageBox.Show("Test Silinirken Bir Şeyler Ters Gitti");
                }

                Baglanti.hastaneConnection.Close();
            }
            catch
            {
                MessageBox.Show("Bir Hata Meydana Geldi Lütfen Kutucukları Boş Bırakmayın.");
            }
        }

        private void dataGridViewTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTestSonuc.Tag = dataGridViewTest.CurrentRow.Cells["TestID"].Value;
            textBoxTestSonuc.Text = dataGridViewTest.CurrentRow.Cells["TestSonuc"].Value.ToString();
        }
    }
}
