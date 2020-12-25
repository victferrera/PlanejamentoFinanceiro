using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace PlanejamentoFinanceiro
{
    public class Divida
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string tipoDivida { get; set; }
        public int cod_cadastro { get; set; }
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

                parcela.salvarParcelas(dataVencimento, valor, parcelas);

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataSet consultaDividas()
        {
            DataSet dividas = new DataSet();
            string comando = @"SELECT DIVIDA.ID AS 'ID', DIVIDA.NOME AS 'NOME', DIVIDA.DESCRICAO AS 'DESCRIÇÃO', CASE WHEN TIPODIVIDA = 'V' THEN 'VARIÁVEL' WHEN TIPODIVIDA = 'F' THEN 'FIXA' END AS 'TIPO DÍVIDA' FROM DIVIDA INNER JOIN EMPRESA ON EMPRESA.COD_CADASTRO = DIVIDA.COD_CADASTRO";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(comando, Banco.getConexao());
                adapter.Fill(dividas);
                Banco.fecharConexao();
                return dividas;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                Banco.fecharConexao();
                return null;
            }
        }

        public void editarDivida(string nome, string descricao, string tipoDivida, int id)
        {
            string comando = @"UPDATE DIVIDA SET NOME = @NOME, DESCRICAO = @DESCRICAO, TIPODIVIDA = @TIPODIVIDA WHERE ID = @ID";
            Comando.setComando(comando);
            SqlCommand sqlcommand = Comando.getComando();
            sqlcommand.Parameters.Clear();
            sqlcommand.Parameters.AddWithValue("@NOME", nome );
            sqlcommand.Parameters.AddWithValue("@DESCRICAO", descricao);
            sqlcommand.Parameters.AddWithValue("@TIPODIVIDA", tipoDivida.Substring(0,1));
            sqlcommand.Parameters.AddWithValue("@ID", id);

            try
            {
                sqlcommand.ExecuteNonQuery();
                MessageBox.Show("Dados da Dívida alterados com sucesso!");
                Banco.fecharConexao();
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
                Banco.fecharConexao();
            }
        }
        
    }
}
