﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PlanejamentoFinanceiro
{
    public class Empresa
    {
        public string cnpj { get; set; }
        public string nome { get; set; }
        public int cod_cadastro { get; set; }
        public string descricao { get; set; }
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

        public DataSet consultaEmpresas()
        {
            DataSet empresas = new DataSet();
            string comando = @"SELECT CNPJ AS 'CNPJ', NOME AS 'NOME', DESCRICAO AS 'DESCRIÇÃO'  FROM EMPRESA";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(comando, Banco.getConexao());
                adapter.Fill(empresas);
                Banco.fecharConexao();
                return empresas;
                
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                Banco.fecharConexao();
                return null;
            }
        }
    }
}
