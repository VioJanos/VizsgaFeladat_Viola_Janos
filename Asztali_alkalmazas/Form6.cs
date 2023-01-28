using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asztali_alkalmazas
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            dgvSales.ColumnCount = 4;
            dgvSales.Columns[0].Name = "Termék";
            dgvSales.Columns[1].Name = "Mennyiség";
            dgvSales.Columns[2].Name = "Egységár";
            dgvSales.Columns[3].Name = "Total";
            dgvSales.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSales.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSales.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSales.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
