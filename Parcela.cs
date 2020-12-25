using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PlanejamentoFinanceiro
{
    public class Parcela
    {
        public int id { get; set; }
        public int num_parcela { get; set; }
        public DateTime dataVencimento { get; set; }
        public char status { get; set; }
        public decimal valor { get; set; }
        public int id_divida { get; private set; }

        public Parcela()
        {
            id = 0;
            num_parcela = 0;
        }

        public void salvarParcelas(DateTime dataVencimento, decimal valor, decimal parcelas)
        {

            decimal valor_parcelado = valor / parcelas;
            decimal resto = valor % parcelas;
            decimal parcela = parcelas + resto;
            int i = 1;
            object id = 1;

            DateTime vencimento = dataVencimento;

            try
            {
                
                SqlCommand comando = Comando.getComando();
                Comando.setComando("SELECT MAX(ID) FROM DIVIDA");
                id = comando.ExecuteScalar();
                
                Banco.fecharConexao();

                Comando.setComando("INSERT INTO PARCELA VALUES (@NUM_PARCELA,@VENCIMENTO,@STATUS,@VALOR,@ID_DIVIDA)");

                while (i <= parcela )
                {
                    comando.Parameters.AddWithValue("@NUM_PARCELA", i);
                    comando.Parameters.AddWithValue("@VENCIMENTO", vencimento);
                    comando.Parameters.AddWithValue("@STATUS", 'P');
                    comando.Parameters.AddWithValue("@VALOR", Math.Round(valor_parcelado+resto, 2));
                    resto = 0;
                    comando.Parameters.AddWithValue("@ID_DIVIDA", id);
                    comando.ExecuteNonQuery();
                    Comando.limparParametros();
                    i += 1;
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

        public DataSet consultaParcela()
        {
            DataSet dados = new DataSet();

            try
            {
                DateTime vigencia = DateTime.Now;

                string comando = "SELECT ID_PARCELA AS 'ID' ,PA.num_parcela AS 'NUM.PARCELA', CONVERT(VARCHAR(10), DATAVENCIMENTO, 103) AS 'DATA VENCIMENTO', CASE WHEN PA.status = 'P' THEN 'PENDENTE' WHEN PA.status = 'L' THEN 'LIQUIDADO' ELSE PA.status END AS 'STATUS', PA.valor AS 'VALOR', DIV.descricao AS 'DESCRICAO' FROM PARCELA PA INNER JOIN DIVIDA DIV ON DIV.id = PA.id_divida WHERE MONTH(DATAVENCIMENTO) = " + vigencia.Month+" AND STATUS IN ('P','L')";


                SqlDataAdapter adapter = new SqlDataAdapter(comando, Banco.getConexao());

                adapter.Fill(dados);

                Banco.fecharConexao();
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            return dados;
        }

        public void pagarParcela(int id_parcela, int num_parcela)
        {
            try
            {
                

                Comando.setComando("UPDATE PARCELA SET STATUS = 'L' WHERE ID_PARCELA = " + id_parcela + " AND NUM_PARCELA = " + num_parcela);

                SqlCommand comando = Comando.getComando();

                comando.ExecuteNonQuery();

                Banco.fecharConexao();

                MessageBox.Show("Parcela paga com sucesso!");
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        public void estornarParcela(int id_parcela, int num_parcela)
        {
            try
            {


                Comando.setComando("UPDATE PARCELA SET STATUS = 'P' WHERE ID_PARCELA = " + id_parcela + " AND NUM_PARCELA = " + num_parcela);

                SqlCommand comando = Comando.getComando();

                comando.ExecuteNonQuery();

                Banco.fecharConexao();

                MessageBox.Show("Parcela estornada com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        public DataSet consultaTotalComprometido()
        {
            try
            {
                DataSet comprometidoDataSet = new DataSet();

                DateTime vigencia = DateTime.Now;
                
                string comando = (@"SELECT ISNULL(SUM(VALOR),0) AS COMPROMETIDO FROM PARCELA WHERE MONTH(dataVencimento) = " + vigencia.Month + " AND STATUS IN ('P','L')");

                SqlDataAdapter adapter = new SqlDataAdapter(comando, Banco.getConexao());

                adapter.Fill(comprometidoDataSet);

                Banco.fecharConexao();

                return comprometidoDataSet;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
            
        }

        public void editarParcela(Parcela ParcelaParaEditar, DateTime dateVencimento, decimal numValor)
        {
            Comando.setComando("UPDATE PARCELA SET dataVencimento = @dataVencimento, valor = @valor WHERE id_parcela = @id_parcela and num_parcela = @num_parcela");
            SqlCommand comando = Comando.getComando();
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@dataVencimento", dateVencimento);
            comando.Parameters.AddWithValue("@valor", numValor);
            comando.Parameters.AddWithValue("@id_parcela", ParcelaParaEditar.id);
            comando.Parameters.AddWithValue("@num_parcela", ParcelaParaEditar.num_parcela);
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Parcela alterada com sucesso!");
                Banco.fecharConexao();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                Banco.fecharConexao();
            }
        }
    }
}
