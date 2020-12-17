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
    public partial class form_cadastra_divida : Form
    {
        public form_cadastra_divida()
        {
            InitializeComponent();
        }

        private void form_cadastra_divida_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pLANFINDataSet.Empresa'. Você pode movê-la ou removê-la conforme necessário.
            this.empresaTableAdapter.Fill(this.pLANFINDataSet.Empresa);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Divida divida = new Divida();
            Comando.setComando("INSERT INTO DIVIDA VALUES (@NOME, @DESCRICAO, @TIPO, @EMPRESA)");
            divida.salvarDivida(textNome.Text,textDescricao.Text, numericValor.Value, numericParcelas.Value, comboEmpresa.SelectedValue, dateVencimento.Value, comboTipo.SelectedItem);

        }
       
    }
}
