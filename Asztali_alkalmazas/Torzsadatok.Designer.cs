namespace WindowsFormsApp1
{
    partial class frmNewProd
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
            this.btnCreateNewProd = new System.Windows.Forms.Button();
            this.btnPricing = new System.Windows.Forms.Button();
            this.gbNewProd = new System.Windows.Forms.GroupBox();
            this.btnSavePart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPart = new System.Windows.Forms.TextBox();
            this.cbUom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lebel = new System.Windows.Forms.Label();
            this.tbKiszereles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.gbPricing = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCurrency = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.gbNewProd.SuspendLayout();
            this.gbPricing.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateNewProd
            // 
            this.btnCreateNewProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateNewProd.Location = new System.Drawing.Point(58, 119);
            this.btnCreateNewProd.Name = "btnCreateNewProd";
            this.btnCreateNewProd.Size = new System.Drawing.Size(228, 52);
            this.btnCreateNewProd.TabIndex = 0;
            this.btnCreateNewProd.Text = "Törzsadatok létrehozása";
            this.btnCreateNewProd.UseVisualStyleBackColor = true;
            this.btnCreateNewProd.Click += new System.EventHandler(this.BtnCreateNewProd_Click);
            // 
            // btnPricing
            // 
            this.btnPricing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPricing.Location = new System.Drawing.Point(58, 214);
            this.btnPricing.Name = "btnPricing";
            this.btnPricing.Size = new System.Drawing.Size(228, 51);
            this.btnPricing.TabIndex = 1;
            this.btnPricing.Text = "Meglévő termék beárazása";
            this.btnPricing.UseVisualStyleBackColor = true;
            this.btnPricing.Click += new System.EventHandler(this.BtnPricing_Click);
            // 
            // gbNewProd
            // 
            this.gbNewProd.Controls.Add(this.btnSavePart);
            this.gbNewProd.Controls.Add(this.label3);
            this.gbNewProd.Controls.Add(this.tbPart);
            this.gbNewProd.Controls.Add(this.cbUom);
            this.gbNewProd.Controls.Add(this.label2);
            this.gbNewProd.Controls.Add(this.lebel);
            this.gbNewProd.Controls.Add(this.tbKiszereles);
            this.gbNewProd.Controls.Add(this.label1);
            this.gbNewProd.Controls.Add(this.tbDescription);
            this.gbNewProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbNewProd.Location = new System.Drawing.Point(343, 79);
            this.gbNewProd.Name = "gbNewProd";
            this.gbNewProd.Size = new System.Drawing.Size(420, 300);
            this.gbNewProd.TabIndex = 2;
            this.gbNewProd.TabStop = false;
            this.gbNewProd.Text = "Új termék: ";
            // 
            // btnSavePart
            // 
            this.btnSavePart.Location = new System.Drawing.Point(185, 213);
            this.btnSavePart.Name = "btnSavePart";
            this.btnSavePart.Size = new System.Drawing.Size(117, 27);
            this.btnSavePart.TabIndex = 5;
            this.btnSavePart.Text = "Mentés";
            this.btnSavePart.UseVisualStyleBackColor = true;
            this.btnSavePart.Click += new System.EventHandler(this.BtnSavePart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cikkszám:";
            // 
            // tbPart
            // 
            this.tbPart.Location = new System.Drawing.Point(202, 40);
            this.tbPart.Name = "tbPart";
            this.tbPart.Size = new System.Drawing.Size(100, 26);
            this.tbPart.TabIndex = 1;
            this.tbPart.Leave += new System.EventHandler(this.TbPart_Leave);
            // 
            // cbUom
            // 
            this.cbUom.FormattingEnabled = true;
            this.cbUom.Items.AddRange(new object[] {
            "DB",
            "Kg",
            "L"});
            this.cbUom.Location = new System.Drawing.Point(202, 152);
            this.cbUom.Name = "cbUom";
            this.cbUom.Size = new System.Drawing.Size(121, 28);
            this.cbUom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mértékegység:";
            // 
            // lebel
            // 
            this.lebel.AutoSize = true;
            this.lebel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lebel.Location = new System.Drawing.Point(84, 112);
            this.lebel.Name = "lebel";
            this.lebel.Size = new System.Drawing.Size(96, 20);
            this.lebel.TabIndex = 3;
            this.lebel.Text = "Kiszerelés:";
            // 
            // tbKiszereles
            // 
            this.tbKiszereles.Location = new System.Drawing.Point(202, 109);
            this.tbKiszereles.Name = "tbKiszereles";
            this.tbKiszereles.Size = new System.Drawing.Size(100, 26);
            this.tbKiszereles.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Megnevezés:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(202, 76);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 26);
            this.tbDescription.TabIndex = 2;
            // 
            // gbPricing
            // 
            this.gbPricing.Controls.Add(this.button1);
            this.gbPricing.Controls.Add(this.tbPer);
            this.gbPricing.Controls.Add(this.label4);
            this.gbPricing.Controls.Add(this.tbPn);
            this.gbPricing.Controls.Add(this.label5);
            this.gbPricing.Controls.Add(this.label6);
            this.gbPricing.Controls.Add(this.tbCurrency);
            this.gbPricing.Controls.Add(this.label7);
            this.gbPricing.Controls.Add(this.tbPrice);
            this.gbPricing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPricing.Location = new System.Drawing.Point(343, 73);
            this.gbPricing.Name = "gbPricing";
            this.gbPricing.Size = new System.Drawing.Size(420, 300);
            this.gbPricing.TabIndex = 8;
            this.gbPricing.TabStop = false;
            this.gbPricing.Text = "Árú felvitele:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbPer
            // 
            this.tbPer.Location = new System.Drawing.Point(182, 144);
            this.tbPer.Name = "tbPer";
            this.tbPer.Size = new System.Drawing.Size(100, 26);
            this.tbPer.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cikkszám:";
            // 
            // tbPn
            // 
            this.tbPn.Location = new System.Drawing.Point(182, 40);
            this.tbPn.Name = "tbPn";
            this.tbPn.Size = new System.Drawing.Size(100, 26);
            this.tbPn.TabIndex = 1;
            this.tbPn.Leave += new System.EventHandler(this.TbPn_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Per:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(84, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pénznem:";
            // 
            // tbCurrency
            // 
            this.tbCurrency.Location = new System.Drawing.Point(182, 109);
            this.tbCurrency.Name = "tbCurrency";
            this.tbCurrency.Size = new System.Drawing.Size(100, 26);
            this.tbCurrency.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ár:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(182, 76);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 26);
            this.tbPrice.TabIndex = 2;
            // 
            // frmNewProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbPricing);
            this.Controls.Add(this.gbNewProd);
            this.Controls.Add(this.btnPricing);
            this.Controls.Add(this.btnCreateNewProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewProd";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmNewProd_Load);
            this.gbNewProd.ResumeLayout(false);
            this.gbNewProd.PerformLayout();
            this.gbPricing.ResumeLayout(false);
            this.gbPricing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewProd;
        private System.Windows.Forms.Button btnPricing;
        private System.Windows.Forms.GroupBox gbNewProd;
        private System.Windows.Forms.ComboBox cbUom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lebel;
        private System.Windows.Forms.TextBox tbKiszereles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.GroupBox gbPricing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCurrency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPart;
        private System.Windows.Forms.TextBox tbPer;
        private System.Windows.Forms.Button btnSavePart;
        private System.Windows.Forms.Button button1;
    }
}