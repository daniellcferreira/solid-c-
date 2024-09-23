using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ada.Loja
{
    public class Item
    {
        public Item(string categoria, string descricao, decimal valor)
        {
            Categoria = categoria;
            Descricao = descricao;
            Valor = valor;
        }

        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }    
    }
}