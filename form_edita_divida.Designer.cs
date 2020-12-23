
namespace PlanejamentoFinanceiro
{
    partial class form_edita_divida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateVencimento = new System.Windows.Forms.DateTimePicker();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.lblDataVencimentoEditar = new System.Windows.Forms.Label();
            this.lblValorEditar = new System.Windows.Forms.Label();
            this.btnSalvarEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.SuspendLayout();
            // 
            // dateVencimento
            // 
            this.dateVencimento.Location = new System.Drawing.Point(145, 39);
            this.dateVencimento.Name = "dateVencimento";
            this.dateVencimento.Size = new System.Drawing.Size(227, 20);
            this.dateVencimento.TabIndex = 2;
            // 
            // numValor
            // 
            this.numValor.DecimalPlaces = 2;
            this.numValor.Location = new System.Drawing.Point(145, 78);
            this.numValor.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(120, 20);
            this.numValor.TabIndex = 3;
            this.numValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDataVencimentoEditar
            // 
            this.lblDataVencimentoEditar.AutoSize = true;
            this.lblDataVencimentoEditar.Location = new System.Drawing.Point(35, 46);
            this.lblDataVencimentoEditar.Name = "lblDataVencimentoEditar";
            this.lblDataVencimentoEditar.Size = new System.Drawing.Size(104, 13);
            this.lblDataVencimentoEditar.TabIndex = 4;
            this.lblDataVencimentoEditar.Text = "Data de Vencimento";
            // 
            // lblValorEditar
            // 
            this.lblValorEditar.AutoSize = true;
            this.lblValorEditar.Location = new System.Drawing.Point(35, 80);
            this.lblValorEditar.Name = "lblValorEditar";
            this.lblValorEditar.Size = new System.Drawing.Size(31, 13);
            this.lblValorEditar.TabIndex = 5;
            this.lblValorEditar.Text = "Valor";
            // 
            // btnSalvarEditar
            // 
            this.btnSalvarEditar.Location = new System.Drawing.Point(145, 125);
            this.btnSalvarEditar.Name = "btnSalvarEditar";
            this.btnSalvarEditar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEditar.TabIndex = 6;
            this.btnSalvarEditar.Text = "Salvar";
            this.btnSalvarEditar.UseVisualStyleBackColor = true;
            // 
            // form_edita_divida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 160);
            this.Controls.Add(this.btnSalvarEditar);
            this.Controls.Add(this.lblValorEditar);
            this.Controls.Add(this.lblDataVencimentoEditar);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.dateVencimento);
            this.Name = "form_edita_divida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Dívida";
            this.Load += new System.EventHandler(this.form_edita_divida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateVencimento;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Label lblDataVencimentoEditar;
        private System.Windows.Forms.Label lblValorEditar;
        private System.Windows.Forms.Button btnSalvarEditar;
    }
}