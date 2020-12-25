using System;
using System.Data;
using System.Windows.Forms;

namespace PlanejamentoFinanceiro
{
    public partial class form_editar_dados : Form
    {
        private Empresa empresa = new Empresa();
        private Divida divida = new Divida();
        private int identificador { get; set; }

        public form_editar_dados()
        {
            InitializeComponent();
        }

        public form_editar_dados(Empresa empresa)
        {
            InitializeComponent();
            this.divida.id = 0;
            this.identificador = 1;
            DataSet empresas = empresa.consultaEmpresas();
            dataGridView2.DataSource = empresas.Tables[0];
        }

        public form_editar_dados(Divida divida)
        {
            InitializeComponent();
            this.empresa.cod_cadastro = 0;
            this.identificador = 2;
            DataSet dividas = divida.consultaDividas();
            dataGridView2.DataSource = dividas.Tables[0];
        }

        private void btnEditarDados_Click(object sender, EventArgs e)
        {
            if(this.empresa.cod_cadastro == 0 && this.identificador == 2)
            {
                foreach (DataGridViewRow linhaDivida in dataGridView2.SelectedRows)
                {

                    this.divida.nome = linhaDivida.Cells[1].Value.ToString();
                    this.divida.descricao = linhaDivida.Cells[2].Value.ToString();
                    this.divida.tipoDivida = linhaDivida.Cells[3].Value.ToString();
                    this.divida.id = int.Parse(linhaDivida.Cells[0].Value.ToString());

                    form_editar_dados_2 editarDadosDivida = new form_editar_dados_2(this.divida);
                    editarDadosDivida.ShowDialog();
                }
            }else
            {
                foreach (DataGridViewRow linhaEmpresa in dataGridView2.SelectedRows)
                {
                    this.empresa.nome = linhaEmpresa.Cells[2].Value.ToString();
                    this.empresa.descricao = linhaEmpresa.Cells[3].Value.ToString();
                    this.empresa.cod_cadastro = int.Parse(linhaEmpresa.Cells[0].Value.ToString());

                    form_editar_dados_2 editarDadosEmpresa = new form_editar_dados_2(this.empresa);
                    editarDadosEmpresa.ShowDialog();
                }
            }
        }
    }
}
