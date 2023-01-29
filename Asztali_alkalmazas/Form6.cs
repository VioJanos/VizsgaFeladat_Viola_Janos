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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            dgvSales.ColumnCount = 4;
            dgvSales.Columns[0].Name = "Termék";
            dgvSales.Columns[1].Name = "Mennyiség";
            dgvSales.Columns[2].Name = "Egységár";
            dgvSales.Columns[3].Name = "Total";
            dgvSales.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSales.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSales.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSales.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void TbPn_Leave(object sender, EventArgs e)
        {
            MySqlConnection conn;
            string sqlStr = "";
            string connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";
            conn = new MySqlConnection(connstring);
            int p;
            try
            {

                if (tbPn.Text != "")
                {
                    p = Convert.ToInt32(tbPn.Text);
                    conn.Open();
                    sqlStr = "select PartNumber, Measure from vizga.Material where PartNumber = '" + p + "'";
                    MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                    object van = cmd.ExecuteScalar();
                    if (van == null)
                    {
                        MessageBox.Show("Nem létező anyagszám!");
                        tbPn.Clear();
                        tbPn.Focus();
                    }
                    else
                    {
                        sqlStr = "select Price from vizga.PriceList where PartNumber = '" + p + "'";
                        cmd = new MySqlCommand(sqlStr, conn);
                        van = cmd.ExecuteScalar();
                        if (van == null)
                        {
                            MessageBox.Show("Ehhez a termékhez nincs elmentett ár, az eladás nem lehetséges!");
                            tbPn.Clear();
                            tbPn.Focus();
                        }
                        else {
                            tbPrice.Text = Convert.ToDouble(van).ToString();
                            tbPrice.Enabled = false;
                            tbPcs.Focus();
                        }

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TbPcs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                int pcs;
                int p = 0;
                try
                {
                    p = Convert.ToInt32(tbPn.Text);
                    pcs = Convert.ToInt32(tbPcs.Text);
                    MySqlConnection conn;
                    string sqlStr = "";
                    string connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";
                    conn = new MySqlConnection(connstring);
                    conn.Open();
                    sqlStr = "select Packaging from vizga.PriceList where PartNumber = '" + p + "'";
                    MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                    int van = Convert.ToInt32(cmd.ExecuteScalar());
                    if (tbPrice.Text != "")
                    {
                        tbTotal.Text = Convert.ToString(Convert.ToInt16(tbPcs.Text) * (Convert.ToDouble(tbPrice.Text) / van));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    tbPcs.Clear();
                    tbPcs.Focus();
                }
                btnHozzaad.PerformClick();
                tbPn.Clear();
                tbPcs.Clear();
                tbPrice.Clear();
                tbTotal.Clear();
                tbPn.Focus();

            }
        }

        private void BtnHozzaad_Click(object sender, EventArgs e)
        {
            int termek = 0;
            int db = 0;
            double ar = 0;
            double total = 0;
            double vegossz = 0;
            if (tbFull.Text == "") {
                vegossz = 0;
            }
            else
            {
                vegossz = Convert.ToDouble(tbFull.Text);
            }
            termek = Convert.ToInt32(tbPn.Text);
            try
            {
                db = Convert.ToInt32(tbPcs.Text);
                ar = Convert.ToDouble(tbPrice.Text);
                total = Convert.ToDouble(tbTotal.Text);
                dgvSales.Rows.Add(termek, db, ar, total);
                tbFull.Text = Convert.ToString(vegossz + total * 1.27);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void TbTotal_Enter(object sender, EventArgs e)
        {
            int pcs;
            int p = 0;
            try
            {
                p = Convert.ToInt32(tbPn.Text);
                pcs = Convert.ToInt32(tbPcs.Text);
                MySqlConnection conn;
                string sqlStr = "";
                string connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";
                conn = new MySqlConnection(connstring);
                conn.Open();
                sqlStr = "select Packaging from vizga.PriceList where PartNumber = '" + p + "'";
                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                int van = Convert.ToInt32(cmd.ExecuteScalar());
                if (tbPrice.Text != "")
                {
                    tbTotal.Text = Convert.ToString(Convert.ToInt16(tbPcs.Text) * (Convert.ToDouble(tbPrice.Text) / van));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbPcs.Clear();
                tbPcs.Focus();
            }
            btnHozzaad.PerformClick();
            tbPn.Clear();
            tbPcs.Clear();
            tbPrice.Clear();
            tbTotal.Clear();
            tbPn.Focus();
        }

        private void BtnSold_Click(object sender, EventArgs e)
        {
            int eladPcs = 0;
            int hanyadik = 0;
            string sqlStr = "";
            int volt = 0;
            int lesz = 0;
            MySqlConnection conn;
            int p = 0;
            string connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";
            conn = new MySqlConnection(connstring);
            MySqlCommand cmd;
            conn.Open();
            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                p = Convert.ToInt16(dgvSales.Rows[hanyadik].Cells[0].Value);
                eladPcs = Convert.ToInt16(dgvSales.Rows[hanyadik].Cells[1].Value);
                sqlStr = "select Pcs from vizga.WarehouseStock where PartNumber = '" + p + "' and Location  = '31'";
                cmd = new MySqlCommand(sqlStr, conn);
                volt = Convert.ToInt32(cmd.ExecuteScalar());
                lesz = volt - eladPcs;
                if (lesz < 0)
                {
                    MessageBox.Show("Negatív készletet generálsz, lépj kapcsolatba a készletelemzővel!");
                    sqlStr = "update WarehouseStock set Pcs = '"+lesz+"' where PartNumber =  '" + p + "' and Location = '31'";
                    cmd = new MySqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
                }
                else {
                    sqlStr = "update WarehouseStock set Pcs = '"+ lesz + "' where PartNumber =  '" + p + "' and Location = '31'";
                    cmd = new MySqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
                }
                var dgRow = dgvSales.Rows[hanyadik];
                dgvSales.Rows.Remove(dgRow);
            }
            conn.Close();
            MessageBox.Show("Sikeres eladás!");
        }
    }
    
}
