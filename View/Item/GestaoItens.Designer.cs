namespace Caixa.View
{
    partial class GestaoItens
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
            btnCadastrarItem = new Button();
            btnVisualizarItens = new Button();
            btnEditarItens = new Button();
            SuspendLayout();
            // 
            // btnCadastrarItem
            // 
            btnCadastrarItem.Location = new Point(12, 12);
            btnCadastrarItem.Name = "btnCadastrarItem";
            btnCadastrarItem.Size = new Size(229, 43);
            btnCadastrarItem.TabIndex = 0;
            btnCadastrarItem.Text = "Cadastrar Item";
            btnCadastrarItem.UseVisualStyleBackColor = true;
            btnCadastrarItem.Click += btnCadastrarItem_Click;
            // 
            // btnVisualizarItens
            // 
            btnVisualizarItens.Location = new Point(12, 74);
            btnVisualizarItens.Name = "btnVisualizarItens";
            btnVisualizarItens.Size = new Size(229, 43);
            btnVisualizarItens.TabIndex = 1;
            btnVisualizarItens.Text = "Visualizar Itens";
            btnVisualizarItens.UseVisualStyleBackColor = true;
            btnVisualizarItens.Click += btnVisualizarItens_Click;
            // 
            // btnEditarItens
            // 
            btnEditarItens.Location = new Point(12, 136);
            btnEditarItens.Name = "btnEditarItens";
            btnEditarItens.Size = new Size(229, 43);
            btnEditarItens.TabIndex = 2;
            btnEditarItens.Text = "Editar Itens";
            btnEditarItens.UseVisualStyleBackColor = true;
            btnEditarItens.Click += btnEditarItens_Click;
            // 
            // GestaoItens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditarItens);
            Controls.Add(btnVisualizarItens);
            Controls.Add(btnCadastrarItem);
            Name = "GestaoItens";
            Text = "GestaoItens";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrarItem;
        private Button btnVisualizarItens;
        private Button btnEditarItens;
    }
}