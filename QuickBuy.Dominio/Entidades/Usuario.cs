using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        /// <summary>
        /// Um usuario pode ter nenhum ou vários pédidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

    }
}
