using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace form_projeto
{
    class classe_relatorio
    {
        public string data_relatorio;
        public int fk_cuidador;
        public int fk_idoso;

        public string cafe_relatorio;
        public string colacao_relatorio;
        public string almoco_relatorio;
        public string lanche_relatorio;
        public string jantar_relatorio;
        public string ceia_relatorio;

        public string liquido_relatorio;
        public string urina_relatorio;
        public string evacuacao_relatorio;
        public string banho_relatorio;
        public string sono_relatorio;
        public string dor_intensidade_relatorio;

        public string obs_relatorio;

        public string q1_relatorio;
        public string q2_relatorio;
        public string q3_relatorio;
        public string q4_relatorio;
        public string q5_relatorio;
        public string q6_relatorio;
        public string q7_relatorio;
        public string q8_relatorio;
        public string q9_relatorio;
        public string q10_relatorio;
        public string q11_relatorio;

        // Variaveis relacionadas a conexão com o DB MySQL
        private string server = "localhost";
        private string user = "root";
        private string password = "";
        private string db = "csharp_db";
        MySqlConnection conexao;

        private bool conexaoDb()
        {
            string configuracao = "server=" + server + ";user=" + user + ";database=" + db;
            conexao = new MySqlConnection(configuracao);

            try
            {
                conexao.Open();
            }
            catch
            {
                return false;
            }

            return true;
        }// end method conexao

        public int gravaRelatorio()

        {

            string strColunas = "@nome, @valor";
            string strValues = "nome_usuario, valor_usuario";
            string strInsert = "insert into tbl_usuarios (" + strValues + ") values (" + strColunas + ")";

            
            
            if (conexaoDb())
            {
                //Conexão realizada com sucesso

                try
                {
                    MySqlCommand insert = new MySqlCommand(strInsert, conexao);
                    insert.Parameters.AddWithValue("@nome", "nomeTeste");
                    insert.Parameters.AddWithValue("@valor", "2233");
                    insert.ExecuteNonQuery();
                    conexao.Close();
                    return 0;
                }
                catch
                {
                    return 2;
                }
                

            }
            else
            {
                
                return 1;
            }
            
        }// end method gravaRelatorio

    }// end class
}
