using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Feito com basa no projeto controle de cursos
namespace _3A2ENZO10
{
    class Loja3a2
    {
        public int id;
        public string nome, memoria, processador, hd, marca, placa_mãe, Ano, status, defeito;
        public string tabela = "pc_enzo";
        Class3A2ENZO10 objClass3A2ENZO10 = new Class3A2ENZO10();    
        public void loja3A2Cadastrar() 
        {
            string inserir = $@"insert into {tabela} values(null,'{nome}','{memoria}'.'{processador}','{hd}','{marca}','{placa_mãe}','{Ano}','{status}','{defeito}');";
            objClass3A2ENZO10.ExecutarComando(inserir);

        }
        public DataTable ListarPc() {
            string infoPc = $"select * from {tabela} order by codigo;";
            return objClass3A2ENZO10.ExecutarConsulta(infoPc);
        }
    }
  }

