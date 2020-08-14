using visitor.Dtos;

namespace visitor
{
    public class ExportacaoCsvService : IExportacaoService
    {
        public string ExportarProduto(ProdutoNacionalDTO produtoDTO) =>
            $"{produtoDTO.CodigoProduto}\t{produtoDTO.Descricao}\t{produtoDTO.CalcularPreco()}";

        public string ExportarProduto(ProdutoImportadoDTO produtoImportadoDTO) =>
            $"{produtoImportadoDTO.CodigoProduto}\t{produtoImportadoDTO.Descricao}\t" +
            $"{produtoImportadoDTO.PaisOrigem}\t{produtoImportadoDTO.CalcularPreco()}";
    }
}
