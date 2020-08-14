namespace visitor.Dtos
{
    public abstract class ProdutoDTO
    {
        public int CodigoProduto { get; set; }
        public string Descricao { get; set; }
        public float PrecoBase { get; set; }

        public ProdutoDTO(int codigoProduto, string descricao, float precoBase)
        {
            CodigoProduto = codigoProduto;
            Descricao = descricao;
            PrecoBase = precoBase;
        }

        public abstract float CalcularPreco();
        public abstract string Exportar(IExportacaoService exportacaoService);
    }
}
