
namespace PlanejamentoFinanceiro
{
    partial class form_editar_dados
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnEditarDados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(631, 211);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnEditarDados
            // 
            this.btnEditarDados.Location = new System.Drawing.Point(13, 295);
            this.btnEditarDados.Name = "btnEditarDados";
            this.btnEditarDados.Size = new System.Drawing.Size(75, 23);
            this.btnEditarDados.TabIndex = 1;
            this.btnEditarDados.Text = "Editar";
            this.btnEditarDados.UseVisualStyleBackColor = true;
            this.btnEditarDados.Click += new System.EventHandler(this.btnEditarDados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edição de dados de Empresa e Dívida";
            // 
            // form_editar_dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditarDados);
            this.Controls.Add(this.dataGridView2);
            this.Name = "form_editar_dados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar dados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnEditarDados;
        private System.Windows.Forms.Label label1;
    }
}