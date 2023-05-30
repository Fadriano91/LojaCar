using LojaCar.Conn;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaCar.Class
{
    internal class Carros
    {
        private int id;
        private string modelo;
        private int ano;
        private string cor;
        private int id_marca;

        public int Id { get => id; set => id = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Ano { get => ano; set => ano = value; }
        public string Cor { get => cor; set => cor = value; }
        public int Id_marca { get => id_marca; set => id_marca = value; }

        public static string salvar(Carros c)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "INSERT INTO carros VALUES (null, @modelo, @ano, @cor, @id_marca)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@modelo", c.modelo);
                cmd.Parameters.AddWithValue("@ano", c.ano);
                cmd.Parameters.AddWithValue("@cor", c.cor);
                cmd.Parameters.AddWithValue("@id_marca", c.id_marca);
                cmd.ExecuteNonQuery();
                return "Carro salvo com sucesso";
            }
            catch (Exception ex)
            {
                return "erro: " + ex.Message;
            }
        }

        public static string  listar()
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT c.id, c.modelo, c.ano, c.cor, m.marca as marca FROM carros c INNER JOIN marcas m ON m.id = c.id_marca";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader res = cmd.ExecuteReader();
            string lista = "Lista de carros \n";
            if(res.HasRows)
            {
                while(res.Read())
                {
                    lista += "ID: " + res["id"].ToString();
                    lista += " - Modelo: " + res["modelo"].ToString();
                    lista += " - Ano: " + res["ano"].ToString();
                    lista += " - Cor: " + res["cor"].ToString();
                    lista += " - Marca: " + res["marca"].ToString();
                    lista += "\n";
                }
            }
            return lista;
        }
    }
}
