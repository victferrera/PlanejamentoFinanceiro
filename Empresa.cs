using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PlanejamentoFinanceiro
{
    class Empresa
    {
        public void salvarEmpresa(string nome, string cnpj, string descricao)
        {
            try
            {
                SqlCommand novoComando = Comando.getComando();
                novoComando.Parameters.AddWithValue("@NOME", nome);
                novoComando.Parameters.AddWithValue("@CNPJ", cnpj);
                novoComando.Parameters.AddWithValue("@DESCRICAO", descricao);
                novoComando.ExecuteNonQuery();
                Comando.limparParametros();
                Banco.fecharConexao();
                MessageBox.Show("Empresa salva com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }

        }
    }
}
