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
    public partial class DisaridanDoktorEklemeForm : Form
    {
        public DisaridanDoktorEklemeForm()
        {
            InitializeComponent();
        }

        private void VeriCek(string filePath)
        {
            DataTable dt = new DataTable();
            string[] satirlar = System.IO.File.ReadAllLines(filePath);
            if (satirlar.Length > 0)
            {
                //ilk satır başlık satırımız
                string ilkSatir = satirlar[0];
                string[] basliklar = ilkSatir.Split(',');
                foreach (string baslik in basliklar)
                {
                    dt.Columns.Add(new DataColumn(baslik));
                }
                //Veriler için kodlarımız
                for (int i = 1; i < satirlar.Length; i++)
                {
                    string[] veriler = satirlar[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string veri in basliklar)
                    {
                        dr[veri] = veriler[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridViewCsvDoktor.DataSource = dt;
            }

        }
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxCsvDoktorEkle.Text = openFileDialog1.FileName;
            VeriCek(textBoxCsvDoktorEkle.Text);
        }

        private void buttonCsvSqlEklw_Click(object sender, EventArgs e)
        {
            SqlCommand doktorEkle = new SqlCommand("sp_DoktorEkle", Baglanti.hastaneConnection);
            doktorEkle.CommandType = CommandType.StoredProcedure;
            doktorEkle.Parameters.Add("@KlinikID", SqlDbType.TinyInt);
            doktorEkle.Parameters.Add("@DoktorTC", SqlDbType.VarChar, 11);
            doktorEkle.Parameters.Add("@DoktorAD", SqlDbType.VarChar, 50);
            doktorEkle.Parameters.Add("@DoktorSoyad", SqlDbType.VarChar, 20);
            doktorEkle.Parameters.Add("@DoktorCinsiyet", SqlDbType.Char, 1);
            doktorEkle.Parameters.Add("@DoktorDogumTarihi", SqlDbType.Date);

            doktorEkle.Parameters["@KlinikID"].Value = Convert.ToInt32(dataGridViewCsvDoktor.CurrentRow.Cells[0].Value.ToString());
            doktorEkle.Parameters["@DoktorTC"].Value = dataGridViewCsvDoktor.CurrentRow.Cells[1].Value.ToString();
            doktorEkle.Parameters["@DoktorAD"].Value = dataGridViewCsvDoktor.CurrentRow.Cells[2].Value.ToString();
            doktorEkle.Parameters["@DoktorSoyad"].Value = dataGridViewCsvDoktor.CurrentRow.Cells[3].Value.ToString();
            doktorEkle.Parameters["@DoktorCinsiyet"].Value = dataGridViewCsvDoktor.CurrentRow.Cells[4].Value.ToString();
            doktorEkle.Parameters["@DoktorDogumTarihi"].Value = Convert.ToDateTime(dataGridViewCsvDoktor.CurrentRow.Cells[5].Value.ToString());

            //SqlDataAdapter da = new SqlDataAdapter(doktorEkle);

            Baglanti.hastaneConnection.Open();


            int etkilenenSatirSayisi = doktorEkle.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Ekleme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();
        }

        private void DisaridanDoktorEklemeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
