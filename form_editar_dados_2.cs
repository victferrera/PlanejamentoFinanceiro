using System;
using System.Windows.Forms;
namespace PlanejamentoFinanceiro
{
    public partial class form_editar_dados_2 : Form
    {
        private Empresa empresa = new Empresa();
        private Divida divida = new Divida();
        private int identificador = 0;
        public form_editar_dados_2()
        {
            InitializeComponent();
        }

        public form_editar_dados_2(Empresa empresa)
        {
            InitializeComponent();
            comboBoxTipoDivida.Visible = false;
            lblTipo.Visible = false;
            this.empresa.nome = empresa.nome;
            this.empresa.descricao = empresa.descricao;
            this.empresa.cod_cadastro = empresa.cod_cadastro;
            this.identificador = 1;
            textBoxNome.Text = this.empresa.nome.ToString();
            textBoxDesc.Text = this.empresa.descricao.ToString();
        }

        public form_editar_dados_2(Divida divida)
        {
            InitializeComponent();
            this.divida.nome = divida.nome;
            this.divida.descricao = divida.descricao;
            this.divida.tipoDivida = divida.tipoDivida;
            this.divida.id = divida.id;
            this.identificador = 2;
            textBoxNome.Text = this.divida.nome.ToString();
            textBoxDesc.Text = this.divida.descricao.ToString();
            comboBoxTipoDivida.Text = this.divida.tipoDivida.ToString();
        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            if(this.identificador == 1)
            {
                this.empresa.editarEmpresa(textBoxNome.Text, textBoxDesc.Text, this.empresa.cod_cadastro);
            }else
            {
                this.divida.editarDivida(textBoxNome.Text, textBoxDesc.Text, comboBoxTipoDivida.Text, this.divida.id);
            }
            
        }
    }
}
