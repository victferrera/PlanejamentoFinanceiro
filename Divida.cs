using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PlanejamentoFinanceiro
{
    class Divida
    {
        public void salvarDivida(string nome, string descricao, decimal valor, decimal parcelas, object idEmpresa, DateTime dataVencimento, object tipoDivida)
        {
            try
            {
                SqlCommand novoComando = Comando.getComando();
                novoComando.Parameters.AddWithValue("NOME", nome);
                novoComando.Parameters.AddWithValue("@DESCRICAO", descricao);
                novoComando.Parameters.AddWithValue("@TIPO", tipoDivida.ToString().Substring(0, 1));
                novoComando.Parameters.AddWithValue("@EMPRESA", Decimal.Parse(idEmpresa.ToString()));
                novoComando.ExecuteNonQuery();
                Comando.limparParametros();
                Banco.fecharConexao();
                MessageBox.Show("Dívida cadastrada com sucesso!");

                Parcela parcela = new Parcela();

                //DateTime dataVencimento, decimal valor, int parcelas

                parcela.salvarParcelas(dataVencimento, valor, parcelas);

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
