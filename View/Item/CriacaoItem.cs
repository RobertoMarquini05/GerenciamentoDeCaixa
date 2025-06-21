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

namespace Caixa.View.Item
{
    public partial class CriacaoItem : Form
    {
        #region Campos
        private ItemManager _itemManager;
        private Validador _validador;
        private Conversor _conversor;
        #endregion
        #region Construtor
        public CriacaoItem(ItemManager itemManager)
        {
            InitializeComponent();
            _itemManager = itemManager;
            _validador = new Validador();
            _conversor = new Conversor();
        }
        #endregion
        #region Metodos
        private void btnCriarItem_Click(object sender, EventArgs e)
        {
            bool nomeValidado = _validador.ValidaNome(inputNomeItem.Text);
            bool valorValidado = _validador.ValidaValor(inputValorItem.Text);
            bool quantidadeValidado = _validador.ValidaValor(inputQuantidadeItem.Text);

            if (nomeValidado && valorValidado && quantidadeValidado)
            {
                _itemManager.CriarItem(inputNomeItem.Text, _conversor.ConverteValor(inputValorItem.Text), _conversor.ConverteQuantidade(inputQuantidadeItem.Text));
                MessageBox.Show("Item criado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (nomeValidado == false) 
            {
                MessageBox.Show("Favor verificar nome do item!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (valorValidado == false) 
            {
                MessageBox.Show("Favor verificar valor do item!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Favor verificar quantidade do item!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
