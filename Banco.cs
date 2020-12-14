using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PlanejamentoFinanceiro
{
    static class Banco
    {
        private static SqlConnection conexao = new SqlConnection("Server=DESKTOP-IK3RJ21;Database=PLANFIN;Trusted_Connection=True;");
        private static void abrirConexao()
        {
            conexao.Open();
        }

        public static void fecharConexao()
        {
            conexao.Close();
        }

        public static SqlConnection getConexao()
        {
            abrirConexao();
            return conexao;
        }
    }
}
