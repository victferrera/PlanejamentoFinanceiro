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
    public partial class form_edita_divida : Form
    {
        Parcela ParcelaParaEditar = new Parcela();

        public form_edita_divida()
        {
            InitializeComponent();
        }

        public form_edita_divida(Parcela ParcelaRecebida)
        {
            InitializeComponent();
            ParcelaParaEditar = ParcelaRecebida;
        }

        private void form_edita_divida_Load(object sender, EventArgs e)
        {
            dateVencimento.Value = ParcelaParaEditar.dataVencimento;
            numValor.Value = ParcelaParaEditar.valor;
        }
    }
}
