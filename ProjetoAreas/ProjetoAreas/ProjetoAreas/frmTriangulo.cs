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
    public partial class frmTriangulo : Form
    {
        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            AreaPerimetro objTriangulo = new AreaPerimetro();
            double basetriangulo, lado1, lado2, alturatriangulo;

            if (!double.TryParse(txtbase.Text, out basetriangulo) ||
                !double.TryParse(txtaltura.Text, out alturatriangulo) ||
                !double.TryParse(txtlado1.Text, out lado1) ||
                !double.TryParse(txtlado2.Text, out lado2))
            {
                MessageBox.Show("Algum valor esta Incorreto");
            }
            else
            {
                txtarea.Text = objTriangulo.AreaTriangulo(basetriangulo, alturatriangulo).ToString("0.000");
                txtperimetro.Text = objTriangulo.PerimetroTriangulo(lado1, lado2, basetriangulo).ToString("0.000");
            }
        }
    }
}
