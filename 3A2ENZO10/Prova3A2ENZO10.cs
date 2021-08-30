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
        Computador objPC = new Computador();
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
              objPC.placamae = textPlacamae.Text;
              objPC.ano = textAno.Text;
              objPC.status = cbStatus.Text;
              objPC.defeito = textDefeito.Text;

              objPC.loja3A2Cadastrar();
              MessageBox.Show("Sucsso");

              textNome.Clear();
              textMemoria.Clear();
              textProcessador.Clear();
              textDiscorigido.Clear();
              textMarca.Clear();
              textPlacamae.Clear();
              textAno.Clear();
              textDefeito.Clear();
            /* Conexao objconexao = new Conexao();
            objconexao.Conectar();
            MessageBox.Show("Conectetol!");*/
         }
        
    }
}
