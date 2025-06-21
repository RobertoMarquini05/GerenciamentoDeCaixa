using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.Models
{
    public class ItemCadastrado
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public bool Disponivel { get; set; }
        public DateTime CreatedAt { get; set; }

        public ItemCadastrado(string nome, double valor, int quantidade) 
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
            Disponivel = quantidade > 0 ? true : false;
            CreatedAt = DateTime.Now.Date;
        }
    }
}
