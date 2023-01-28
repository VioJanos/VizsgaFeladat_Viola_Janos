using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asztali_alkalmazas
{
    public partial class frmVendor : Form
    {
        public frmVendor()
        {
            InitializeComponent();
        }

        private void FrmVendor_Load(object sender, EventArgs e)
        {
            tbVendor.Focus();

        }

        private void BtnMentes_Click(object sender, EventArgs e)
        {
            string besznev = "";
            besznev = tbVendor.Text.ToUpper();
            if (vendorExist(besznev) == false)
            {
                string connstring = "SERVER = mysql.nethely.hu;PORT=3306;DATABASE=vizga;UID=vizga;PASSWORD=Janika208";
                MySqlConnection conn;
                conn = new MySqlConnection();
                conn.ConnectionString = connstring;

                conn.Open();
                MySqlCommand cmd;
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into vizga.Suppliers (Suplier_Name) values ('" + besznev + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                tbVendor.Clear();
                MessageBox.Show("Beszállító felépítve!");
            }
            else {
                MessageBox.Show("Ez a bezsállító már létezik!");
                tbVendor.Clear();
            }
            
        }
        private void TbVendor(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMentes.PerformClick();
            }
        }
        static bool vendorExist(string vendor) {
            bool letezik = false;
            if (vendor != "") {
                string connstring = "SERVER = mysql.nethely.hu;PORT=3306;DATABASE=vizga;UID=vizga;PASSWORD=Janika208";
                MySqlConnection conn;
                conn = new MySqlConnection();
                string sqlStr = "";
                conn = new MySqlConnection(connstring);
                conn.Open();
                sqlStr = "select Suplier_Name from vizga.Suppliers where Suplier_Name = '" + vendor + "'";
                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                object van = cmd.ExecuteScalar();
                if (van != null) {
                    letezik = true;
                }

            }
            return letezik;
        }
    }
}
