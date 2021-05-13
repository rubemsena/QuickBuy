using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Informe o nome do produto!");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Informe a descricao do produto!");

            if (Preco == 0)
                AdicionarCritica("Valor do produto não pode ser 0!");
        }
    }
}
