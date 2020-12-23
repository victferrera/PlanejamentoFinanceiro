using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Data.SqlClient;

namespace PlanejamentoFinanceiro
{
    public partial class form_telaInicio : Form
    {
        public form_telaInicio()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_cadastro_empresa cadastro_empresa = new form_cadastro_empresa();
            cadastro_empresa.ShowDialog();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_cadastra_divida divida = new form_cadastra_divida();
            divida.ShowDialog();
        }

        private void form_telaInicio_Load(object sender, EventArgs e)
        {

            DataSet dados = new DataSet();

            DataSet comprometido = new DataSet();

            Parcela parcela = new Parcela();

            comprometido = parcela.consultaTotalComprometido();

            dados = parcela.consultaParcela();
            
            dataGrid1.DataSource = dados.Tables[0];

            foreach (DataRow linha in comprometido.Tables[0].Rows)
            {
                numericTotalComprometido.Value = Decimal.Parse(linha["comprometido"].ToString());     
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow linhaParcela in dataGrid1.SelectedRows)
            {
                if (linhaParcela.Cells[3].Value.ToString() == "LIQUIDADO")
                {
                    MessageBox.Show("Status da parcela não permite essa movimentação!");
                }
                else if (linhaParcela.Cells[0].Value == null)
                {
                    MessageBox.Show("Escolha uma parcela para pagar!","Aviso!");
                }else
                {
                    int id_parcela = int.Parse(linhaParcela.Cells[0].Value.ToString());
                    int num_parcela = int.Parse(linhaParcela.Cells[1].Value.ToString());

                    Parcela parcela = new Parcela();
                    parcela.pagarParcela(id_parcela, num_parcela);

                    DataSet dadosAtualizados = parcela.consultaParcela();

                    dataGrid1.DataSource = dadosAtualizados.Tables[0];
                }
            }
        }

        private void btnEstornar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja estornar o pagamento?","Estornar Pagamento",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (DataGridViewRow linhaParcela in dataGrid1.SelectedRows)
                {
                    if (linhaParcela.Cells[3].Value.ToString() != "LIQUIDADO")
                    {
                        MessageBox.Show("Status da parcela não permite essa movimentação!");
                    }
                    else if (linhaParcela.Cells[0].Value == null)
                    {
                        MessageBox.Show("Escolha uma parcela para pagar!", "Aviso!");
                    }
                    else
                    {
                        int id_parcela = int.Parse(linhaParcela.Cells[0].Value.ToString());
                        int num_parcela = int.Parse(linhaParcela.Cells[1].Value.ToString());

                        Parcela parcela = new Parcela();
                        parcela.estornarParcela(id_parcela, num_parcela);

                        DataSet dadosAtualizados = parcela.consultaParcela();

                        dataGrid1.DataSource = dadosAtualizados.Tables[0];
                    }
                }
            }
        }

        private void btnVisualiza_Click(object sender, EventArgs e)
        {
            Parcela parcela = new Parcela();

            foreach (DataGridViewRow linhaParcela in dataGrid1.SelectedRows)
            {
                parcela.id = int.Parse(linhaParcela.Cells[0].Value.ToString());
                parcela.num_parcela = int.Parse(linhaParcela.Cells[1].Value.ToString());
                parcela.dataVencimento = DateTime.Parse(linhaParcela.Cells[2].Value.ToString());
                parcela.valor = (decimal)linhaParcela.Cells[4].Value;    
            }

            form_edita_divida editar = new form_edita_divida(parcela);
            
            editar.ShowDialog();
        }
    }
}
