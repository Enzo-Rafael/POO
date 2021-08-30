using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3A2ENZO10
{
    public partial class ForREVISÃO : Form
    {
        public ForREVISÃO()
        {
            InitializeComponent();
        }

        private void ForREVISÃO_Load(object sender, EventArgs e)
        {

        }

        private void buttoncalculo_Click(object sender, EventArgs e)
        {
            GastoDeCombustivel objKM = new GastoDeCombustivel();
            int KM;

            if (!int.TryParse(textKM.Text, out KM))
            {
                MessageBox.Show("Verifique o valor colocado");
                textKM.Focus();
            }
            else if (KM > 10000)
            {
                MessageBox.Show("Ultrapassou o tempo de Revisão");
            }
            else textREVER.Text = objKM.Km(KM).ToString("0");
        }
    }
}
