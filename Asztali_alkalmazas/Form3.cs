using MySql.Data.MySqlClient;
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







namespace WindowsFormsApp1
{
    public partial class frmNewProd : Form
    {
        MySqlConnection conn;
        string connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";


        class Prod
        {
            public int ProdN;
            public string Description;
            public double Kiszereles;
            public string UoM;

            public Prod(int ProdN, string Description, double Kiszereles, string UoM)
            {
                setProdN(ProdN);
                setDescription(Description);
                setKiszereles(Kiszereles);
                setUoM(UoM);
            }

            public void setProdN(int ProdN)
            {
                if (ProdN != 0)
                {
                    this.ProdN = ProdN;
                }
            }
            public void setDescription(string Description)
            {
                if (Description != "")
                {
                    this.Description = Description;
                }
            }
            public void setKiszereles(double Kiszereles)
            {
                if (Kiszereles != 0)
                {
                    this.Kiszereles = Kiszereles;
                }
            }
            public void setUoM(string UoM)
            {
                if (UoM != "")
                {
                    this.UoM = UoM;
                }
            }

        }


        class prodPrice
        {
            public int prodNum;
            public double prodP;
            public string currency;
            public int per;

            public prodPrice(int prodNum, double prodP, string currency, int per)
            {
                setProdNum(prodNum);
                setProdP(prodP);
                setCurrency(currency);
                setPer(per);
            }

            public void setProdNum(int prodNum)
            {
                if (prodNum != 0)
                {
                    this.prodNum = prodNum;
                }

            }
            public void setProdP(double prodP)
            {
                if (prodP != 0)
                {
                    this.prodP = prodP;
                }
            }
            public void setCurrency(string currency)
            {
                if (currency != "")
                {
                    this.currency = currency;
                }
            }
            public void setPer(int per)
            {
                if (per != 0)
                {
                    this.per = per;
                }

            }
        }

        public frmNewProd()
        {
            InitializeComponent();
        }

        private void FrmNewProd_Load(object sender, EventArgs e)
        {
            gbNewProd.Visible = false;
            gbPricing.Visible = false;
        }

        private void BtnCreateNewProd_Click(object sender, EventArgs e)
        {
            gbPricing.Visible = false;
            gbNewProd.Visible = true;
            tbPart.Focus();


        }

        private void BtnPricing_Click(object sender, EventArgs e)
        {
            gbPricing.Visible = true;
            gbNewProd.Visible = false;
            tbPn.Focus();
        }

        private void BtnSavePart_Click(object sender, EventArgs e)
        {
            int ProdN = 0;
            string Description = "";
            double Kiszereles = 0;
            string UoM = "";


            try
            {
                if (tbPart.Text != "")
                {
                    ProdN = Convert.ToInt32(tbPart.Text);
                    if (tbDescription.Text != "")
                    {
                        Description = tbDescription.Text.ToUpper();
                        if (tbKiszereles.Text != "")
                        {
                            Kiszereles = Convert.ToDouble(tbKiszereles.Text);

                            if (cbUom.Text != "")
                            {
                                UoM = cbUom.Text;
                                Prod pr = new Prod(ProdN, Description, Kiszereles, UoM);
                            }
                            else
                            {
                                MessageBox.Show("Válassz mértékegységet");
                            }
                        }
                        else
                        {
                            MessageBox.Show("A kiszerelés mező nem lehet üres");
                            tbKiszereles.Select();
                        }
                    }
                    else
                    {
                        MessageBox.Show("A megnevezés mező nem lehet üres");
                        tbDescription.Select();
                    }
                }
                else
                {
                    MessageBox.Show("A cikkszám mező nem lehet üres");
                    tbPart.Select();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbPart.Text = "";
                tbPart.Select();
            }
            connstring = "SERVER = mysql.nethely.hu;PORT=3306;DATABASE=vizga;UID=vizga;PASSWORD=Janika208";
            conn = new MySqlConnection();
            conn.ConnectionString = connstring;

            conn.Open();
            MySqlCommand cmd;
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into vizga.Material (Materialname, Packing, Measure, PartNumber) values ('" + Description + "', '" + Kiszereles + "', '" + UoM + "', '" + ProdN + "')";
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into vizga.WarehouseStock ( PartNumber, Pcs, Location ) values ('" + ProdN + "', 0, 11)";
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into vizga.WarehouseStock ( PartNumber, Pcs, Location ) values ('" + ProdN + "', 0, 21)";
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into vizga.WarehouseStock ( PartNumber, Pcs, Location ) values ('" + ProdN + "', 0, 31)";
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into vizga.WarehouseStock ( PartNumber, Pcs, Location ) values ('" + ProdN + "', 0, 41)";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Új anyag felépítve");
            urit();
        }

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

                    if (van == null)
                    {
                        MessageBox.Show("Ez anyag anyagszám nem létezik a Material táblában!");
                        tbPn.Clear();
                        tbPn.Focus();
                    }
                    sqlStr = "select PartNumber from vizga.PriceList where PartNumber = " + p;
                    MySqlCommand cmd2 = new MySqlCommand(sqlStr, conn);
                    object let = cmd2.ExecuteScalar();
                    if (let != null)
                    {
                        MessageBox.Show("Ez anyag anyagszám már be van árazva!");
                        tbPn.Clear();
                        tbPn.Focus();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int prodNum = 0;
            double prodP = 0;
            string currency = "";
            int per = 0;

            try
            {
                prodNum = Convert.ToInt32(tbPn.Text);
                if (tbPn.Text != "")
                {
                    prodNum = Convert.ToInt32(tbPn.Text);
                    if (tbPrice.Text != "")
                    {
                        prodP = Convert.ToDouble(tbPrice.Text);
                        if (tbCurrency.Text != "")
                        {
                            currency = tbCurrency.Text;
                            if (tbPer.Text != "")
                            {
                                per = Convert.ToInt32(tbPer.Text);
                                prodPrice ppr = new prodPrice(prodNum, prodP, currency, per);
                            }
                            else
                            {
                                MessageBox.Show("A per mező nem lehet üres!");
                                tbPer.Select();
                            }
                        }
                        else
                        {
                            MessageBox.Show("A currency mező nem lehet üres!");
                            tbCurrency.Select();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Az ár mező nem lehet üres!");
                        tbPrice.Select();
                    }
                }
                else
                {
                    MessageBox.Show("A cikkszám mező nem lehet üres");
                    tbPn.Select();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connstring = "SERVER = mysql.nethely.hu;PORT=3306;DATABASE=vizga;UID=vizga;PASSWORD=Janika208";
            conn = new MySqlConnection();
            conn.ConnectionString = connstring;

            conn.Open();
            MySqlCommand cmd;
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into vizga.PriceList (PartNumber, Price, Currency, Packaging) values ('" + prodNum + "', '" + prodP + "', '" + currency + "', '" + per + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Az ár mentése sikeres volt");
            urit();
        }

        public void urit() {
            tbPart.Clear();
            tbDescription.Clear();
            tbKiszereles.Clear();
            cbUom.Items.Clear();
            cbUom.ResetText();
            tbPn.Clear();
            tbPrice.Clear();
            tbCurrency.Clear();
            tbPer.Clear();

        }

        private void TbPart_Leave(object sender, EventArgs e)
        {
            int p;
            try
            {
                if (tbPart.Text != "")
                {
                    p = Convert.ToInt32(tbPart.Text);
                    string sqlStr = "";
                    string connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";
                    conn = new MySqlConnection(connstring);
                    conn.Open();
                    sqlStr = "select PartNumber from vizga.Material where PartNumber = " + p;
                    MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                    object van = cmd.ExecuteScalar();
                        
                    conn.Close();
                    if (van != null)
                    {
                        MessageBox.Show("Ez anyag anyagszám már létezik!");
                        tbPart.Clear();
                        tbPart.Focus();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
