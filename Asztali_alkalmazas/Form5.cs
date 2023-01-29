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
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        private void TbPn_Leave(object sender, EventArgs e)
        {
            int p;
            try
            {

                if (tbPn.Text != "")
                {
                    p = Convert.ToInt32(tbPn.Text);
                    string sqlStr = "";
                    string connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";
                    conn = new MySqlConnection(connstring);
                    conn.Open();
                    sqlStr = "select PartNumber from vizga.Material where PartNumber = " + p;
                    MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                    object van = cmd.ExecuteScalar();

                    conn.Close();
                    if (van == null)
                    {
                        MessageBox.Show("Nem létező anyagszám!");
                        tbPn.Clear();
                        tbPn.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void BtnMentes_Click(object sender, EventArgs e)
        {
            if (cbHonnan.Text != cbHova.Text)
            {
                string sqlStr = "";
                int pcs = Convert.ToInt32(tbPcs.Text);
                int pn = Convert.ToInt32(tbPn.Text);
                int lesz = 0;
                
                string connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";
                conn = new MySqlConnection(connstring);
                conn.Open();
                sqlStr = "select Pcs from WarehouseStock where PartNumber = '" + pn + "' and Location = '" + cbHonnan.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                object voltPcs = cmd.ExecuteScalar();
                int volt = Convert.ToInt32(voltPcs.ToString());
                lesz = volt - pcs;
                sqlStr = "update WarehouseStock set Pcs = '"+lesz+ "' where Location = '" + cbHonnan.Text + "' and PartNumber = '"+ tbPn.Text + "'";
                cmd = new MySqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();

                sqlStr = "select Pcs from WarehouseStock where PartNumber = '" + pn + "' and Location = '" + cbHova.Text + "'";
                cmd = new MySqlCommand(sqlStr, conn);
                voltPcs = cmd.ExecuteScalar();
                volt = Convert.ToInt32(voltPcs.ToString());
                lesz = volt + pcs;
                sqlStr = "update WarehouseStock set Pcs = '" + lesz + "' where Location = '" + cbHova.Text + "' and PartNumber = '" + tbPn.Text + "'";
                cmd = new MySqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();
                urit();
                conn.Close();
                tbPn.Focus();
            }
            else {
                MessageBox.Show("A két lokáció nem lehet egyező!");
            }
        }

        private void urit() {
            tbPn.Clear();
            tbPcs.Clear();
            cbHova.ResetText();
            cbHonnan.ResetText();
        }

        private void TbPcs_Leave(object sender, EventArgs e)
        {
            try
            {
                int pcs = 0;
                pcs = Convert.ToInt32(tbPcs.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbPcs.Clear();
                tbPcs.Focus();
            }
        }
    }
}
