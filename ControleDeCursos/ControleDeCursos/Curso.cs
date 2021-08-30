using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ControleDeCursos
{
    class Curso
    {
        public int codigoCurso;
        public string nomeCurso, conteudoProgramatico, cargaHoraria;
        public double valorMensalidade;
        public string tabela = "tbl_curso";
        //Declarando a classe de conexão
        Conexao objConexao = new Conexao();
        public void CadastrarCurso()
        {
            string inserir = $@"insert into {tabela} values(null,'{nomeCurso}',
                             '{conteudoProgramatico}' , '{valorMensalidade}' , '{cargaHoraria}');";
            //chamando o metodo ExecutarComando para executar o meu insert
            objConexao.ExecutarComando(inserir);
        }

        public void AlterarCurso()
        {

        }

        public void ExcluirCurso()
        {

        }

        public DataTable ListarCursos()     //Requer: using System.Data;
        {
            string consulta = $"select * from {tabela} order by codigo;";
            return objConexao.ExecutarConsulta(consulta);
        }
    }
    class Professor
    { 
        public int codigoProfessor;
        public string nome, telefone;
        public double valorHoraAula;
        public string tabela = "tbl_professor";
        //Declarando a classe de conexão
        Conexao objConexao = new Conexao();
        public void CadastrarCurso()
        {
            string inserir = $@"insert into {tabela} values(null,'{nome}',
                              '{valorHoraAula}' , '{telefone}');";
            //chamando o metodo ExecutarComando para executar o meu insert
            objConexao.ExecutarComando(inserir);
        }
        public DataTable ListarProfessor()     //Requer: using System.Data;
        {
            string consulta = $"select * from {tabela} order by codigo;";
            return objConexao.ExecutarConsulta(consulta);
        }
    }
}
