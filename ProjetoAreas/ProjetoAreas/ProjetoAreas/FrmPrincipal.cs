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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnretangulo_Click(object sender, EventArgs e)
        {
            frmRetangulo obj = new frmRetangulo();
            obj.ShowDialog();
        }

        private void btnquadrado_Click(object sender, EventArgs e)
        {
            frmQuadrado obj = new frmQuadrado();
            obj.ShowDialog();
        }

        private void btntriangulo_Click(object sender, EventArgs e)
        {
            frmTriangulo obj = new frmTriangulo();
            obj.ShowDialog();
        }

        private void btntrapezio_Click(object sender, EventArgs e)
        {
            frmTrapezio obj = new frmTrapezio();
            obj.ShowDialog();
        }
    }
}
