
namespace PlanejamentoFinanceiro
{
    partial class form_cadastra_divida
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.comboEmpresa = new System.Windows.Forms.ComboBox();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLANFINDataSet = new PlanejamentoFinanceiro.PLANFINDataSet();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empresaTableAdapter = new PlanejamentoFinanceiro.PLANFINDataSetTableAdapters.EmpresaTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.numericParcelas = new System.Windows.Forms.NumericUpDown();
            this.numericValor = new System.Windows.Forms.NumericUpDown();
            this.dateVencimento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANFINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Dívida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Vencimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Empresa";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(119, 66);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(233, 20);
            this.textNome.TabIndex = 5;
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(119, 95);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(233, 20);
            this.textDescricao.TabIndex = 6;
            // 
            // comboEmpresa
            // 
            this.comboEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empresaBindingSource, "cod_cadastro", true));
            this.comboEmpresa.DataSource = this.empresaBindingSource;
            this.comboEmpresa.DisplayMember = "nome";
            this.comboEmpresa.FormattingEnabled = true;
            this.comboEmpresa.Location = new System.Drawing.Point(119, 173);
            this.comboEmpresa.Name = "comboEmpresa";
            this.comboEmpresa.Size = new System.Drawing.Size(121, 21);
            this.comboEmpresa.TabIndex = 7;
            this.comboEmpresa.ValueMember = "cod_cadastro";
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.pLANFINDataSet;
            // 
            // pLANFINDataSet
            // 
            this.pLANFINDataSet.DataSetName = "PLANFINDataSet";
            this.pLANFINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Fixa",
            "Variável"});
            this.comboTipo.Location = new System.Drawing.Point(119, 226);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 21);
            this.comboTipo.TabIndex = 8;
            this.comboTipo.Text = "Escolha...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nova Dívida";
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Valor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Parcelas";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(22, 290);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // numericParcelas
            // 
            this.numericParcelas.Location = new System.Drawing.Point(119, 147);
            this.numericParcelas.Name = "numericParcelas";
            this.numericParcelas.Size = new System.Drawing.Size(120, 20);
            this.numericParcelas.TabIndex = 16;
            // 
            // numericValor
            // 
            this.numericValor.DecimalPlaces = 2;
            this.numericValor.Location = new System.Drawing.Point(120, 121);
            this.numericValor.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericValor.Name = "numericValor";
            this.numericValor.Size = new System.Drawing.Size(120, 20);
            this.numericValor.TabIndex = 17;
            this.numericValor.ThousandsSeparator = true;
            // 
            // dateVencimento
            // 
            this.dateVencimento.Location = new System.Drawing.Point(119, 200);
            this.dateVencimento.Name = "dateVencimento";
            this.dateVencimento.Size = new System.Drawing.Size(121, 20);
            this.dateVencimento.TabIndex = 18;
            // 
            // form_cadastra_divida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(370, 323);
            this.Controls.Add(this.dateVencimento);
            this.Controls.Add(this.numericValor);
            this.Controls.Add(this.numericParcelas);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.comboEmpresa);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_cadastra_divida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Dívida";
            this.Load += new System.EventHandler(this.form_cadastra_divida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANFINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.ComboBox comboEmpresa;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label6;
        private PLANFINDataSet pLANFINDataSet;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private PLANFINDataSetTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown numericParcelas;
        private System.Windows.Forms.NumericUpDown numericValor;
        private System.Windows.Forms.DateTimePicker dateVencimento;
    }
}