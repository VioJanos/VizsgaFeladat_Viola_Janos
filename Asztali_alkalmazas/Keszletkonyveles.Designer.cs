namespace Asztali_alkalmazas
{
    partial class frmBook
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
            this.cbHonnan = new System.Windows.Forms.ComboBox();
            this.cbHova = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMentes = new System.Windows.Forms.Button();
            this.tbPcs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbHonnan
            // 
            this.cbHonnan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbHonnan.FormattingEnabled = true;
            this.cbHonnan.IntegralHeight = false;
            this.cbHonnan.Items.AddRange(new object[] {
            "11",
            "21",
            "31",
            "41"});
            this.cbHonnan.Location = new System.Drawing.Point(207, 126);
            this.cbHonnan.Name = "cbHonnan";
            this.cbHonnan.Size = new System.Drawing.Size(121, 24);
            this.cbHonnan.TabIndex = 2;
            // 
            // cbHova
            // 
            this.cbHova.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbHova.FormattingEnabled = true;
            this.cbHova.Items.AddRange(new object[] {
            "11",
            "21",
            "31",
            "41"});
            this.cbHova.Location = new System.Drawing.Point(207, 173);
            this.cbHova.Name = "cbHova";
            this.cbHova.Size = new System.Drawing.Size(121, 24);
            this.cbHova.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Honnan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(53, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hova:";
            // 
            // tbPn
            // 
            this.tbPn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPn.Location = new System.Drawing.Point(207, 43);
            this.tbPn.Name = "tbPn";
            this.tbPn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPn.Size = new System.Drawing.Size(121, 22);
            this.tbPn.TabIndex = 0;
            this.tbPn.Leave += new System.EventHandler(this.TbPn_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(53, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Anyagszám:";
            // 
            // btnMentes
            // 
            this.btnMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMentes.Location = new System.Drawing.Point(207, 216);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(100, 40);
            this.btnMentes.TabIndex = 4;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.BtnMentes_Click);
            // 
            // tbPcs
            // 
            this.tbPcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPcs.Location = new System.Drawing.Point(207, 86);
            this.tbPcs.Name = "tbPcs";
            this.tbPcs.Size = new System.Drawing.Size(121, 22);
            this.tbPcs.TabIndex = 1;
            this.tbPcs.Leave += new System.EventHandler(this.TbPcs_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(53, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Daraszám:";
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 368);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPcs);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHova);
            this.Controls.Add(this.cbHonnan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBook";
            this.Text = "Készletkönyvelés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHonnan;
        private System.Windows.Forms.ComboBox cbHova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.TextBox tbPcs;
        private System.Windows.Forms.Label label4;
    }
}