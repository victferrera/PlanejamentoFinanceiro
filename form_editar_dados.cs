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
    public partial class form_editar_dados : Form
    {
        public form_editar_dados()
        {
            InitializeComponent();
        }

        public form_editar_dados(Empresa empresa)
        {
            InitializeComponent();
            DataSet empresas = empresa.consultaEmpresas();
            dataGridViewDados.DataSource = empresas.Tables[0];
        }

        public form_editar_dados(Divida divida)
        {
            InitializeComponent();
            DataSet dividas = divida.consultaDividas();
            dataGridViewDados.DataSource = dividas.Tables[0];
        }

        private void form_editar_dados_Load(object sender, EventArgs e)
        {

        }
    }
}
