using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaCar.Conn
{
    class Conexao
    {
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection
                ("Server=localhost;Database=loja;Uid=root;PWD=;");

            try
            {
                conn.Open();
            }
            catch(Exception ex) 
            {
                conn = null;
                MessageBox.Show(ex.Message);
            }
            return conn;
        }
    }
}
