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
using Caixa.View.Item;

namespace Caixa.View
{
    public partial class GestaoItens : Form
    {
        #region Campos
        ItemManager itemManager = new ItemManager();
        #endregion
        #region Construtor
        public GestaoItens()
        {
            InitializeComponent();
        }
        #endregion
        #region Metodos
        private void btnCadastrarItem_Click(object sender, EventArgs e)
        {
            CriacaoItem criacaoItem = new CriacaoItem(itemManager);
            criacaoItem.ShowDialog();
        }
        #endregion
    }
}
