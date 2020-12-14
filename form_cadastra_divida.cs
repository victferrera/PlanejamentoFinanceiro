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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void form_cadastra_divida_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pLANFINDataSet.Empresa'. Você pode movê-la ou removê-la conforme necessário.
            this.empresaTableAdapter.Fill(this.pLANFINDataSet.Empresa);

        }
    }
}
