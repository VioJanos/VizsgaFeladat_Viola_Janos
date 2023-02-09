namespace Asztali_alkalmazas.UI.UserControls
{
    partial class UserProfil_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ujJelszoOkLL = new System.Windows.Forms.Label();
            this.nemEggyezikLL = new System.Windows.Forms.Label();
            this.rosszJelszoLL = new System.Windows.Forms.Label();
            this.ujJelszoTB2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.updateInfoBT = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.regiJelszoTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.kersztnevTB = new System.Windows.Forms.TextBox();
            this.vezeteknevTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ujJelszoTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordChangeBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updatePasswordBT = new System.Windows.Forms.Button();
            this.userProfileGB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordChangeGB = new System.Windows.Forms.GroupBox();
            this.showPWD1 = new System.Windows.Forms.Button();
            this.uploadImageBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userProfilePic1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.userProfileGB.SuspendLayout();
            this.passwordChangeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePic1)).BeginInit();
            this.SuspendLayout();
            // 
            // ujJelszoOkLL
            // 
            this.ujJelszoOkLL.AutoSize = true;
            this.ujJelszoOkLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ujJelszoOkLL.Location = new System.Drawing.Point(412, 175);
            this.ujJelszoOkLL.Name = "ujJelszoOkLL";
            this.ujJelszoOkLL.Size = new System.Drawing.Size(51, 20);
            this.ujJelszoOkLL.TabIndex = 20;
            this.ujJelszoOkLL.Text = "label4";
            this.ujJelszoOkLL.Visible = false;
            // 
            // nemEggyezikLL
            // 
            this.nemEggyezikLL.AutoSize = true;
            this.nemEggyezikLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nemEggyezikLL.Location = new System.Drawing.Point(412, 262);
            this.nemEggyezikLL.Name = "nemEggyezikLL";
            this.nemEggyezikLL.Size = new System.Drawing.Size(51, 20);
            this.nemEggyezikLL.TabIndex = 18;
            this.nemEggyezikLL.Text = "label4";
            this.nemEggyezikLL.Visible = false;
            // 
            // rosszJelszoLL
            // 
            this.rosszJelszoLL.AutoSize = true;
            this.rosszJelszoLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rosszJelszoLL.Location = new System.Drawing.Point(412, 101);
            this.rosszJelszoLL.Name = "rosszJelszoLL";
            this.rosszJelszoLL.Size = new System.Drawing.Size(51, 20);
            this.rosszJelszoLL.TabIndex = 17;
            this.rosszJelszoLL.Text = "label4";
            this.rosszJelszoLL.Visible = false;
            // 
            // ujJelszoTB2
            // 
            this.ujJelszoTB2.Location = new System.Drawing.Point(550, 215);
            this.ujJelszoTB2.Name = "ujJelszoTB2";
            this.ujJelszoTB2.PasswordChar = '*';
            this.ujJelszoTB2.Size = new System.Drawing.Size(231, 31);
            this.ujJelszoTB2.TabIndex = 16;
            this.toolTip1.SetToolTip(this.ujJelszoTB2, "Minimum 8 karakter, nagy betűt ás számot is tartalmaznia kell!");
            this.ujJelszoTB2.Leave += new System.EventHandler(this.ujJelszoTB2_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(596, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 64);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Státusz:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(192, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Törölt";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(78, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Aktív";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(298, 341);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 20);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Beállítom az új jelszót";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // updateInfoBT
            // 
            this.updateInfoBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateInfoBT.Location = new System.Drawing.Point(366, 412);
            this.updateInfoBT.Name = "updateInfoBT";
            this.updateInfoBT.Size = new System.Drawing.Size(229, 38);
            this.updateInfoBT.TabIndex = 5;
            this.updateInfoBT.Text = "Frissítés";
            this.updateInfoBT.UseVisualStyleBackColor = true;
            this.updateInfoBT.Click += new System.EventHandler(this.updateInfoBT_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Enabled = false;
            this.PasswordTB.Location = new System.Drawing.Point(655, 186);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(194, 31);
            this.PasswordTB.TabIndex = 14;
            // 
            // UsernameTB
            // 
            this.UsernameTB.Enabled = false;
            this.UsernameTB.Location = new System.Drawing.Point(655, 89);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(194, 31);
            this.UsernameTB.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 364);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // regiJelszoTB
            // 
            this.regiJelszoTB.Location = new System.Drawing.Point(550, 58);
            this.regiJelszoTB.Name = "regiJelszoTB";
            this.regiJelszoTB.PasswordChar = '*';
            this.regiJelszoTB.Size = new System.Drawing.Size(231, 31);
            this.regiJelszoTB.TabIndex = 14;
            this.regiJelszoTB.Leave += new System.EventHandler(this.regiJelszoTB_Leave);
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(54, 269);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(304, 31);
            this.emailTB.TabIndex = 11;
            // 
            // kersztnevTB
            // 
            this.kersztnevTB.Location = new System.Drawing.Point(54, 175);
            this.kersztnevTB.Name = "kersztnevTB";
            this.kersztnevTB.Size = new System.Drawing.Size(194, 31);
            this.kersztnevTB.TabIndex = 10;
            // 
            // vezeteknevTB
            // 
            this.vezeteknevTB.Location = new System.Drawing.Point(54, 89);
            this.vezeteknevTB.Name = "vezeteknevTB";
            this.vezeteknevTB.Size = new System.Drawing.Size(194, 31);
            this.vezeteknevTB.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(630, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Jelszó:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Felhasználónév:";
            // 
            // ujJelszoTB
            // 
            this.ujJelszoTB.Location = new System.Drawing.Point(550, 145);
            this.ujJelszoTB.Name = "ujJelszoTB";
            this.ujJelszoTB.PasswordChar = '*';
            this.ujJelszoTB.Size = new System.Drawing.Size(231, 31);
            this.ujJelszoTB.TabIndex = 15;
            this.toolTip1.SetToolTip(this.ujJelszoTB, "Minimum 8 karakter, nagy betűt ás számot is tartalmaznia kell!");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(258, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Új jelszó megerősítése:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(252, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Új jelszó:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(252, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Régi jelszó:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Születési idő:";
            // 
            // passwordChangeBT
            // 
            this.passwordChangeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordChangeBT.Location = new System.Drawing.Point(53, 505);
            this.passwordChangeBT.Name = "passwordChangeBT";
            this.passwordChangeBT.Size = new System.Drawing.Size(229, 58);
            this.passwordChangeBT.TabIndex = 21;
            this.passwordChangeBT.Text = "Jelszó változtatás";
            this.passwordChangeBT.UseVisualStyleBackColor = true;
            this.passwordChangeBT.Click += new System.EventHandler(this.passwordChangeBT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Keresztnév:";
            // 
            // updatePasswordBT
            // 
            this.updatePasswordBT.Enabled = false;
            this.updatePasswordBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePasswordBT.Location = new System.Drawing.Point(366, 399);
            this.updatePasswordBT.Name = "updatePasswordBT";
            this.updatePasswordBT.Size = new System.Drawing.Size(229, 38);
            this.updatePasswordBT.TabIndex = 5;
            this.updatePasswordBT.Text = "Mentés";
            this.updatePasswordBT.UseVisualStyleBackColor = true;
            this.updatePasswordBT.Click += new System.EventHandler(this.updatePasswordBT_Click);
            // 
            // userProfileGB
            // 
            this.userProfileGB.Controls.Add(this.groupBox2);
            this.userProfileGB.Controls.Add(this.updateInfoBT);
            this.userProfileGB.Controls.Add(this.PasswordTB);
            this.userProfileGB.Controls.Add(this.UsernameTB);
            this.userProfileGB.Controls.Add(this.dateTimePicker1);
            this.userProfileGB.Controls.Add(this.emailTB);
            this.userProfileGB.Controls.Add(this.kersztnevTB);
            this.userProfileGB.Controls.Add(this.vezeteknevTB);
            this.userProfileGB.Controls.Add(this.label7);
            this.userProfileGB.Controls.Add(this.label6);
            this.userProfileGB.Controls.Add(this.label5);
            this.userProfileGB.Controls.Add(this.label4);
            this.userProfileGB.Controls.Add(this.label3);
            this.userProfileGB.Controls.Add(this.label2);
            this.userProfileGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userProfileGB.Location = new System.Drawing.Point(384, 624);
            this.userProfileGB.Name = "userProfileGB";
            this.userProfileGB.Size = new System.Drawing.Size(1084, 473);
            this.userProfileGB.TabIndex = 20;
            this.userProfileGB.TabStop = false;
            this.userProfileGB.Text = "Felhasználó adatai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vezetéknév:";
            // 
            // passwordChangeGB
            // 
            this.passwordChangeGB.Controls.Add(this.showPWD1);
            this.passwordChangeGB.Controls.Add(this.ujJelszoOkLL);
            this.passwordChangeGB.Controls.Add(this.checkBox1);
            this.passwordChangeGB.Controls.Add(this.nemEggyezikLL);
            this.passwordChangeGB.Controls.Add(this.rosszJelszoLL);
            this.passwordChangeGB.Controls.Add(this.ujJelszoTB2);
            this.passwordChangeGB.Controls.Add(this.ujJelszoTB);
            this.passwordChangeGB.Controls.Add(this.regiJelszoTB);
            this.passwordChangeGB.Controls.Add(this.label8);
            this.passwordChangeGB.Controls.Add(this.label9);
            this.passwordChangeGB.Controls.Add(this.label10);
            this.passwordChangeGB.Controls.Add(this.updatePasswordBT);
            this.passwordChangeGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordChangeGB.Location = new System.Drawing.Point(316, 130);
            this.passwordChangeGB.Name = "passwordChangeGB";
            this.passwordChangeGB.Size = new System.Drawing.Size(1084, 473);
            this.passwordChangeGB.TabIndex = 22;
            this.passwordChangeGB.TabStop = false;
            this.passwordChangeGB.Text = "Új jelszó beállítása:";
            this.passwordChangeGB.Visible = false;
            this.passwordChangeGB.Enter += new System.EventHandler(this.passwordChangeGB_Enter);
            // 
            // showPWD1
            // 
            this.showPWD1.BackgroundImage = global::Asztali_alkalmazas.Properties.Resources.showPWD;
            this.showPWD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showPWD1.Location = new System.Drawing.Point(916, 153);
            this.showPWD1.Name = "showPWD1";
            this.showPWD1.Size = new System.Drawing.Size(34, 23);
            this.showPWD1.TabIndex = 58;
            this.showPWD1.UseVisualStyleBackColor = true;
            this.showPWD1.Click += new System.EventHandler(this.showPWD1_Click);
            // 
            // uploadImageBT
            // 
            this.uploadImageBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadImageBT.Location = new System.Drawing.Point(53, 352);
            this.uploadImageBT.Name = "uploadImageBT";
            this.uploadImageBT.Size = new System.Drawing.Size(229, 38);
            this.uploadImageBT.TabIndex = 19;
            this.uploadImageBT.Text = "Feltöltés";
            this.uploadImageBT.UseVisualStyleBackColor = true;
            this.uploadImageBT.Click += new System.EventHandler(this.uploadImageBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Felhasználói fiók kezelése:";
            // 
            // userProfilePic1
            // 
            this.userProfilePic1.Image = global::Asztali_alkalmazas.Properties.Resources.profilpic;
            this.userProfilePic1.Location = new System.Drawing.Point(53, 120);
            this.userProfilePic1.Name = "userProfilePic1";
            this.userProfilePic1.Size = new System.Drawing.Size(229, 199);
            this.userProfilePic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userProfilePic1.TabIndex = 17;
            this.userProfilePic1.TabStop = false;
            // 
            // UserProfil_UC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.userProfilePic1);
            this.Controls.Add(this.passwordChangeBT);
            this.Controls.Add(this.passwordChangeGB);
            this.Controls.Add(this.userProfileGB);
            this.Controls.Add(this.uploadImageBT);
            this.Controls.Add(this.label1);
            this.Name = "UserProfil_UC";
            this.Size = new System.Drawing.Size(1471, 1100);
            this.Load += new System.EventHandler(this.UserProfil_UC_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.userProfileGB.ResumeLayout(false);
            this.userProfileGB.PerformLayout();
            this.passwordChangeGB.ResumeLayout(false);
            this.passwordChangeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ujJelszoOkLL;
        private System.Windows.Forms.Label nemEggyezikLL;
        private System.Windows.Forms.Label rosszJelszoLL;
        private System.Windows.Forms.TextBox ujJelszoTB2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button updateInfoBT;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox regiJelszoTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox kersztnevTB;
        private System.Windows.Forms.TextBox vezeteknevTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ujJelszoTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button passwordChangeBT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updatePasswordBT;
        private System.Windows.Forms.GroupBox userProfileGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox passwordChangeGB;
        private System.Windows.Forms.Button uploadImageBT;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox userProfilePic1;
        private System.Windows.Forms.Button showPWD1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
