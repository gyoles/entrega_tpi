using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregaFinal
{
    public partial class FrmFarmacia : Form
    {
        public FrmFarmacia()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAlta FrmAltaArt = new FrmAlta();
            FrmAltaArt.ShowDialog();
        }

        private void FrmFarmacia_Load(object sender, EventArgs e)
        {

        }
    }
}
