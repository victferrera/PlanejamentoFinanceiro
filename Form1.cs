using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Parcela parcela = new Parcela();
            dados = parcela.consultaParcela();

            dataGrid1.DataSource = dados.Tables[0];
        }
    }
}
