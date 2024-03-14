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
    public partial class LaboratuvarEkleForm : Form
    {
        public LaboratuvarEkleForm()
        {
            InitializeComponent();
        }

        private void LaboratuvarGetir()
        {

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand laboratuvarGetirCommand = new SqlCommand();
            laboratuvarGetirCommand.CommandText = "sp_LaboratuvarGetir";
            laboratuvarGetirCommand.CommandType = CommandType.StoredProcedure;
            laboratuvarGetirCommand.Connection = Baglanti.hastaneConnection;

            sqlDataAdapter.SelectCommand = laboratuvarGetirCommand;
            DataTable laboratuvarTable = new DataTable();
            sqlDataAdapter.Fill(laboratuvarTable);
            dataGridViewLaboratuvar.DataSource = laboratuvarTable;
        }
        private void LaboratuarEkle_Load(object sender, EventArgs e)
        {
            LaboratuvarGetir();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand laboratuvarSil = new SqlCommand("sp_LaboratuvarSil", Baglanti.hastaneConnection);
            laboratuvarSil.CommandType = CommandType.StoredProcedure;
            laboratuvarSil.Parameters.Add("@LabID", SqlDbType.Int);
            laboratuvarSil.Parameters["@LabID"].Value = textBoxLaboratuvarAdi.Tag;
            Baglanti.hastaneConnection.Open();

            int etkilenenSatirSayisi = laboratuvarSil.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Silme Başarılı");
                LaboratuvarGetir();
            }
            else
            {
                MessageBox.Show("Silme Sırasında Bir Şeyler Ters Gitti");

            }

            Baglanti.hastaneConnection.Close();

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (textBoxLaboratuvarAdi.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            SqlCommand laboratuvarGuncelle = new SqlCommand("sp_LaboratuvarGuncelle", Baglanti.hastaneConnection);
            laboratuvarGuncelle.CommandType = CommandType.StoredProcedure;
            laboratuvarGuncelle.Parameters.Add("@LabAdi",SqlDbType.VarChar,50);
            laboratuvarGuncelle.Parameters.Add("@LabID", SqlDbType.TinyInt);
            laboratuvarGuncelle.Parameters["@LabID"].Value = textBoxLaboratuvarAdi.Tag;
            laboratuvarGuncelle.Parameters["@LabAdi"].Value = textBoxLaboratuvarAdi.Text;

            Baglanti.hastaneConnection.Open();

            int etkilenenSatirSayisi = laboratuvarGuncelle.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Güncelleme Başarılı");
                LaboratuvarGetir();
            }
            else
            {
                MessageBox.Show("Güncelleme Sırasında Bir Şeyler Ters Gitti");

            }

            Baglanti.hastaneConnection.Close();

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (textBoxLaboratuvarAdi.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            string laboratuvarAdi = textBoxLaboratuvarAdi.Text;

            SqlCommand laboratuvarGetirCommand = new SqlCommand();

            laboratuvarGetirCommand.CommandText = "sp_LaboratuvarEkle";
            laboratuvarGetirCommand.CommandType = CommandType.StoredProcedure;
            laboratuvarGetirCommand.Connection = Baglanti.hastaneConnection;

            laboratuvarGetirCommand.Parameters.AddWithValue("@LabAdi", laboratuvarAdi);

            Baglanti.hastaneConnection.Open();

            int etkilenenSatirSayisi = laboratuvarGetirCommand.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kayıt Başarılı");
                LaboratuvarGetir();
            }

            else
            {
                MessageBox.Show("Kayıt Ekleme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();
        }

        private void dataGridViewLaboratuvar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxLaboratuvarAdi.Text = dataGridViewLaboratuvar.CurrentRow.Cells["LabAdi"].Value.ToString();
            textBoxLaboratuvarAdi.Tag = dataGridViewLaboratuvar.CurrentRow.Cells["LabID"].Value;
        }
    }
}
