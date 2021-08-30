using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A2ENZO10//Feito com base no projeto controle de cursos
{
    class Computador
    {
        public int codigo;
        public string nome, memoria, processador, hd, marca, placamae, ano, status, defeito;
        public string tabela = "pc_enzo";
        Conexao objConexao = new Conexao();    
        public void loja3A2Cadastrar() 
        {
            string inserir = $@"insert into {tabela} values(null,'{nome}','{memoria}','{processador}','{hd}','{marca}','{placamae}','{ano}','{status}','{defeito}');";
            objConexao.ExecutarComando(inserir);

        }
        public DataTable ListarPc() {
            string infoPc = $"select * from {tabela} order by status;";
            return objConexao.ExecutarConsulta(infoPc);
        }
    }
  }

