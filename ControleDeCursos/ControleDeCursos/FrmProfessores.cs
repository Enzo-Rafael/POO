using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeCursos
{
    public partial class FrmProfessores : Form
    {
        Professor objProfessor = new Professor();
        public FrmProfessores()
        {
            InitializeComponent();
            textProf.Enabled = false;
            dtGprof.DataSource = objProfessor.ListarProfessor();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objProfessor.nome = NPROF.Text;
            objProfessor.valorHoraAula = double.Parse(Vaula.Text);
            objProfessor.telefone = telProf.Text;

            objProfessor.CadastrarCurso();
            MessageBox.Show("Cadastro com sucesso");

            NPROF.Clear();
            Vaula.Clear();
            telProf.Clear();
        }
    }
}
