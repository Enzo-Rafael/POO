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
    public partial class frmTrapezio : Form
    {
        public frmTrapezio()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            AreaPerimetro objtrapezio = new AreaPerimetro();
            double basemaior, basemenor, lado3, lado4, altura;

            if (!double.TryParse(txtbasemaior.Text, out basemaior) ||
                !double.TryParse(txtbasemenor.Text, out basemenor) ||
                !double.TryParse(txtlado3.Text, out lado3) ||
                !double.TryParse(txtlado4.Text, out lado4) ||
                !double.TryParse(txtaltura.Text, out altura))
            {
                MessageBox.Show("Algum valor esta Incorreto");
            }
            else
            {
                txtarea.Text = objtrapezio.AreaTrapezio(basemaior, basemenor, altura).ToString("0.000");
                txtperimetro.Text = objtrapezio.PerimetroTrapezio(lado3, lado4, basemaior, basemenor).ToString("0.000");
            }
        }
    }
    
}
