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
    public partial class frmRetangulo : Form
    {
        public frmRetangulo()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            AreaPerimetro objForma = new AreaPerimetro();
            double baseRetangulo, alturaRetangulo;
            if (!double.TryParse(txtbase.Text, out baseRetangulo) || !double.TryParse(txtaltura.Text, out alturaRetangulo))
            {
                MessageBox.Show("Valor esta incorreto");
            }
            else
            {
                txtarea.Text = objForma.AreaRetangulo(baseRetangulo, alturaRetangulo).ToString("0.0");
                txtperimetro.Text = objForma.PerimetroRetangulo(baseRetangulo, alturaRetangulo).ToString("0.0");
            }
        }

        private void frmRetangulo_Load(object sender, EventArgs e)
        {
            txtarea.Enabled = false;
            txtperimetro.Enabled = false;
        }
    }
}
