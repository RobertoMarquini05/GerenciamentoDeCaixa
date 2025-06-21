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
        public void CriarItem(string nome, double valor, int quantidade)
        {
            Item item = new Item(nome, valor, quantidade);
        }
    }
}
