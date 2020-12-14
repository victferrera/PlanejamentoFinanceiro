using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PlanejamentoFinanceiro
{
    static class Comando
    {
        private static SqlCommand comando = new SqlCommand();

        public static void setComando(string comandoParaExecutar)
        {
            
            comando.CommandText = comandoParaExecutar;
            comando.Connection = Banco.getConexao();
        }
        public static void limparParametros()
        {
            comando.Parameters.Clear();
        }

        public static SqlCommand getComando()
        {
            return comando;
        }
    }
}
