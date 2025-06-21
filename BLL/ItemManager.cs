using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caixa.Models;

namespace Caixa.BLL
{
    public class ItemManager
    {
        #region Campos
        private List<Item> _listaItens;
        #endregion
        #region Construtor
        public ItemManager() 
        {
            _listaItens = new List<Item>();
        }
        #endregion
        #region Metodos
        public void CriarItem(string nome, double valor, int quantidade)
        {
            Item item = new Item(nome, valor, quantidade);
            _listaItens.Add(item);
        }
        public List<Item> GetListaItens()
        {
            return _listaItens;
        }
        #endregion
    }
}
