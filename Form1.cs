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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void novaDívidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_cadastro_empresa cadastro_empresa = new form_cadastro_empresa();
            cadastro_empresa.ShowDialog();
        }
    }
}
