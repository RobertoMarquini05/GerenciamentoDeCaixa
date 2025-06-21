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
        private List<ItemCadastrado> _listaItens;
        #endregion
        #region Construtor
        public ItemManager() 
        {
            _listaItens = new List<ItemCadastrado>();
        }
        #endregion
        #region Metodos
        public void CriarItem(string nome, double valor, int quantidade)
        {
            ItemCadastrado item = new ItemCadastrado(nome, valor, quantidade);
            _listaItens.Add(item);
        }
        public void EditarItem(string nome, int quantidade, double valor, bool disponivel)
        {
            ItemCadastrado itemParaAtualizar = GetItem(nome);
            itemParaAtualizar.Quantidade = quantidade;
            itemParaAtualizar.Valor = valor;
            itemParaAtualizar.Disponivel = disponivel;
        }
        public List<ItemCadastrado> GetListaItens()
        {
            return _listaItens;
        }
        public ItemCadastrado GetItem(string nome)
        {
            // Impossível retornar nulo devido a chamada vindo de um combobox que é alimentado por essa lista
            return _listaItens.Where(x => x.Nome == nome).FirstOrDefault();
        }
        #endregion
    }
}
