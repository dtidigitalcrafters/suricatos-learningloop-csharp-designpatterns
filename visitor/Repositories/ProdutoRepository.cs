using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using visitor.Dtos;

namespace visitor.Repositories
{
    public class ProdutoRepository
    {
        public IEnumerable<ProdutoDTO> getProdutos()
        {
            var listaProdutos = new ProdutoDTO[] {
                new ProdutoNacionalDTO(1, "uva", 2.59f),
                new ProdutoImportadoDTO(2, "toranja", 3, 3.5f, "Estados Unidos"),
                new ProdutoNacionalDTO(3, "maçã", 3.25f),
                new ProdutoImportadoDTO(4, "vinho", 5, 49.99f, "Portugal"),
            };
            return listaProdutos;
        }
    }
}
