
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Gerente_de_estudantes
{
    internal class MEU_BD
    {
        private MySqlConnection conexao = new MySqlConnection("datasourse=localhost;username:root;password;database=segurança -100");

        public MySqlConnection getConexao
        {

            get
            {
                return conexao;
            }
        }

        public void abrirConexao() 
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }
        public void fechaConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
    