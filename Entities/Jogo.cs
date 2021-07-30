using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_jogos.Entities
{
    public class Jogo
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public double Preco { get; set; }

        public static implicit operator Jogo(Jogo v)
        {
            throw new NotImplementedException();
        }
    }
}
