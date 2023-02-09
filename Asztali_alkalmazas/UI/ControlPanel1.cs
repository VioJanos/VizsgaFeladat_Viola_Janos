using Asztali_alkalmazas.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;
using WindowsFormsApp1;

// Csóbor S. Erik & Viola János csinálta
namespace Asztali_alkalmazas.UI
{
    public partial class ControlPanel1 : Form
    {
        MySqlConnection conn;
        string connstring;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public ControlPanel1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private Point _mouseLoc; // Kezdő egérhelyzet felvétele
        private string picSrc;
        private string username;
        private string date;
        private string permission;
        

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel5.Controls.Clear();
            panel5.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //Ablak műveletek, színek változtatás.
        private void minBT_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void minBT_MouseEnter(object sender, EventArgs e)
        {
            minBT.BackColor = Color.Gray;
        }

        private void minBT_MouseLeave(object sender, EventArgs e)
        {
            minBT.BackColor = panel4.BackColor;
        }

        private void maxBT_Click(object sender, EventArgs e)
        {
            if (WindowState is FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void maxBT_MouseEnter(object sender, EventArgs e)
        {
            maxBT.BackColor = Color.Gray;
        }

        private void maxBT_MouseLeave(object sender, EventArgs e)
        {
            maxBT.BackColor = panel4.BackColor;
        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Bezárja a programot?", "Mini ERP", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void closeBT_MouseEnter(object sender, EventArgs e)
        {
            closeBT.BackColor = Color.Red;
        }

        private void closeBT_MouseLeave(object sender, EventArgs e)
        {
            closeBT.BackColor = panel4.BackColor;
        }


        //Egér lenyomásakor nézi és eltárolja hova húztuk az egeret, felengedéskor elmenti
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        //A fent lementett érték x, y kordinátáját hozzáadjuk az alap kordínátákhoz, így megkapjuk az új locationt
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void kijelentkezBT_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void userProfilBT_Click(object sender, EventArgs e)
        {            
            UserProfil_UC up = new UserProfil_UC();
            addUserControl(up);
        }
            //Beolvassa a kép elérési útját
        private void Load_PicSrc()
        {
            string adat = "picSrc.txt";
            StreamReader olvas = new StreamReader(adat, Encoding.UTF8);
            string sor = "";
            while (!olvas.EndOfStream)
            {
                sor = olvas.ReadLine();
                if (!sor.Equals(""))
                {
                    picSrc = sor;
                }
            }
            olvas.Close();
        }

        private void Load_UserData()
        {
            string log = "succesLoginData.txt";
            StreamReader olvas = new StreamReader(log, Encoding.UTF8);
            string sor = "";
            while (!olvas.EndOfStream)
            {
                sor = olvas.ReadLine();
                string[] ideig = sor.Split(';');
                if (!sor.Equals(""))
                {
                    username = ideig[0];
                    date = ideig[1];
                    permission = ideig[2];
                }
            }
            olvas.Close();
        }
        private void get_UserData()
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT First_name, Last_name, Permissions.Permission FROM vizga.User, vizga.Permissions where User.Permission = Permissions.Roles_ID and Username= @Username;";
            cmd.Parameters.AddWithValue("@Username", username);
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                label2.Text = dr["Last_name"].ToString() + " " + dr["First_name"].ToString();
                timer1.Start();
                adminLL.Text = dr["Permission"].ToString();
                if(adminLL.Text != "Admin")
                {
                    adminBT.Enabled = false;
                }    
                else
                {
                    adminBT.Enabled = true;
                }
                conn.Close();
            }
            conn.Close();
        }
            //Főoldal és aktuális profil kép betöltése
        private void mainBT_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            try
            {
                Load_PicSrc();
                userProfilePic.Image = new Bitmap(picSrc);
            }
            catch (Exception)
            {
                //
            }
        }

        private void ControlPanel1_Load(object sender, EventArgs e)
        {
            Load_UserData();
            get_UserData();
            //adminControl_UC1.Visible = false;
            try
            {
                
                Load_PicSrc();
                userProfilePic.Image = new Bitmap(picSrc);
            }
            catch (Exception)
            {

            }
        }

        private void ExitBT_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Bezárja a programot?", "Mini ERP", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void adminBT_Click(object sender, EventArgs e)
        {
            AdminControl_UC ac = new AdminControl_UC();
            addUserControl(ac);
        }
            
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            label4.Text = currentTime.ToString();
        }

        private void BeerkezBT_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            frmVendor f1 = new frmVendor();
            f1.TopLevel = false;
            f1.AutoScroll = true;
            panel5.Controls.Add(f1);
            f1.Show();
        }

        private void Btn_NewProd_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            frmNewProd f3 = new frmNewProd();
            f3.TopLevel = false;
            f3.AutoScroll = true;
            panel5.Controls.Add(f3);
            f3.Show();
        }

        private void BtnInc_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            frmInc f2 = new frmInc();
            f2.TopLevel = false;
            f2.AutoScroll = true;
            panel5.Controls.Add(f2);
            f2.Show();
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            frmBook f4 = new frmBook();
            f4.TopLevel = false;
            f4.AutoScroll = true;
            panel5.Controls.Add(f4);
            f4.Show();
        }

        private void BtnSale_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            frmSales f5 = new frmSales();
            f5.TopLevel = false;
            f5.AutoScroll = true;
            panel5.Controls.Add(f5);
            f5.Show();
        }
    }
}
