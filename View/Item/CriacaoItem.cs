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
        #endregion
        #region Construtor
        public CriacaoItem(ItemManager itemManager)
        {
            InitializeComponent();
            _itemManager = itemManager;
        }
        #endregion
        #region Metodos
        private void btnCriarItem_Click(object sender, EventArgs e)
        {
            bool nomeValidado = ValidaNome(inputNomeItem.Text);
            bool valorValidado = ValidaValor(inputValorItem.Text);
            bool quantidadeValidado = ValidaValor(inputQuantidadeItem.Text);

            if (nomeValidado && valorValidado && quantidadeValidado)
            {
                _itemManager.CriarItem(inputNomeItem.Text, ConverteValor(inputValorItem.Text), ConverteQuantidade(inputQuantidadeItem.Text));
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

        private bool ValidaNome(string nomeItem)
        {
            return nomeItem != string.Empty ? true : false;
        }
        private bool ValidaValor(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return false;

            if (!double.TryParse(valor, out double valorConvertido))
                return false;

            if (double.IsNaN(valorConvertido) || double.IsInfinity(valorConvertido))
                return false;

            if (valorConvertido <= 0)
                return false;

            if (valorConvertido > 1000000)
                return false;

            if (Math.Round(valorConvertido, 2) != valorConvertido)
                return false;

            return true;
        }
        private double ConverteValor(string valor)
        {
            double.TryParse(valor, out double valorConvertido);
            return valorConvertido;
        }
        private int ConverteQuantidade(string quantidade)
        {
            int.TryParse(quantidade, out int valorConvertido);
            return valorConvertido;
        }
        #endregion
    }
}
