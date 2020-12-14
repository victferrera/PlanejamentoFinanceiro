using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PlanejamentoFinanceiro
{
    public partial class form_cadastro_empresa : Form
    {
        public form_cadastro_empresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            Comando.setComando("INSERT INTO EMPRESA VALUES(@CNPJ,@NOME,@DESCRICAO)");
            empresa.salvarEmpresa(textNome.Text, textCnpj.Text, rTextDescricao.Text);
        }
    }
}
