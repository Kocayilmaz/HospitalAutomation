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
    public partial class DoktorEkleForm : Form
    {
        public DoktorEkleForm()
        {
            InitializeComponent();
        }
        object KlinikID;
        private void DoktorGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Doktor", Baglanti.hastaneConnection);
            DataTable doktorTable = new DataTable();
            da.Fill(doktorTable);
            dataGridViewDoktor.DataSource = doktorTable;
            dataGridViewDoktor.Columns["DoktorID"].Visible = false;
        }
        private void comboBoxKlinikAdGetir()
        {
            SqlCommand klinikAdGetir = new SqlCommand();
            klinikAdGetir.CommandText = String.Format("SELECT KlinikAdi from Klinik");
            klinikAdGetir.Connection = Baglanti.hastaneConnection;
            SqlDataReader dr;
            Baglanti.hastaneConnection.Open();
            dr = klinikAdGetir.ExecuteReader();

            while(dr.Read())
            {
                comboBoxKlinikID.Items.Add(dr["KlinikAdi"]);
            }
            Baglanti.hastaneConnection.Close();
        }
        private void DoktorEkleForm_Load(object sender, EventArgs e)
        {
            DoktorGetir();
            comboBoxKlinikAdGetir();
            comboBoxDoktor.SelectedIndex = 0;
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            try {
                if (textBoxDoktorTC.Text == "" || textBoxDoktorAdi.Text == "" || textBoxDoktorSoyad.Text == "" || textBoxDoktorCinsiyet.Text == "" || textBoxDoktorDogumTarihi.Text == "" || comboBoxKlinikID.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }
                if (textBoxDoktorTC.Text.Length < 11)
                {
                    MessageBox.Show("TC'yi yanlış girdiniz.");
                    return;
                }
                SqlCommand KlinikIDGetir = new SqlCommand("select KlinikID from Klinik where KlinikAdi = @KlinikAd", Baglanti.hastaneConnection);
                KlinikIDGetir.Parameters.AddWithValue("@KlinikAd", comboBoxKlinikID.Text);
                SqlDataReader dr;
                Baglanti.hastaneConnection.Open();
                dr = KlinikIDGetir.ExecuteReader();
                while (dr.Read())
                {
                    KlinikID = dr["KlinikID"];
                }
                Baglanti.hastaneConnection.Close();

            SqlCommand doktorEkle = new SqlCommand("sp_DoktorEkle", Baglanti.hastaneConnection);
                doktorEkle.CommandType = CommandType.StoredProcedure;
                doktorEkle.Parameters.Add("@KlinikID", SqlDbType.TinyInt);
                doktorEkle.Parameters.Add("@DoktorTC", SqlDbType.BigInt);
                doktorEkle.Parameters.Add("@DoktorAD", SqlDbType.VarChar, 50);
                doktorEkle.Parameters.Add("@DoktorSoyad", SqlDbType.VarChar, 20);
                doktorEkle.Parameters.Add("@DoktorCinsiyet", SqlDbType.Char, 1);
                doktorEkle.Parameters.Add("@DoktorDogumTarihi", SqlDbType.Date);

                doktorEkle.Parameters["@KlinikID"].Value = Convert.ToInt32(KlinikID);
                doktorEkle.Parameters["@DoktorTC"].Value = Convert.ToInt64(textBoxDoktorTC.Text);
                doktorEkle.Parameters["@DoktorAD"].Value = textBoxDoktorAdi.Text;
                doktorEkle.Parameters["@DoktorSoyad"].Value = textBoxDoktorSoyad.Text;
                doktorEkle.Parameters["@DoktorCinsiyet"].Value = textBoxDoktorCinsiyet.Text;
                doktorEkle.Parameters["@DoktorDogumTarihi"].Value = Convert.ToDateTime(textBoxDoktorDogumTarihi.Text);

                SqlDataAdapter da = new SqlDataAdapter(doktorEkle);

                Baglanti.hastaneConnection.Open();


                int etkilenenSatirSayisi = doktorEkle.ExecuteNonQuery();

                if (etkilenenSatirSayisi > 0)
                {
                    MessageBox.Show("Kayıt Başarılı");
                    DoktorGetir();
                }
                else
                {
                    MessageBox.Show("Kayıt Ekleme Sırasında Bir Şeyler Ters Gitti");
                }

                Baglanti.hastaneConnection.Close();
            }

            catch {
                MessageBox.Show("Bilgileri hatalı girdiniz.");
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
          

            if (textBoxDoktorID.Text == "")
            {
                MessageBox.Show("Lütfen Doktor ID alanını doldurunuz.");
                return;
            }

            int doktorID = Convert.ToInt32(textBoxDoktorID.Text);

            SqlCommand doktorSil = new SqlCommand("sp_DoktorSil", Baglanti.hastaneConnection);
            doktorSil.CommandType = CommandType.StoredProcedure;
            doktorSil.Parameters.Add("@DoktorID", SqlDbType.Int);
            doktorSil.Parameters["@DoktorID"].Value = Convert.ToInt32(textBoxDoktorID.Text);
            Baglanti.hastaneConnection.Open();
           
            int etkilenenSatirSayisi = doktorSil.ExecuteNonQuery();
           
            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Silme İşlemi Başarılı");
                DoktorGetir();
            }
           
            else
            {
                MessageBox.Show("Silme İşlemi Sırasında Bir Şeyler Ters Gitti");
            }
            Baglanti.hastaneConnection.Close();


            SqlCommand KlinikIDGetir = new SqlCommand("select KlinikID from Klinik where KlinikAdi = @KlinikAd", Baglanti.hastaneConnection);
            KlinikIDGetir.Parameters.AddWithValue("@KlinikAd", comboBoxKlinikID.Text);
            SqlDataReader dr;
            Baglanti.hastaneConnection.Open();
            dr = KlinikIDGetir.ExecuteReader();
            while (dr.Read())
            {
                KlinikID = dr["KlinikID"];
            }
            Baglanti.hastaneConnection.Close();

            SqlCommand silinenDoktorEkle = new SqlCommand("sp_SilinennDoktorEkle", Baglanti.hastaneConnection);
            silinenDoktorEkle.CommandType = CommandType.StoredProcedure;
            silinenDoktorEkle.Parameters.Add("@DoktorID", SqlDbType.TinyInt);
            silinenDoktorEkle.Parameters.Add("@KlinikID", SqlDbType.TinyInt);
            silinenDoktorEkle.Parameters.Add("@DoktorTC", SqlDbType.BigInt);
            silinenDoktorEkle.Parameters.Add("@DoktorAD", SqlDbType.VarChar, 50);
            silinenDoktorEkle.Parameters.Add("@DoktorSoyad", SqlDbType.VarChar, 20);
            silinenDoktorEkle.Parameters.Add("@DoktorCinsiyet", SqlDbType.Char, 1);
            silinenDoktorEkle.Parameters.Add("@DoktorDogumTarihi", SqlDbType.Date);
            

            silinenDoktorEkle.Parameters["@DoktorID"].Value = Convert.ToInt32(textBoxDoktorID.Text);
            silinenDoktorEkle.Parameters["@KlinikID"].Value = Convert.ToInt32(KlinikID);
            silinenDoktorEkle.Parameters["@DoktorTC"].Value = Convert.ToInt64(textBoxDoktorTC.Text);
            silinenDoktorEkle.Parameters["@DoktorAD"].Value = textBoxDoktorAdi.Text;
            silinenDoktorEkle.Parameters["@DoktorSoyad"].Value = textBoxDoktorSoyad.Text;
            silinenDoktorEkle.Parameters["@DoktorCinsiyet"].Value = textBoxDoktorCinsiyet.Text;
            silinenDoktorEkle.Parameters["@DoktorDogumTarihi"].Value = Convert.ToDateTime(textBoxDoktorDogumTarihi.Text);

            SqlDataAdapter da = new SqlDataAdapter(silinenDoktorEkle);

            Baglanti.hastaneConnection.Open();


            silinenDoktorEkle.ExecuteNonQuery();
            Baglanti.hastaneConnection.Close();

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {

            if (textBoxDoktorTC.Text == "" || textBoxDoktorAdi.Text == "" || textBoxDoktorSoyad.Text == "" || textBoxDoktorCinsiyet.Text == "" || textBoxDoktorDogumTarihi.Text == "" || comboBoxKlinikID.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            if (textBoxDoktorID.Text == "")
            {
                MessageBox.Show("Lütfen Doktor ID alanını doldurunuz.");
                return;
            }

            if (textBoxDoktorTC.Text.Length < 11)
            {
                MessageBox.Show("TC'yi yanlış girdiniz.");
                return;
            }

            SqlCommand KlinikIDGetir = new SqlCommand("select KlinikID from Klinik where KlinikAdi = @KlinikAd", Baglanti.hastaneConnection);
            KlinikIDGetir.Parameters.AddWithValue("@KlinikAd", comboBoxKlinikID.Text);
            SqlDataReader dr;
            Baglanti.hastaneConnection.Open();
            dr = KlinikIDGetir.ExecuteReader();
            while (dr.Read())
            {
                KlinikID = dr["KlinikID"];
            }
            Baglanti.hastaneConnection.Close();

            SqlCommand doktorGuncelle = new SqlCommand("sp_DoktorGuncelle", Baglanti.hastaneConnection);
            doktorGuncelle.CommandType = CommandType.StoredProcedure;
            doktorGuncelle.Parameters.Add("@DoktorID", SqlDbType.Int);
            doktorGuncelle.Parameters.Add("@KlinikID", SqlDbType.TinyInt);
            doktorGuncelle.Parameters.Add("@DoktorTC", SqlDbType.BigInt);
            doktorGuncelle.Parameters.Add("@DoktorAD", SqlDbType.VarChar, 50);
            doktorGuncelle.Parameters.Add("@DoktorSoyad", SqlDbType.VarChar, 20);
            doktorGuncelle.Parameters.Add("@DoktorCinsiyet", SqlDbType.Char, 1);
            doktorGuncelle.Parameters.Add("@DoktorDogumTarihi", SqlDbType.Date);

            doktorGuncelle.Parameters["@DoktorID"].Value = Convert.ToInt32(textBoxDoktorID.Text);
            doktorGuncelle.Parameters["@KlinikID"].Value = Convert.ToInt32(KlinikID);
            doktorGuncelle.Parameters["@DoktorTC"].Value = Convert.ToInt64(textBoxDoktorTC.Text);
            doktorGuncelle.Parameters["@DoktorAD"].Value = textBoxDoktorAdi.Text;
            doktorGuncelle.Parameters["@DoktorSoyad"].Value = textBoxDoktorSoyad.Text;
            doktorGuncelle.Parameters["@DoktorCinsiyet"].Value = textBoxDoktorCinsiyet.Text;
            doktorGuncelle.Parameters["@DoktorDogumTarihi"].Value = Convert.ToDateTime(textBoxDoktorDogumTarihi.Text);


            Baglanti.hastaneConnection.Open();


            int etkilenenSatirSayisi = doktorGuncelle.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Güncelleme Başarılı");
                DoktorGetir();
            }
            else
            {
                MessageBox.Show("Güncelleme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();
        }


        private void buttonAra_Click(object sender, EventArgs e)
        {
          
           if (comboBoxDoktor.SelectedIndex == 0)
           {
              SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

             SqlCommand doktorAdGetir = new SqlCommand();
             doktorAdGetir.CommandText = "sp_DoktorAdAra";
             doktorAdGetir.CommandType = CommandType.StoredProcedure;
             doktorAdGetir.Parameters.AddWithValue("@DoktorAd", textBoxArama.Text);
             doktorAdGetir.Connection = Baglanti.hastaneConnection;

             sqlDataAdapter.SelectCommand = doktorAdGetir;
             DataTable hastaTable = new DataTable();
             sqlDataAdapter.Fill(hastaTable);
             dataGridViewDoktor.DataSource = hastaTable;
            }

           else if (comboBoxDoktor.SelectedIndex == 1)
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                SqlCommand doktorGetir = new SqlCommand();
                doktorGetir.CommandText = string.Format("SELECT * FROM Doktor WHERE DoktorSoyad LIKE '%{0}%'", textBoxArama.Text.ToString());
                doktorGetir.Connection = Baglanti.hastaneConnection;

                sqlDataAdapter.SelectCommand = doktorGetir;
                DataTable hastaTable = new DataTable();
                sqlDataAdapter.Fill(hastaTable);
                dataGridViewDoktor.DataSource = hastaTable;
            }

            else if (comboBoxDoktor.SelectedIndex == 2)
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                SqlCommand doktorGetir = new SqlCommand();
                doktorGetir.CommandText = string.Format("SELECT * FROM Doktor WHERE DoktorCinsiyet LIKE '%{0}%'", textBoxArama.Text.ToString());
                doktorGetir.Connection = Baglanti.hastaneConnection;

                sqlDataAdapter.SelectCommand = doktorGetir;
                DataTable hastaTable = new DataTable();
                sqlDataAdapter.Fill(hastaTable);
                dataGridViewDoktor.DataSource = hastaTable;
            }

            else if (comboBoxDoktor.SelectedIndex == 3)
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                SqlCommand doktorGetir = new SqlCommand();
                doktorGetir.CommandText = string.Format("SELECT * FROM Doktor WHERE DoktorTC LIKE '%{0}%'", textBoxArama.Text);
                doktorGetir.Connection = Baglanti.hastaneConnection;

                sqlDataAdapter.SelectCommand = doktorGetir;
                DataTable hastaTable = new DataTable();
                sqlDataAdapter.Fill(hastaTable);
                dataGridViewDoktor.DataSource = hastaTable;
            }
        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            DoktorGetir();
            textBoxArama.Text = "";
        }

        private void dataGridViewDoktor_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            KlinikID= dataGridViewDoktor.CurrentRow.Cells["KlinikID"];
            SqlCommand klinikAdGetir = new SqlCommand();
            klinikAdGetir.CommandText = String.Format("SELECT KlinikAdi from Klinik where KlinikID=@KlinikID");
            klinikAdGetir.Connection = Baglanti.hastaneConnection;
            klinikAdGetir.Parameters.AddWithValue("@KlinikID", dataGridViewDoktor.CurrentRow.Cells["KlinikID"].Value.ToString());
            SqlDataReader dr;
            Baglanti.hastaneConnection.Open();
            dr = klinikAdGetir.ExecuteReader();

            while (dr.Read())
            {
                comboBoxKlinikID.Text=Convert.ToString(dr["KlinikAdi"]);
            }
            Baglanti.hastaneConnection.Close();

            textBoxDoktorID.Text = dataGridViewDoktor.CurrentRow.Cells[0].Value.ToString();
            textBoxDoktorTC.Text = dataGridViewDoktor.CurrentRow.Cells[2].Value.ToString();
            textBoxDoktorAdi.Text = dataGridViewDoktor.CurrentRow.Cells[3].Value.ToString();
            textBoxDoktorSoyad.Text = dataGridViewDoktor.CurrentRow.Cells[4].Value.ToString();  
            textBoxDoktorCinsiyet.Text = dataGridViewDoktor.CurrentRow.Cells[5].Value.ToString();
            textBoxDoktorDogumTarihi.Text = dataGridViewDoktor.CurrentRow.Cells[6].Value.ToString();
            dateTimePickerDogum.Text = dataGridViewDoktor.CurrentRow.Cells["DoktorDogumTarihi"].Value.ToString();
        }
       

        private void textBoxDoktorTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Harf Girmeyiniz.");
            }
        }

        private void textBoxDoktorDogumTarihi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Harf Girmeyiniz.");
            }
        }

        private void dateTimePickerDogum_ValueChanged(object sender, EventArgs e)
        {
            textBoxDoktorDogumTarihi.Text = dateTimePickerDogum.Value.ToString("yyyy-MM-dd");
        }

        private void textBoxDoktorCinsiyet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Rakam Girmeyiniz.");
            }
            else if (!char.IsControl(e.KeyChar) && ((e.KeyChar.ToString() != "E") && (e.KeyChar.ToString() != "K") && (e.KeyChar.ToString() != "e") && (e.KeyChar.ToString() != "k")))
            {
                e.Handled = true;
                MessageBox.Show("Sadece E veya K harfini giriniz.");
            }
        }

    }
    }
