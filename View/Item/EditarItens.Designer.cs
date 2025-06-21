namespace Caixa.View.Item
{
    partial class EditarItens
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
            comboBox1 = new ComboBox();
            inputQuantidade = new RichTextBox();
            inputValor = new RichTextBox();
            inputDisponivel = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(305, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(354, 43);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // inputQuantidade
            // 
            inputQuantidade.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            inputQuantidade.Location = new Point(305, 149);
            inputQuantidade.Name = "inputQuantidade";
            inputQuantidade.Size = new Size(354, 43);
            inputQuantidade.TabIndex = 2;
            inputQuantidade.Text = "";
            // 
            // inputValor
            // 
            inputValor.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            inputValor.Location = new Point(305, 198);
            inputValor.Name = "inputValor";
            inputValor.Size = new Size(354, 43);
            inputValor.TabIndex = 3;
            inputValor.Text = "";
            // 
            // inputDisponivel
            // 
            inputDisponivel.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            inputDisponivel.FormattingEnabled = true;
            inputDisponivel.Items.AddRange(new object[] { "Sim", "Não" });
            inputDisponivel.Location = new Point(305, 247);
            inputDisponivel.Name = "inputDisponivel";
            inputDisponivel.Size = new Size(354, 43);
            inputDisponivel.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            label1.Location = new Point(265, 32);
            label1.Name = "label1";
            label1.Size = new Size(159, 35);
            label1.TabIndex = 5;
            label1.Text = "Editar Itens";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            label2.Location = new Point(39, 91);
            label2.Name = "label2";
            label2.Size = new Size(206, 35);
            label2.TabIndex = 6;
            label2.Text = "Selecione o item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            label3.Location = new Point(39, 157);
            label3.Name = "label3";
            label3.Size = new Size(146, 35);
            label3.TabIndex = 7;
            label3.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            label4.Location = new Point(39, 206);
            label4.Name = "label4";
            label4.Size = new Size(76, 35);
            label4.TabIndex = 8;
            label4.Text = "Valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            label5.Location = new Point(39, 255);
            label5.Name = "label5";
            label5.Size = new Size(129, 35);
            label5.TabIndex = 9;
            label5.Text = "Disponivel";
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            button1.Location = new Point(165, 328);
            button1.Name = "button1";
            button1.Size = new Size(337, 51);
            button1.TabIndex = 10;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditarItens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 394);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputDisponivel);
            Controls.Add(inputValor);
            Controls.Add(inputQuantidade);
            Controls.Add(comboBox1);
            Name = "EditarItens";
            Text = "EditarItens";
            Load += EditarItens_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private RichTextBox inputQuantidade;
        private RichTextBox inputValor;
        private ComboBox inputDisponivel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}