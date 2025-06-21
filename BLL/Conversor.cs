using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.BLL
{
    public class Conversor
    {
        public double ConverteValor(string valor)
        {
            double.TryParse(valor, out double valorConvertido);
            return valorConvertido;
        }
        public int ConverteQuantidade(string quantidade)
        {
            int.TryParse(quantidade, out int valorConvertido);
            return valorConvertido;
        }
        public bool ConverteDisponibilidade(string disponibilidade)
        {
            return disponibilidade == "Sim" ? true : false;
        }
    }
}
