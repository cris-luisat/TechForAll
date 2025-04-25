using MySql.Data.MySqlClient;
using System.Configuration;

namespace TechForAll.Data
{
    public class ConexaoDB
    {
        public ConexaoDB()
        {
            var conexao = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();
        }
    }
}
