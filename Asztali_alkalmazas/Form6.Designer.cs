namespace Asztali_alkalmazas
{
    partial class frmSales
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
            this.tbPn = new System.Windows.Forms.TextBox();
            this.tbPcs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.btnSold = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.tbFull = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPn
            // 
            this.tbPn.Location = new System.Drawing.Point(101, 36);
            this.tbPn.Name = "tbPn";
            this.tbPn.Size = new System.Drawing.Size(161, 20);
            this.tbPn.TabIndex = 0;
            this.tbPn.Leave += new System.EventHandler(this.TbPn_Leave);
            // 
            // tbPcs
            // 
            this.tbPcs.Location = new System.Drawing.Point(367, 36);
            this.tbPcs.Name = "tbPcs";
            this.tbPcs.Size = new System.Drawing.Size(149, 20);
            this.tbPcs.TabIndex = 1;
            this.tbPcs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPcs_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temék:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mennyiség:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(101, 68);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(161, 20);
            this.tbPrice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Egységár:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(367, 68);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(149, 20);
            this.tbTotal.TabIndex = 3;
            this.tbTotal.Enter += new System.EventHandler(this.TbTotal_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(112, 157);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(357, 154);
            this.dgvSales.TabIndex = 8;
            // 
            // btnSold
            // 
            this.btnSold.Location = new System.Drawing.Point(478, 366);
            this.btnSold.Name = "btnSold";
            this.btnSold.Size = new System.Drawing.Size(75, 23);
            this.btnSold.TabIndex = 9;
            this.btnSold.Text = "Eladás";
            this.btnSold.UseVisualStyleBackColor = true;
            this.btnSold.Click += new System.EventHandler(this.BtnSold_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(242, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Áfa: 27%";
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(253, 113);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(75, 23);
            this.btnHozzaad.TabIndex = 12;
            this.btnHozzaad.Text = "Hozzáadás";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.BtnHozzaad_Click);
            // 
            // tbFull
            // 
            this.tbFull.Enabled = false;
            this.tbFull.Location = new System.Drawing.Point(427, 324);
            this.tbFull.Name = "tbFull";
            this.tbFull.Size = new System.Drawing.Size(126, 20);
            this.tbFull.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(330, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Végösszeg";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 418);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFull);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSold);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPcs);
            this.Controls.Add(this.tbPn);
            this.Name = "frmSales";
            this.Text = "Eladás";
            this.Load += new System.EventHandler(this.FrmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPn;
        private System.Windows.Forms.TextBox tbPcs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button btnSold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.TextBox tbFull;
        private System.Windows.Forms.Label label6;
    }
}