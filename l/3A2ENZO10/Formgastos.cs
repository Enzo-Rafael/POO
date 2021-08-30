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
    public partial class Formgastos : Form
    {
        public Formgastos()
        {
            InitializeComponent();
        }

        private void Formgastos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //cliquei sem querer
        }

        private void calculo_Click(object sender, EventArgs e)
        {
            GastoDeCombustivel objmedia = new GastoDeCombustivel();
            double S1, S2, S3, S4;

            if (!double.TryParse(txtS1.Text, out S1) ||
               !double.TryParse(txtS2.Text, out S2) ||
               !double.TryParse(txtS3.Text, out S3) || 
               !double.TryParse(txtS4.Text, out S4))
            {
                MessageBox.Show("Confira os Valores");
            }
            else 
            {
                txtresultado.Text = objmedia.Metade(S1, S2, S3, S4).ToString("0.000");
            }
        }

        private void S3_TextChanged(object sender, EventArgs e)
        {
            //cliquei sem querer
        }
    }

}
