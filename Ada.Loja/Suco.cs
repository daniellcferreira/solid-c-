using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ada.Loja
{
    public class Suco : ItemComTaxa
    {
        public Suco(string descricao, decimal valor) : base("Suco", descricao, valor)
        {
        }

        public override decimal ObterTaxa(DateTime data)
        {
            return 0.1M;
        }
    }
}