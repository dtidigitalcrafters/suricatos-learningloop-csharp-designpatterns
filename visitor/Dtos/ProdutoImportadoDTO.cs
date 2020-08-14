namespace visitor.Dtos
{
    public class ProdutoImportadoDTO : ProdutoDTO
    {
        public float TaxaImportacao { get; set; }
        public string PaisOrigem { get; set; }

        public ProdutoImportadoDTO(int codigoProduto, string descricao, float precoBase, float taxaImportacao, string paisOrigem)
            : base(codigoProduto, descricao, precoBase)
        {
            TaxaImportacao = taxaImportacao;
            PaisOrigem = paisOrigem;
        }

        public override float CalcularPreco() => PrecoBase + TaxaImportacao;

        public override string Exportar(IExportacaoService exportacaoService) =>
            exportacaoService.ExportarProduto(this);
    }
}
