using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyon.Forms
{
    public partial class YedeklemeIslemleriForm : Form
    {
        public YedeklemeIslemleriForm()
        {
            InitializeComponent();
        }

 
        private void YedeklemeIslemleriForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonYedekAl_Click(object sender, EventArgs e)
        {

            string database = Baglanti.hastaneConnection.Database.ToString();


            if(textBoxKonum.Text == string.Empty)
            {
                MessageBox.Show("Lütfen yedekleme işlemi için bir konum seçiniz.");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK ='" + textBoxKonum.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".bak'";

                if (Baglanti.hastaneConnection.State == ConnectionState.Open)
                       Baglanti.hastaneConnection.Close();

                Baglanti.hastaneConnection.Open();

                SqlCommand command = new SqlCommand(cmd, Baglanti.hastaneConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Veritabanı başarılı bir şekilde yedeklendi.");
                Baglanti.hastaneConnection.Close();
                buttonYedekAl.Enabled = false;

            }
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK ){
                textBoxKonum.Text = dlg.SelectedPath;
                buttonYedekAl.Enabled = true;
            }
        }

        private void buttonYedektenDon_Click(object sender, EventArgs e)
        {
            string database = Baglanti.hastaneConnection.Database.ToString();
            if (Baglanti.hastaneConnection.State == ConnectionState.Open)
                Baglanti.hastaneConnection.Close();
            Baglanti.hastaneConnection.Open();

            try
            {
                string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ");
                SqlCommand cmd1 = new SqlCommand(str1, Baglanti.hastaneConnection);
                cmd1.ExecuteNonQuery();

                string str2 = "Use MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBoxKonom2.Text + "' WITH REPLACE";
                SqlCommand cmd2 = new SqlCommand(str2, Baglanti.hastaneConnection);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, Baglanti.hastaneConnection);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Veritabanı başarılı bir şekilde yedekten döndü.");
                Baglanti.hastaneConnection.Close();

            }
            catch
            {
                MessageBox.Show("Yedekten dönerken bir hata oluştu lütfen tekrar deneyin.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxKonom2.Text = dlg.FileName;
                button1.Enabled = true;

            }

        }
    }
}
