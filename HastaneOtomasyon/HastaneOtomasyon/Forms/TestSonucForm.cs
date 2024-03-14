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
    public partial class TestSonucForm : Form
    {
        public TestSonucForm()
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
            dataGridViewTestSonuc.DataSource = hastaTable;
        }

        private void TestSonucForm_Load(object sender, EventArgs e)
        {
            TestGetir();
        }
    }
}
