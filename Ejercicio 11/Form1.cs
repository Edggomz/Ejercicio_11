using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_11
{
    public partial class frmCalcularPrecioDescuento : Form
    {
        double precioOriginal, precioFinal;
        double porcentajeDescuento = 0.65;
        public frmCalcularPrecioDescuento()
        {
            InitializeComponent();
        }
        private void btnConvertir_Click(object sender, EventArgs e)
        {


            if (double.TryParse(txtPrecioProducto.Text, out precioOriginal))
            {
                precioFinal = precioOriginal * (1 - porcentajeDescuento); 
                txtDescuento.Text = precioFinal.ToString("N2");
            }
            else
            {
                txtDescuento.Text = "Entrada inválida";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            txtDescuento.Clear();
            txtPrecioProducto.Clear();
        }
    }
    
}
