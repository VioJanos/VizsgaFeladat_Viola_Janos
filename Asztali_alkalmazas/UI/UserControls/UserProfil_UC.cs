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
using Google.Protobuf;
using MySql.Data.MySqlClient;
using Asztali_alkalmazas.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Asztali_alkalmazas.UI.UserControls
{
    public partial class UserProfil_UC : UserControl
    {
        MySqlConnection conn;
        string connstring;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public UserProfil_UC()
        {
            InitializeComponent();
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
        private string picSrc = "";
        private string username;
        private string pwd;
        Users ujUser = new Users();
        PasswordCrypt uj = new PasswordCrypt();
            //Alapvető ablak UserControl műveletek
        private void passwordChangeBT_Click(object sender, EventArgs e)
        {
            if (userProfileGB.Visible == true)
            {
                userProfileGB.Visible = false;
                passwordChangeGB.Visible = true;
                passwordChangeBT.Text = "Felhasználói adatok";
            }
            else
            {
                passwordChangeGB.Visible = false;
                userProfileGB.Visible = true;
                passwordChangeBT.Text = "Jelszó változtatás";


            }
        }
            // Új profil kép hozzáadása majd az elérési út lementése
        private void uploadImageBT_Click(object sender, EventArgs e)
        {
            OpenFileDialog newPic = new OpenFileDialog();
            newPic.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (newPic.ShowDialog() == DialogResult.OK)
            {
                userProfilePic1.Image = new Bitmap(newPic.FileName);
                picSrc = newPic.FileName;
            }
            string adat = "picSrc.txt";
            StreamWriter iras = new StreamWriter(adat, false, Encoding.UTF8);
            iras.WriteLine(picSrc);
            iras.Close();

        }


            //Fent lementett elérési utat beolvasva betöltjük az aktuális képet
        private void UserProfil_UC_Load(object sender, EventArgs e)
        {

            try
            {
                userProfileGB.Location = passwordChangeGB.Location;
                Load_UserData();
                getUserData();
                Load_PicSrc();
                userProfilePic1.Image = new Bitmap(picSrc);
            }
            catch (Exception)
            {
                //
            }

        }

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
                    string date = ideig[1];
                    string permission = ideig[2];
                }
            }
            olvas.Close();
        }
            //Textboxok feltöltése a megfelelő adatokkal
        private void getUserData()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT First_name, Last_name, `E-mail`, Birth, Username, Password, Deleted  FROM vizga.User where Username = @Username;";
                cmd.Parameters.AddWithValue("@Username", username);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    vezeteknevTB.Text = dr["Last_name"].ToString();
                    kersztnevTB.Text = dr["First_name"].ToString();
                    emailTB.Text = dr["E-mail"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dr["Birth"]);
                    UsernameTB.Text = dr["Username"].ToString();
                    string pwd = uj.fejtettPWD(dr["Password"].ToString());
                    PasswordTB.Text = pwd;
                    if (Convert.ToInt32(dr["Deleted"]) == 0)
                    {
                        radioButton2.Enabled = false;
                        radioButton2.Checked = false;
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton1.Enabled = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = true;

                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           

        }
            //Felhasználó tudja frissíteni az adatait
        private void updateInfoBT_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT First_name, Last_name, `E-mail`, Birth, Username, Password, Deleted  FROM vizga.User where Username = @Username;";
                cmd.Parameters.AddWithValue("@Username", username);
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    if(vezeteknevTB.Text != dr["Last_name"].ToString() || kersztnevTB.Text != dr["First_name"].ToString() || emailTB.Text != dr["E-mail"].ToString() || dateTimePicker1.Value != Convert.ToDateTime(dr["Birth"]))
                    {
                        ujUser.setLastname(vezeteknevTB.Text);
                        ujUser.setFirstname(kersztnevTB.Text);
                        ujUser.setEmail(emailTB.Text);
                        ujUser.setBirthDate(dateTimePicker1.Value);
                    }
                }
                conn.Close();

                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                string format = "yyyy-MM-dd";
                cmd.CommandText = "UPDATE `vizga`.`User` SET Last_name ='" + ujUser.Lastname + "', First_name = '" + ujUser.Firstname + "', `E-mail`= '" + ujUser.Email + "', Birth = '" + ujUser.BirthDate.ToString(format) + "' where Username = @Username;";
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Frissítettem az adatokat.");
                getUserData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            //Felhasználó magának tud jelszót változtatni
        private void getJelszo()
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT Password FROM vizga.User where Username = @Username;";
            cmd.Parameters.AddWithValue("@Username", username);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                pwd = uj.fejtettPWD(dr["PASSWORD"].ToString());
            }
            conn.Close();
        }

        private void setUjJelszo()
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE vizga.User SET Password = '" + uj.CryptedPwd + "' where Username= @Username;";
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeresen megváltoztattad a jelszavad.");
            regiJelszoTB.Clear();
            ujJelszoTB.Clear();
            ujJelszoTB2.Clear();
            checkBox1.Checked = false;
            
        }
        private void passwordChangeGB_Enter(object sender, EventArgs e)
        {
            getJelszo();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                updatePasswordBT.Enabled = true;
            }
            else
            {
                checkBox1.Checked = false;
                updatePasswordBT.Enabled = false;
            }
          
        }

        private void ujJelszoTB2_Leave(object sender, EventArgs e)
        {
            if (ujJelszoTB.Text != ujJelszoTB2.Text)
            {
                nemEggyezikLL.ForeColor = Color.Red;
                nemEggyezikLL.Text = "Az új jelszók nem eggyeznek egymással.";
                nemEggyezikLL.Visible = true;
                checkBox1.Checked = false;
                ujJelszoTB2.Clear();
                ujJelszoTB2.Focus();
                
            }
            else
            {
                nemEggyezikLL.Visible = false;
                ujUser.setPassword(ujJelszoTB2.Text);
                if(ujJelszoTB2.Text.Any(char.IsUpper) && ujJelszoTB2.Text.Any(char.IsDigit) && ujJelszoTB2.Text.Length >= 8)
                {
                   
                }
                else
                {
                    DialogResult Error;
                    Error = MessageBox.Show("Az álltalad megadott jelszó nem megfelelő erősségű.\nBeállítottam az alap jelszót.","Nem megfelelő erősségű jelszó!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ujJelszoTB.Text = ujUser.Password;
                    ujJelszoTB2.Text = ujUser.Password;
                }
                string titkospwd = uj.titkosPWD(ujUser.Password);
            }
        }

        private void updatePasswordBT_Click(object sender, EventArgs e)
        {
            setUjJelszo();
            getUserData();
            passwordChangeGB.Visible= false;
            userProfileGB.Visible = true;
        }

        private void regiJelszoTB_Leave(object sender, EventArgs e)
        {
            if (regiJelszoTB.Text == pwd)
            {
                ujJelszoTB.Enabled = true;
                ujJelszoTB2.Enabled = true;
                rosszJelszoLL.Visible= false;

            }
            else
            {
                rosszJelszoLL.ForeColor = Color.Red;
                rosszJelszoLL.Text = "Nem eggyezik a régi jelszavaddal!";
                rosszJelszoLL.Visible = true;
                regiJelszoTB.Clear();
                regiJelszoTB.Focus();
            }
        }

        private void showPWD1_Click(object sender, EventArgs e)
        {
            if (passwordChangeGB.Visible)
            {
                if (regiJelszoTB.PasswordChar == '*' || ujJelszoTB.PasswordChar == '*')
                {
                    regiJelszoTB.PasswordChar = '\0';
                    ujJelszoTB.PasswordChar = '\0';
                    ujJelszoTB2.PasswordChar= '\0';
                }
                else
                {
                    regiJelszoTB.PasswordChar = '*';
                    ujJelszoTB.PasswordChar = '*';
                    ujJelszoTB2.PasswordChar= '*';
                }

            }
        }
    }
}
