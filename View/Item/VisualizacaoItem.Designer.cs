namespace Caixa.View.Item
{
    partial class VisualizacaoItem
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
            dgvItens = new DataGridView();
            nomeItem = new DataGridViewTextBoxColumn();
            btnQuantidade = new DataGridViewTextBoxColumn();
            btnValor = new DataGridViewTextBoxColumn();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            // 
            // dgvItens
            // 
            dgvItens.AllowUserToAddRows = false;
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItens.Columns.AddRange(new DataGridViewColumn[] { nomeItem, btnQuantidade, btnValor });
            dgvItens.Location = new Point(12, 12);
            dgvItens.Name = "dgvItens";
            dgvItens.RowHeadersVisible = false;
            dgvItens.Size = new Size(763, 396);
            dgvItens.TabIndex = 0;
            // 
            // nomeItem
            // 
            nomeItem.HeaderText = "Nome";
            nomeItem.Name = "nomeItem";
            nomeItem.ReadOnly = true;
            nomeItem.Width = 470;
            // 
            // btnQuantidade
            // 
            btnQuantidade.HeaderText = "Quantidade";
            btnQuantidade.Name = "btnQuantidade";
            btnQuantidade.ReadOnly = true;
            // 
            // btnValor
            // 
            btnValor.HeaderText = "Valor";
            btnValor.Name = "btnValor";
            btnValor.ReadOnly = true;
            btnValor.Width = 150;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            btnFechar.Location = new Point(265, 415);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(286, 46);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // VisualizacaoItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 473);
            Controls.Add(btnFechar);
            Controls.Add(dgvItens);
            Name = "VisualizacaoItem";
            Text = "VisualizacaoItem";
            Load += VisualizacaoItem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvItens;
        private Button btnFechar;
        private DataGridViewTextBoxColumn nomeItem;
        private DataGridViewTextBoxColumn btnQuantidade;
        private DataGridViewTextBoxColumn btnValor;
    }
}