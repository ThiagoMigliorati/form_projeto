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
        public int dor_intensidade_relatorio;

        public string obs_relatorio;

        public int q1_relatorio;
        public int q2_relatorio;
        public int q3_relatorio;
        public int q4_relatorio;
        public int q5_relatorio;
        public int q6_relatorio;
        public int q7_relatorio;
        public int q8_relatorio;
        public int q9_relatorio;
        public int q10_relatorio;
        public int q11_relatorio;

        // Variaveis relacionadas a conexão com o DB MySQL
        private string server = "localhost";
        private string user = "root";
        private string password = "";
        private string db = "db_relatorio_teste";

        public string problemas = ""; 
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


        /* Resultados da função
         * return 0 = Conexão realizada com sucesso
         * return 1 = Problemas na conexão com o db
         * return 2 = Problemas na inclusão de dados no db
         */ 
        public int gravaRelatorio()

        {

            string strColunas = "@cafe_rel, @colacao_rel, @almoco_rel, @lanche_rel, @jantar_rel, @ceia_rel, @liquido_rel, @urina_rel, @evacuacao_rel, @banho_rel, @sono_rel, @intensidade_dor_rel, @obs_rel, @q1_rel,  @q2_rel,  @q3_rel,  @q4_rel,  @q5_rel,  @q6_rel,  @q7_rel,  @q8_rel,  @q9_rel,  @q10_rel,  @q11_rel, @cuidador_rel, @idoso_rel ";
            string strValues = "cafe_relatorio, colacao_relatorio, almoco_relatorio, lanche_relatorio, jantar_relatorio, ceia_relatorio, liquido_relatorio, urina_relatorio, evacuacao_relatorio, banho_relatorio, sono_relatorio, intensidade_dor_relatorio, obs_relatorio, q1_relatorio, q2_relatorio, q3_relatorio, q4_relatorio, q5_relatorio, q6_relatorio, q7_relatorio, q8_relatorio, q9_relatorio, q10_relatorio, q11_relatorio, fk_cuidador, fk_idoso";
            string strInsert = "insert into tb_relatorio (" + strValues + ") values (" + strColunas + ")";

            conexao.Open();

            if (conexaoDb())
            {
                //Conexão realizada com sucesso

                try
                {
                    MySqlCommand insert = new MySqlCommand(strInsert, conexao);

                    fk_cuidador = 1;
                    fk_idoso = 1;

                    insert.Parameters.AddWithValue("@cafe_rel", cafe_relatorio);
                    insert.Parameters.AddWithValue("@colacao_rel", colacao_relatorio);
                    insert.Parameters.AddWithValue("@almoco_rel", almoco_relatorio);
                    insert.Parameters.AddWithValue("@lanche_rel", lanche_relatorio);
                    insert.Parameters.AddWithValue("@jantar_rel", jantar_relatorio);
                    insert.Parameters.AddWithValue("@ceia_rel", ceia_relatorio);
                    insert.Parameters.AddWithValue("@liquido_rel", liquido_relatorio);
                    insert.Parameters.AddWithValue("@urina_rel", urina_relatorio);
                    insert.Parameters.AddWithValue("@evacuacao_rel", evacuacao_relatorio);
                    insert.Parameters.AddWithValue("@banho_rel", banho_relatorio);
                    insert.Parameters.AddWithValue("@sono_rel", sono_relatorio);
                    insert.Parameters.AddWithValue("@intensidade_dor_rel", dor_intensidade_relatorio);
                    insert.Parameters.AddWithValue("@obs_rel", obs_relatorio);
                    insert.Parameters.AddWithValue("@q1_rel", q1_relatorio);
                    insert.Parameters.AddWithValue("@q2_rel", q2_relatorio);
                    insert.Parameters.AddWithValue("@q3_rel", q3_relatorio);
                    insert.Parameters.AddWithValue("@q4_rel", q4_relatorio);
                    insert.Parameters.AddWithValue("@q5_rel", q5_relatorio);
                    insert.Parameters.AddWithValue("@q6_rel", q6_relatorio);
                    insert.Parameters.AddWithValue("@q7_rel", q7_relatorio);
                    insert.Parameters.AddWithValue("@q8_rel", q8_relatorio);
                    insert.Parameters.AddWithValue("@q9_rel", q9_relatorio);
                    insert.Parameters.AddWithValue("@q10_rel", q10_relatorio);
                    insert.Parameters.AddWithValue("@q11_rel", q11_relatorio);
                    insert.Parameters.AddWithValue("@cuidador_rel", fk_cuidador);
                    insert.Parameters.AddWithValue("@idoso_rel", fk_idoso);

                    insert.ExecuteNonQuery();
                    conexao.Close();
                    return 0;
                }
                catch (MySqlException ex)
                {
                    problemas = ex.ToString();
                    return 2;
                }
            }
            else
            {
                
                return 1;
            }
            
        }// end method gravaRelatorio

        public List<classe_idoso> idosoComboboxReturn()
        {

            if (conexaoDb())
            {

                List<classe_idoso> idosoList = new List<classe_idoso>();
                var command = conexao.CreateCommand();

                //conexao.Open();

                command.CommandText = "Select * from tb_idoso";
                command.ExecuteNonQuery();
                MySqlDataReader dtreader = command.ExecuteReader();

                while (dtreader.Read())//Enquanto existir dados no select
                {
                    classe_idoso objIdoso = new classe_idoso();
                    objIdoso.nome_idoso = dtreader["nome_idoso"].ToString();
                    objIdoso.id_idoso = Convert.ToInt32(dtreader["id_idoso"]);
                    idosoList.Add(objIdoso);
                    
                }// end while

                conexao.Close();
                return idosoList;
            }
            else
            {
                return null;
            }

            return null;

        }// end metodo

    }// end class
}
