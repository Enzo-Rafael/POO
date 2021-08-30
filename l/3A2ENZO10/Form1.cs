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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formgastos obj = new Formgastos();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForIPVA obj = new ForIPVA();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ForREVISÃO obj = new ForREVISÃO();
            obj.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
