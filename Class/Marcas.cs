using LojaCar.Conn;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaCar.Class
{
    internal class Marcas
    {
        private int id;
        private string marca;

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }

        public static string salvar(Marcas m)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "INSERT INTO marcas VALUES (null, @marca)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@marca", m.Marca);
                cmd.ExecuteNonQuery();
                return "Marca salva com sucesso";
            }
            catch (Exception ex)
            {
                return "erro: " + ex.Message;
            }
        }

        public static string listar()
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM marcas";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader res = cmd.ExecuteReader();
            string lista = "Lista de marcas \n";
            if (res.HasRows) 
            {
                while (res.Read())
                {
                    lista += "ID: " + res["id"].ToString();
                    lista += " - Marca: " + res["marca"].ToString();
                    lista += "\n";
                }
            }
            return lista;
        }

        public static Boolean pesquisar(Marcas m)
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT mar.* FROM marcas mar WHERE mar.id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", m.Id);
            MySqlDataReader res = cmd.ExecuteReader();
            Boolean verificar = false;
            if (res.HasRows)
            {
                while (res.Read())
                {
                    m.Id = Int32.Parse(res["id"].ToString());
                    m.Marca = res["marca"].ToString();
                    verificar = true;
                }
            }
            return verificar;
        }

        public string excluir(string id)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "DELETE FROM categoria WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return "Marca excluída";
            }
            catch (Exception ex)
            {
                return "erro: " + ex.Message;
            }
        }

        public static string editar(Marcas m)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "UPDATE categoria SET nome = @nome WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", m.Id);
                cmd.Parameters.AddWithValue("@marca", m.Marca);
                cmd.ExecuteNonQuery();
                return "Marca editada com sucesso";
            }
            catch (Exception ex)
            {
                return "erro: " + ex.Message;
            }
        }

        public static MySqlDataReader carregar()
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM marcas";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader res = cmd.ExecuteReader();

            return res;
        }

    }
}
