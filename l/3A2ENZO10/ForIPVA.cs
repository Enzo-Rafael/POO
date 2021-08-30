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
    public partial class ForIPVA : Form
    {
        public ForIPVA()
        {
            InitializeComponent();
        }

        private void ForIPVA_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GastoDeCombustivel objveicolo = new GastoDeCombustivel();
            double VC;

            if (!double.TryParse(textv.Text, out VC))
            {
                MessageBox.Show("Verificar valor");
            }
            else if (rbp.Checked)
            {
                texr.Text = objveicolo.IPVP(VC).ToString("0.0");
            }
            else if (rbc.Checked)
            {
                texr.Text = objveicolo.IPVC(VC).ToString("0.0");
            }
            else if (rbtp.Checked)
            {
                texr.Text = objveicolo.IPVTP(VC).ToString("0.0");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
