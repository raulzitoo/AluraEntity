using System;
using System.Collections.Generic;

namespace entityApp
{
    public partial class Produtos
    {
        public uint Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double? Preco { get; set; }
    }
}
