namespace WindowsFormsApp1
{
    partial class frmInc
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbSup = new System.Windows.Forms.TextBox();
            this.tbPn = new System.Windows.Forms.TextBox();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.tbUom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.ItemsDGV = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Supplier:";
            // 
            // tbSup
            // 
            this.tbSup.Location = new System.Drawing.Point(257, 18);
            this.tbSup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSup.Name = "tbSup";
            this.tbSup.Size = new System.Drawing.Size(68, 20);
            this.tbSup.TabIndex = 1;
            this.tbSup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSup_KeyDown);
            // 
            // tbPn
            // 
            this.tbPn.Location = new System.Drawing.Point(74, 68);
            this.tbPn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPn.Name = "tbPn";
            this.tbPn.Size = new System.Drawing.Size(68, 20);
<<<<<<< Updated upstream
            this.tbPn.TabIndex = 3;
=======
            this.tbPn.TabIndex = 3;            
>>>>>>> Stashed changes
            this.tbPn.Leave += new System.EventHandler(this.TbPn_Leave);
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(188, 68);
            this.tbQty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(68, 20);
            this.tbQty.TabIndex = 4;
            // 
            // tbUom
            // 
            this.tbUom.Location = new System.Drawing.Point(302, 68);
            this.tbUom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUom.Name = "tbUom";
            this.tbUom.Size = new System.Drawing.Size(68, 20);
            this.tbUom.TabIndex = 5;
            this.tbUom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbUom_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "UoM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Partnumber:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date:";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(74, 18);
            this.tbDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(68, 20);
            this.tbDate.TabIndex = 12;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(368, 16);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(54, 19);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check!";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // ItemsDGV
            // 
            this.ItemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDGV.Location = new System.Drawing.Point(29, 105);
            this.ItemsDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemsDGV.Name = "ItemsDGV";
            this.ItemsDGV.RowTemplate.Height = 28;
            this.ItemsDGV.Size = new System.Drawing.Size(512, 263);
            this.ItemsDGV.TabIndex = 14;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(430, 68);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(54, 19);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(197, 394);
            this.btnBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(161, 38);
            this.btnBook.TabIndex = 16;
            this.btnBook.Text = "Enter";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Beszállító:";
            // 
            // frmInc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ItemsDGV);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUom);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.tbPn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSup);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInc";
            this.Text = "Beérkeztetés";
            this.Load += new System.EventHandler(this.FrmInc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSup;
        private System.Windows.Forms.TextBox tbPn;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.TextBox tbUom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView ItemsDGV;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label1;
    }
}