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

namespace WindowsFormsApp1
{
    public partial class frmInc : Form
    {

        public frmInc()
        {
            InitializeComponent();
            ItemsDGV.ColumnCount = 5;
            ItemsDGV.Columns[0].Name = "Date";
            ItemsDGV.Columns[1].Name = "Supplier";
            ItemsDGV.Columns[2].Name = "Part number";
            ItemsDGV.Columns[3].Name = "Quantity";
            ItemsDGV.Columns[4].Name = "Unit of measure";

            ItemsDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemsDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemsDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemsDGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemsDGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }



        private void FrmInc_Load(object sender, EventArgs e)
        {
            this.tbPn.Enabled = false;
            this.tbQty.Enabled = false;
            this.tbUom.Enabled = false;
            this.tbDate.Text = DateTime.Now.ToString("yyyy.MM.dd.");
            this.tbDate.Enabled = false;


        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {

            if (tbSup.Text != "")
            {
                MySqlConnection conn;
                string vendor = "";
                vendor = tbSup.Text.ToUpper();
                string sqlStr = "";
                string connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";
                conn = new MySqlConnection(connstring);
                conn.Open();
                sqlStr = "select Suplier_Name from vizga.Suppliers where Suplier_Name = '" + vendor + "'";
                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                object van = cmd.ExecuteScalar();
                conn.Close();
                if (van == null)
                {
                    MessageBox.Show("Nem létező beszállító!");
                    tbSup.Clear();
                    tbSup.Focus();
                }
                else {
                    this.tbPn.Enabled = true;
                    this.tbQty.Enabled = true;
                    this.tbUom.Enabled = true;
                    tbPn.Focus();
                }
            }
        }



        private void BtnOk_Click(object sender, EventArgs e)
        {

            string datum;
            string sup;
            int pn;
            double qty;
            string uom;


            datum = tbDate.Text;
            sup = tbSup.Text;
            pn = Convert.ToInt32(tbPn.Text);
            qty = Convert.ToDouble(tbQty.Text);
            uom = tbUom.Text;

            ItemsDGV.Rows.Add(datum, sup, pn, qty, uom);

            emptyTb();

        }
        private void emptyTb()
        {
            tbPn.Text = "";
            tbQty.Text = "";
            tbUom.Text = "";
            tbPn.Focus();

        }
        private void TbUom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.PerformClick();
            }
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            
            MySqlConnection conn;
            string connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";
            conn = new MySqlConnection(connstring);
            foreach(DataGridViewRow row in ItemsDGV.Rows)
            {
                int hanyadik = 0;
                int pn = 0;
                MySqlDataReader dr;
                pn = Convert.ToInt32(ItemsDGV.Rows[hanyadik].Cells[2].Value);
                int beerk = 0;
                beerk = Convert.ToInt32(ItemsDGV.Rows[hanyadik].Cells[3].Value);
                int ossz = 0;
                MySqlCommand cmd;
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select PartNumber, Pcs, Location from vizga.WarehouseStock where PartNumber = '" + pn + "' and Location = '11'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int db = 0;
                    db = Convert.ToInt32(dr["Pcs"]);
                    ossz = beerk + db;
                    dr.Close();
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update vizga.WarehouseStock set Pcs = '" + ossz + "' where PartNumber = '" + pn + "' and Location = '11'";
                    cmd.ExecuteNonQuery();
                    var dgRow = ItemsDGV.Rows[hanyadik];
                    ItemsDGV.Rows.Remove(dgRow);
                    conn.Close();
                }
                
            }
            MessageBox.Show("A könyvelés sikeres volt!");
        }

        private void TbSup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheck.PerformClick();
            }
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
                    sqlStr = "select PartNumber from vizga.Material where PartNumber = '" + p + "'";
                    MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                    object van = cmd.ExecuteScalar();
                    if (van == null)
                    {
                        MessageBox.Show("Nem létező anyagszám!");
                        tbPn.Clear();
                        tbPn.Focus();
                    }
                    else {
                        sqlStr = "select Measure from vizga.Material where PartNumber = '" + p + "'";
                        cmd = new MySqlCommand(sqlStr, conn);
                        string m = cmd.ExecuteScalar().ToString();
                        tbUom.Text = m;
                        tbUom.Enabled = false;
                        tbQty.Focus();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TbQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.PerformClick();
            }
        }
    }
}
