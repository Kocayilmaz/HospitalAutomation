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
    using exportWord = Microsoft.Office.Interop.Word;
    public partial class ReceteYazForm : Form
    {
        public ReceteYazForm()
        {
            InitializeComponent();
        }

        private void HastalariGetir()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand hastaGetirCommand = new SqlCommand();
            hastaGetirCommand.CommandText = "sp_HastaGetir";
            hastaGetirCommand.CommandType = CommandType.StoredProcedure;
            hastaGetirCommand.Connection = Baglanti.hastaneConnection;

            sqlDataAdapter.SelectCommand= hastaGetirCommand;
            DataTable hastaTable = new DataTable();
            sqlDataAdapter.Fill(hastaTable);
            dataGridViewHasta.DataSource = hastaTable;
            dataGridViewHasta.Columns["HastaID"].Visible= false;
            dataGridViewHasta.Columns["HastaBabaAdi"].Visible= false;
            dataGridViewHasta.Columns["HastaAnneAdi"].Visible= false;
            dataGridViewHasta.Columns["HastaCepTel"].Visible= false;
            dataGridViewHasta.Columns["HastaPosta"].Visible= false;
            dataGridViewHasta.Columns["HastaAdres"].Visible= false;
            dataGridViewHasta.Columns["HastaDogum"].Visible= false;
            dataGridViewHasta.Columns["HastaCinsiyet"].Visible= false;
        }

        private void ReceteleriGetir()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand receteGetirCommand = new SqlCommand();
            receteGetirCommand.CommandText = "sp_RaporGetir";
            receteGetirCommand.CommandType= CommandType.StoredProcedure;
            receteGetirCommand.Connection = Baglanti.hastaneConnection;

            sqlDataAdapter.SelectCommand= receteGetirCommand;
            DataTable receteTable = new DataTable();
            sqlDataAdapter.Fill(receteTable);
            dataGridViewRecete.DataSource = receteTable;

        }
        private void ReceteYaz_Load(object sender, EventArgs e)
        {
            HastalariGetir();
            ReceteleriGetir();
        }

        private void dataGridViewHasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxHastaID.Text = dataGridViewHasta.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            string hastaId = textBoxHastaID.Text;
            string recete = textBoxReceteYaz.Text;

            SqlCommand receteYazCommand = new SqlCommand();

            receteYazCommand.CommandText = "sp_ReceteKaydet";
            receteYazCommand.CommandType = CommandType.StoredProcedure;
            receteYazCommand.Connection = Baglanti.hastaneConnection;


            receteYazCommand.Parameters.AddWithValue("@HastaID", hastaId);
            receteYazCommand.Parameters.AddWithValue("@ReceteAciklama", recete);

            Baglanti.hastaneConnection.Open();

            int etkilenenSatirSayisi = receteYazCommand.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kayıt Başarılı");
            }

            else
            {
                MessageBox.Show("Kayıt Ekleme Sırasında Bir Şeyler Ters Gitti");
            }

            Baglanti.hastaneConnection.Close();

            ReceteleriGetir();

        }
        private void dataGridViewReçete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxReceteYaz.Tag = dataGridViewRecete.CurrentRow.Cells["ReceteID"].Value;
            textBoxHastaID.Text = dataGridViewRecete.CurrentRow.Cells[1].Value.ToString();
            textBoxReceteYaz.Text = dataGridViewRecete.CurrentRow.Cells[2].Value.ToString();

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand receteSilCommand = new SqlCommand();
                receteSilCommand.Connection = Baglanti.hastaneConnection;
                receteSilCommand.CommandText = string.Format("DELETE FROM Recete WHERE ReceteID = {0}", textBoxReceteYaz.Tag);

                Baglanti.hastaneConnection.Open();
                int etkilenenSatirSayisi = receteSilCommand.ExecuteNonQuery();

                if (etkilenenSatirSayisi > 0)
                {
                    MessageBox.Show("Silme Başarılı");
                    ReceteleriGetir();
                }

                else
                {
                    MessageBox.Show("Kayıt Silme Sırasında Bir Şeyler Ters Gitti");
                }

                Baglanti.hastaneConnection.Close();

            }

            catch
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void buttonDosyaYap_Click(object sender, EventArgs e)
        {
                exportWord.Application wordapp = new exportWord.Application();
                wordapp.Visible = true;
                exportWord.Document worddoc;
                object wordobj = System.Reflection.Missing.Value;
                worddoc=wordapp.Documents.Add(ref wordobj);
                wordapp.Selection.TypeText(textBoxReceteYaz.Text);
                wordapp = null;
        }
    }
}
