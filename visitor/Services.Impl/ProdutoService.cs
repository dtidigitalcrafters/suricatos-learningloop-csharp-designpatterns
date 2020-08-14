using System;
using System.Collections.Generic;
using visitor.Dtos;
using visitor.Repositories;

namespace visitor.Service.Impl
{
    public class ProdutoService
    {
        public string exportarProdutosTsv()
        {
            var exportacaoService = new ExportacaoCsvService();
            var produtoRepository = new ProdutoRepository();
            var listaProdutos = produtoRepository.getProdutos();
            string csv = "";

            foreach (var produtoDTO in listaProdutos)
            {
                csv += produtoDTO.Exportar(exportacaoService) + '\n';
            }

            return csv;
        }
    }
}
