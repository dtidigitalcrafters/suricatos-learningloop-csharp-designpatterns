using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using visitor.Service.Impl;

namespace visitor.Controllers
{
    [ApiController]
    [Route("produtos/csv")]
    public class ProdutoController : ControllerBase
    {

        private readonly ILogger<ProdutoController> _logger;

        public ProdutoController(ILogger<ProdutoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var produtoService = new ProdutoService();
            return produtoService.exportarProdutosTsv();
        }
    }
}
