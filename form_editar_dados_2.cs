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
    public partial class form_editar_dados_2 : Form
    {
        private Empresa empresa = new Empresa();
        private Divida divida = new Divida();
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
            textBoxNome.Text = this.empresa.nome.ToString();
            textBoxDesc.Text = this.empresa.descricao.ToString();
        }

        public form_editar_dados_2(Divida divida)
        {
            InitializeComponent();
            this.divida.nome = divida.nome;
            this.divida.descricao = divida.descricao;
            this.divida.tipoDivida = divida.tipoDivida;
            textBoxNome.Text = this.divida.nome.ToString();
            textBoxDesc.Text = this.divida.descricao.ToString();
            comboBoxTipoDivida.Text = this.divida.tipoDivida.ToString();
        }

        private void form_editar_dados_2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
