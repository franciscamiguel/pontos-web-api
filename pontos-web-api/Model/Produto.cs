using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontosWebApi.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Pontos { get; set; }
        public string CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
