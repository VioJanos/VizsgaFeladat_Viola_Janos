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
            this.label2.Location = new System.Drawing.Point(760, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Supplier:";
            // 
            // tbSup
            // 
            this.tbSup.Location = new System.Drawing.Point(504, 85);
            this.tbSup.Name = "tbSup";
            this.tbSup.Size = new System.Drawing.Size(111, 26);
            this.tbSup.TabIndex = 1;
            this.tbSup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSup_KeyDown);
            // 
            // tbPn
            // 
            this.tbPn.Location = new System.Drawing.Point(123, 151);
            this.tbPn.Name = "tbPn";
            this.tbPn.Size = new System.Drawing.Size(111, 26);
            this.tbPn.TabIndex = 3;
            this.tbPn.Leave += new System.EventHandler(this.TbPn_Leave);
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(313, 151);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(111, 26);
            this.tbQty.TabIndex = 4;
            // 
            // tbUom
            // 
            this.tbUom.Location = new System.Drawing.Point(504, 151);
            this.tbUom.Name = "tbUom";
            this.tbUom.Size = new System.Drawing.Size(111, 26);
            this.tbUom.TabIndex = 5;
            this.tbUom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbUom_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(500, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "UoM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(309, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(119, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Partnumber:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(148, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date:";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(123, 79);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(111, 26);
            this.tbDate.TabIndex = 12;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCheck.Location = new System.Drawing.Point(992, 85);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(90, 29);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check!";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // ItemsDGV
            // 
            this.ItemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDGV.Location = new System.Drawing.Point(12, 253);
            this.ItemsDGV.Name = "ItemsDGV";
            this.ItemsDGV.RowTemplate.Height = 28;
            this.ItemsDGV.Size = new System.Drawing.Size(1440, 405);
            this.ItemsDGV.TabIndex = 14;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOk.Location = new System.Drawing.Point(992, 148);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 29);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBook.Location = new System.Drawing.Point(614, 703);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(268, 58);
            this.btnBook.TabIndex = 16;
            this.btnBook.Text = "Enter";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(500, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Beszállító:";
            // 
            // frmInc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 888);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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