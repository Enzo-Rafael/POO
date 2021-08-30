using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Feito com basa no projeto controle de cursos
namespace _3A2ENZO10
{
    class Class3A2ENZO10
    {
        MySqlConnection conexao;
        public void Conectar()
        {
            
           
                string enzodados = "Persist Security Info=false;" + "server=localhost;" + "database=3a2enzo10" + "uid=root; pwd=";
                conexao = new MySqlConnection(enzodados);
                conexao.Open();
           
        }
        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                Conectar();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                DataTable dt = new DataTable();
                dados.Fill(dt);
                return dt;
            }
            finally
            {
                conexao.Close();
            }
        }
        public void ExecutarComando(string sql) {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();   
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
