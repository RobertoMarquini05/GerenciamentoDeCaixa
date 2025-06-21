namespace Caixa.View.Item
{
    partial class CriacaoItem
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
            inputNomeItem = new RichTextBox();
            inputQuantidadeItem = new RichTextBox();
            btnCriarItem = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            inputValorItem = new RichTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // inputNomeItem
            // 
            inputNomeItem.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            inputNomeItem.Location = new Point(193, 56);
            inputNomeItem.Name = "inputNomeItem";
            inputNomeItem.Size = new Size(285, 33);
            inputNomeItem.TabIndex = 0;
            inputNomeItem.Text = "";
            // 
            // inputQuantidadeItem
            // 
            inputQuantidadeItem.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            inputQuantidadeItem.Location = new Point(193, 102);
            inputQuantidadeItem.Name = "inputQuantidadeItem";
            inputQuantidadeItem.Size = new Size(285, 33);
            inputQuantidadeItem.TabIndex = 1;
            inputQuantidadeItem.Text = "";
            // 
            // btnCriarItem
            // 
            btnCriarItem.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            btnCriarItem.Location = new Point(145, 188);
            btnCriarItem.Name = "btnCriarItem";
            btnCriarItem.Size = new Size(193, 47);
            btnCriarItem.TabIndex = 2;
            btnCriarItem.Text = "Criar Item";
            btnCriarItem.UseVisualStyleBackColor = true;
            btnCriarItem.Click += btnCriarItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 54);
            label1.Name = "label1";
            label1.Size = new Size(183, 35);
            label1.TabIndex = 3;
            label1.Text = "Nome do Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(146, 35);
            label2.TabIndex = 4;
            label2.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(126, 9);
            label3.Name = "label3";
            label3.Size = new Size(221, 35);
            label3.TabIndex = 5;
            label3.Text = "Cadastro de Item";
            // 
            // inputValorItem
            // 
            inputValorItem.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            inputValorItem.Location = new Point(193, 149);
            inputValorItem.Name = "inputValorItem";
            inputValorItem.Size = new Size(285, 33);
            inputValorItem.TabIndex = 6;
            inputValorItem.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 147);
            label4.Name = "label4";
            label4.Size = new Size(76, 35);
            label4.TabIndex = 7;
            label4.Text = "Valor";
            // 
            // CriacaoItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 241);
            Controls.Add(label4);
            Controls.Add(inputValorItem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCriarItem);
            Controls.Add(inputQuantidadeItem);
            Controls.Add(inputNomeItem);
            Name = "CriacaoItem";
            Text = "CriacaoItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox inputNomeItem;
        private RichTextBox inputQuantidadeItem;
        private Button btnCriarItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox inputValorItem;
        private Label label4;
    }
}