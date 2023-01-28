namespace Asztali_alkalmazas.UI
{
    partial class ControlPanel1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.minBT = new System.Windows.Forms.Button();
            this.maxBT = new System.Windows.Forms.Button();
            this.closeBT = new System.Windows.Forms.Button();
            this.adminLL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btNewSup = new System.Windows.Forms.Button();
            this.userProfilBT = new System.Windows.Forms.Button();
            this.ExitBT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kijelentkezBT = new System.Windows.Forms.Button();
            this.userProfilePic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnInc = new System.Windows.Forms.Button();
            this.btn_NewProd = new System.Windows.Forms.Button();
            this.raktarBT = new System.Windows.Forms.Button();
            this.adminBT = new System.Windows.Forms.Button();
            this.mainBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSale = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.adminLL);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1654, 100);
            this.panel3.TabIndex = 5;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.minBT);
            this.panel4.Controls.Add(this.maxBT);
            this.panel4.Controls.Add(this.closeBT);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1444, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 100);
            this.panel4.TabIndex = 15;
            // 
            // minBT
            // 
            this.minBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBT.BackColor = System.Drawing.Color.LightGray;
            this.minBT.BackgroundImage = global::Asztali_alkalmazas.Properties.Resources.minimize_window;
            this.minBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minBT.FlatAppearance.BorderSize = 0;
            this.minBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBT.Location = new System.Drawing.Point(102, -2);
            this.minBT.Margin = new System.Windows.Forms.Padding(2);
            this.minBT.Name = "minBT";
            this.minBT.Size = new System.Drawing.Size(32, 34);
            this.minBT.TabIndex = 18;
            this.minBT.UseVisualStyleBackColor = false;
            this.minBT.Click += new System.EventHandler(this.minBT_Click);
            this.minBT.MouseEnter += new System.EventHandler(this.minBT_MouseEnter);
            this.minBT.MouseLeave += new System.EventHandler(this.minBT_MouseLeave);
            // 
            // maxBT
            // 
            this.maxBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBT.BackColor = System.Drawing.Color.LightGray;
            this.maxBT.BackgroundImage = global::Asztali_alkalmazas.Properties.Resources.maximize_window;
            this.maxBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maxBT.FlatAppearance.BorderSize = 0;
            this.maxBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBT.Location = new System.Drawing.Point(138, -2);
            this.maxBT.Margin = new System.Windows.Forms.Padding(2);
            this.maxBT.Name = "maxBT";
            this.maxBT.Size = new System.Drawing.Size(32, 34);
            this.maxBT.TabIndex = 17;
            this.maxBT.UseVisualStyleBackColor = false;
            this.maxBT.Click += new System.EventHandler(this.maxBT_Click);
            this.maxBT.MouseEnter += new System.EventHandler(this.maxBT_MouseEnter);
            this.maxBT.MouseLeave += new System.EventHandler(this.maxBT_MouseLeave);
            // 
            // closeBT
            // 
            this.closeBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBT.BackColor = System.Drawing.Color.LightGray;
            this.closeBT.BackgroundImage = global::Asztali_alkalmazas.Properties.Resources.close_window;
            this.closeBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBT.FlatAppearance.BorderSize = 0;
            this.closeBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBT.Location = new System.Drawing.Point(174, -2);
            this.closeBT.Margin = new System.Windows.Forms.Padding(2);
            this.closeBT.Name = "closeBT";
            this.closeBT.Size = new System.Drawing.Size(32, 34);
            this.closeBT.TabIndex = 16;
            this.closeBT.UseVisualStyleBackColor = false;
            this.closeBT.Click += new System.EventHandler(this.closeBT_Click);
            this.closeBT.MouseEnter += new System.EventHandler(this.closeBT_MouseEnter);
            this.closeBT.MouseLeave += new System.EventHandler(this.closeBT_MouseLeave);
            // 
            // adminLL
            // 
            this.adminLL.AutoSize = true;
            this.adminLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLL.Location = new System.Drawing.Point(126, 40);
            this.adminLL.Name = "adminLL";
            this.adminLL.Size = new System.Drawing.Size(46, 18);
            this.adminLL.TabIndex = 17;
            this.adminLL.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Jogosultság: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dátum és idő:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Felhasználó:";
            // 
            // btNewSup
            // 
            this.btNewSup.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btNewSup.FlatAppearance.BorderSize = 0;
            this.btNewSup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.btNewSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btNewSup.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btNewSup.Location = new System.Drawing.Point(3, 440);
            this.btNewSup.Name = "btNewSup";
            this.btNewSup.Size = new System.Drawing.Size(194, 30);
            this.btNewSup.TabIndex = 2;
            this.btNewSup.Text = "Új beszállító";
            this.btNewSup.UseVisualStyleBackColor = false;
            this.btNewSup.Click += new System.EventHandler(this.BeerkezBT_Click);
            // 
            // userProfilBT
            // 
            this.userProfilBT.BackColor = System.Drawing.Color.MediumTurquoise;
            this.userProfilBT.FlatAppearance.BorderSize = 0;
            this.userProfilBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.userProfilBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userProfilBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userProfilBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.userProfilBT.Location = new System.Drawing.Point(3, 192);
            this.userProfilBT.Name = "userProfilBT";
            this.userProfilBT.Size = new System.Drawing.Size(194, 35);
            this.userProfilBT.TabIndex = 4;
            this.userProfilBT.Text = "Felhasználói fiók";
            this.userProfilBT.UseVisualStyleBackColor = false;
            this.userProfilBT.Click += new System.EventHandler(this.userProfilBT_Click);
            // 
            // ExitBT
            // 
            this.ExitBT.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ExitBT.FlatAppearance.BorderSize = 0;
            this.ExitBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.ExitBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ExitBT.Location = new System.Drawing.Point(0, 783);
            this.ExitBT.Name = "ExitBT";
            this.ExitBT.Size = new System.Drawing.Size(200, 62);
            this.ExitBT.TabIndex = 4;
            this.ExitBT.Text = "Kilépés";
            this.ExitBT.UseVisualStyleBackColor = false;
            this.ExitBT.Click += new System.EventHandler(this.ExitBT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.kijelentkezBT);
            this.panel2.Controls.Add(this.userProfilePic);
            this.panel2.Controls.Add(this.userProfilBT);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 286);
            this.panel2.TabIndex = 1;
            // 
            // kijelentkezBT
            // 
            this.kijelentkezBT.BackColor = System.Drawing.Color.MediumTurquoise;
            this.kijelentkezBT.FlatAppearance.BorderSize = 0;
            this.kijelentkezBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.kijelentkezBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kijelentkezBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kijelentkezBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.kijelentkezBT.Location = new System.Drawing.Point(3, 246);
            this.kijelentkezBT.Name = "kijelentkezBT";
            this.kijelentkezBT.Size = new System.Drawing.Size(194, 37);
            this.kijelentkezBT.TabIndex = 4;
            this.kijelentkezBT.Text = "Kijelentkezés";
            this.kijelentkezBT.UseVisualStyleBackColor = false;
            this.kijelentkezBT.Click += new System.EventHandler(this.kijelentkezBT_Click);
            // 
            // userProfilePic
            // 
            this.userProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("userProfilePic.Image")));
            this.userProfilePic.Location = new System.Drawing.Point(12, 12);
            this.userProfilePic.Name = "userProfilePic";
            this.userProfilePic.Size = new System.Drawing.Size(169, 149);
            this.userProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userProfilePic.TabIndex = 0;
            this.userProfilePic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnSale);
            this.panel1.Controls.Add(this.btnBook);
            this.panel1.Controls.Add(this.btnInc);
            this.panel1.Controls.Add(this.btn_NewProd);
            this.panel1.Controls.Add(this.ExitBT);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.raktarBT);
            this.panel1.Controls.Add(this.btNewSup);
            this.panel1.Controls.Add(this.adminBT);
            this.panel1.Controls.Add(this.mainBT);
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 848);
            this.panel1.TabIndex = 4;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBook.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBook.Location = new System.Drawing.Point(3, 495);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(194, 30);
            this.btnBook.TabIndex = 7;
            this.btnBook.Text = "Készlet átkönyvelés";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // btnInc
            // 
            this.btnInc.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnInc.FlatAppearance.BorderSize = 0;
            this.btnInc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.btnInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnInc.Location = new System.Drawing.Point(3, 468);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(194, 30);
            this.btnInc.TabIndex = 6;
            this.btnInc.Text = "Beérkeztetés";
            this.btnInc.UseVisualStyleBackColor = false;
            this.btnInc.Click += new System.EventHandler(this.BtnInc_Click);
            // 
            // btn_NewProd
            // 
            this.btn_NewProd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_NewProd.FlatAppearance.BorderSize = 0;
            this.btn_NewProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.btn_NewProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_NewProd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_NewProd.Location = new System.Drawing.Point(3, 408);
            this.btn_NewProd.Name = "btn_NewProd";
            this.btn_NewProd.Size = new System.Drawing.Size(194, 30);
            this.btn_NewProd.TabIndex = 5;
            this.btn_NewProd.Text = "Törzsadatok létrehozása";
            this.btn_NewProd.UseVisualStyleBackColor = false;
            this.btn_NewProd.Click += new System.EventHandler(this.Btn_NewProd_Click);
            // 
            // raktarBT
            // 
            this.raktarBT.BackColor = System.Drawing.Color.MediumTurquoise;
            this.raktarBT.FlatAppearance.BorderSize = 0;
            this.raktarBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.raktarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raktarBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raktarBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.raktarBT.Location = new System.Drawing.Point(3, 564);
            this.raktarBT.Name = "raktarBT";
            this.raktarBT.Size = new System.Drawing.Size(196, 62);
            this.raktarBT.TabIndex = 3;
            this.raktarBT.Text = "Raktárkészlet";
            this.raktarBT.UseVisualStyleBackColor = false;
            // 
            // adminBT
            // 
            this.adminBT.BackColor = System.Drawing.Color.MediumTurquoise;
            this.adminBT.FlatAppearance.BorderSize = 0;
            this.adminBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.adminBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.adminBT.Location = new System.Drawing.Point(3, 353);
            this.adminBT.Name = "adminBT";
            this.adminBT.Size = new System.Drawing.Size(196, 37);
            this.adminBT.TabIndex = 1;
            this.adminBT.Text = "Admin felület";
            this.adminBT.UseVisualStyleBackColor = false;
            this.adminBT.Click += new System.EventHandler(this.adminBT_Click);
            // 
            // mainBT
            // 
            this.mainBT.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mainBT.FlatAppearance.BorderSize = 0;
            this.mainBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.mainBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mainBT.Location = new System.Drawing.Point(3, 302);
            this.mainBT.Name = "mainBT";
            this.mainBT.Size = new System.Drawing.Size(194, 39);
            this.mainBT.TabIndex = 0;
            this.mainBT.Text = "Kezdőlap";
            this.mainBT.UseVisualStyleBackColor = false;
            this.mainBT.Click += new System.EventHandler(this.mainBT_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSale.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSale.Location = new System.Drawing.Point(3, 525);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(194, 30);
            this.btnSale.TabIndex = 8;
            this.btnSale.Text = "Eladás";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.BtnSale_Click);
            // 
            // ControlPanel1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1654, 881);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ControlPanel1";
            this.Text = "ControlPanel";
            this.Load += new System.EventHandler(this.ControlPanel1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button minBT;
        private System.Windows.Forms.Button closeBT;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label adminLL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button maxBT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNewSup;
        private System.Windows.Forms.PictureBox userProfilePic;
        private System.Windows.Forms.Button userProfilBT;
        private System.Windows.Forms.Button ExitBT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button kijelentkezBT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button raktarBT;
        private System.Windows.Forms.Button adminBT;
        private System.Windows.Forms.Button mainBT;
        private UserControls.AdminControl_UC adminControl_UC1;
        private System.Windows.Forms.Timer timer1;
        private UserControls.UserProfil_UC userProfil_UC1;
        private System.Windows.Forms.Button btn_NewProd;
        private System.Windows.Forms.Button btnInc;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnSale;
    }
}