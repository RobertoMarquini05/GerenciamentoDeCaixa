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
    public partial class VisualizacaoItem : Form
    {
        #region Campos
        private ItemManager _itemManager;
        #endregion
        #region Metodos
        public VisualizacaoItem(ItemManager itemManager)
        {
            _itemManager = itemManager;
            InitializeComponent();
        }
        #endregion
        #region Metodos
        private void VisualizacaoItem_Load(object sender, EventArgs e)
        {
            List<Models.Item> listaItensCadastrados = _itemManager.GetListaItens();
            foreach (var item in listaItensCadastrados)
            {
                dgvItens.Rows.Add(item.Nome, item.Valor, item.Quantidade);
            }
        }
        #endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
