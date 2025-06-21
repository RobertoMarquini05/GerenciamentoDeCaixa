using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.BLL
{
    public class Validador
    {
        public bool ValidaNome(string nome)
        {
            return nome != string.Empty ? true : false;
        }
        public bool ValidaValor(string valor)
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
    }
}
