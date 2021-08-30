using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;


namespace _3A2ENZO10
{
    class Conexao
    {
        MySqlConnection conexao;//Feito com basa no projeto controle de cursos

        public void Conectar()
        {
            try
            {

                string dados_conexao = "Persist Security Info = false;" +
                                   "server = localhost;" +
                                   "database = 3a2enzo10;" +
                                   "uid = root; pwd=";
                conexao = new MySqlConnection(dados_conexao);

                conexao.Open();
            }
            catch (MySqlException erro)
            {
                throw new Exception("ERRO\n" + erro.Message);
            }
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
        public void ExecutarComando(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException erro)
            {
                throw new Exception("erro\n" + erro.Message);
            }

            finally
            {
                conexao.Close();
            }
        }
    }
}
