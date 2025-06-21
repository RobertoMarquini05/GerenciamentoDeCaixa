using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caixa.BLL;
using Caixa.Models;

namespace Caixa.View.Item
{
    public partial class EditarItens : Form
    {
        #region Campos
        private ItemManager _itemManager;
        private Validador _validador;
        private Conversor _conversor;
        private List<ItemCadastrado> _itensCadastrados;
        #endregion
        #region Construtor
        public EditarItens(ItemManager itemManager)
        {
            _itemManager = itemManager;
            _validador = new Validador();
            _conversor = new Conversor();
            _itensCadastrados = _itemManager.GetListaItens();
            InitializeComponent();
        }
        #endregion
        #region Metodos
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemCadastrado itemParaAtualizar = _itemManager.GetItem(comboBox1.Text);
            inputQuantidade.Text = itemParaAtualizar.Quantidade.ToString();
            inputValor.Text = itemParaAtualizar.Valor.ToString();
            inputDisponivel.Text = "Sim";
        }
        private void EditarItens_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _itensCadastrados.Count(); i++)
            {
                comboBox1.Items.Add(_itensCadastrados[i].Nome);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool quantidadeValidado = _validador.ValidaValor(inputQuantidade.Text);
            bool valorValidado = _validador.ValidaValor(inputValor.Text);
            if (quantidadeValidado && valorValidado)
            {
                _itemManager.EditarItem(comboBox1.Text, _conversor.ConverteQuantidade(inputQuantidade.Text), _conversor.ConverteValor(inputValor.Text), _conversor.ConverteDisponibilidade(inputDisponivel.Text));
                MessageBox.Show($"Item {comboBox1.Text} atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (!quantidadeValidado)
            {
                MessageBox.Show("Favor verificar quantidade do item!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Favor verificar valor do item!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
