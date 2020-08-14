using visitor.Dtos;

namespace visitor
{
    public interface IExportacaoService
    {
        public string ExportarProduto(ProdutoNacionalDTO produtoNacionalDTO);
        public string ExportarProduto(ProdutoImportadoDTO produtoImportadoDTO);
    }
}
