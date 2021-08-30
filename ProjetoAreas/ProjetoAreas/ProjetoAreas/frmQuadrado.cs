using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAreas
{
    public partial class frmQuadrado : Form
    {
        public frmQuadrado()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            AreaPerimetro objquadrado = new AreaPerimetro();
            double ladoquadrado;
            if (!double.TryParse(txtlado.Text, out ladoquadrado))
            {
                MessageBox.Show("Verifique o valor colocado");
            }
            else
            {
                txtarea.Text = objquadrado.AreaQuadrado(ladoquadrado).ToString("0.0");
                txtperimetro.Text = objquadrado.PerimetroQuadrado(ladoquadrado).ToString("0.0");
            }
        }
    }
}
