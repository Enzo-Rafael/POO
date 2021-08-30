using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Feito com basa no projeto controle de cursos
namespace _3A2ENZO10
{
    public partial class Enzo3A3 : Form
    {
        Loja3a2 objPC = new Loja3a2();
        public Enzo3A3()
        {
            InitializeComponent();
            textId.Enabled = false;
            dataExibir.DataSource = objPC.ListarPc();
        }

        private void labelDefeito_Click(object sender, EventArgs e)
        {
            //Ativado sem secessidade :(
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            objPC.nome = textNome.Text;
            objPC.memoria = textMemoria.Text;
            objPC.processador = textProcessador.Text;
            objPC.hd = textDiscorigido.Text;
            objPC.marca = textMarca.Text;
            objPC.placa_mãe = textPlacamae.Text;
            objPC.Ano = textAno.Text;
            objPC.status = textStatus.Text;
            objPC.defeito = textDefeito.Text;

            objPC.loja3A2Cadastrar();
        }
        
    }
}
