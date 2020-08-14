namespace visitor.Dtos
{
    public class ProdutoNacionalDTO : ProdutoDTO
    {
        
        public ProdutoNacionalDTO(int codigoProduto, string descricao, float precoBase) 
            : base(codigoProduto, descricao, precoBase) 
        {
            CodigoProduto = codigoProduto;
            Descricao = descricao;
            PrecoBase = precoBase;
        }

        public override float CalcularPreco() => PrecoBase;

        public override string Exportar(IExportacaoService exportacaoService) => 
            exportacaoService.ExportarProduto(this);
    }
}
