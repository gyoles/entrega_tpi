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
    public partial class FrmAlta : Form
    {
        public FrmAlta()
        {
            InitializeComponent();
            Articulo a;
            AccesoDatos acceso;
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            AccesoDatos acceso = new AccesoDatos();
            CargarCombo(cboMarca);
            CargarCombo(cboRubro);
            CargarCombo(cboMedicinal);
            CargarCombo(cboVentaLi);
        }

        private void CargarCombo(ComboBox combo)
        {
            AccesoDatos acceso = new AccesoDatos();
            combo.DataSource = acceso.ConsultarArt("SP_CONSULTAR_" + combo);
            //combo.ValueMember =
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
