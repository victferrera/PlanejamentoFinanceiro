using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PlanejamentoFinanceiro
{
    class Parcela
    {
        public void salvarParcelas(DateTime dataVencimento, decimal valor, decimal parcelas)
        {
            decimal parcela = parcelas;
            decimal valor_parcelado = valor / parcelas;
            object id = 0;

            DateTime vencimento = dataVencimento;

            try
            {
                
                SqlCommand comando = Comando.getComando();
                Comando.setComando("SELECT MAX(ID) FROM DIVIDA");
                id = comando.ExecuteScalar();
                
                Banco.fecharConexao();

                Comando.setComando("INSERT INTO PARCELA VALUES (@NUM_PARCELA,@VENCIMENTO,@STATUS,@VALOR,@ID_DIVIDA)");

                while (parcela != 0)
                {
                    comando.Parameters.AddWithValue("@NUM_PARCELA", parcela);
                    comando.Parameters.AddWithValue("@VENCIMENTO", vencimento);
                    comando.Parameters.AddWithValue("@STATUS", 'P');
                    comando.Parameters.AddWithValue("@VALOR", Math.Round(valor_parcelado,28));
                    comando.Parameters.AddWithValue("@ID_DIVIDA", id);
                    comando.ExecuteNonQuery();
                    Comando.limparParametros();
                    parcela -= 1;
                    vencimento = vencimento.AddDays(30);
                }

                Comando.limparParametros();
                Banco.fecharConexao();
                MessageBox.Show("Parcelamento criado!");

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
    }
}
