using System;

namespace proxy
{
    public class PedidoProxy : IPedido
    {
        int codigoUsuario;

        public PedidoProxy(int codigoUsuario) => this.codigoUsuario = codigoUsuario;

        private void auditarDownload(int numeroNotaFiscal)
        {
            Console.WriteLine($"Auditoria: nota fiscal {numeroNotaFiscal} baixada pelo usuário {codigoUsuario} - {DateTime.Now}");
        }

        private void adicionarNaCache(int numeroNotaFiscal, byte[] notaFiscal)
        {
            string notaFiscalConvertida = System.Text.Encoding.Default.GetString(notaFiscal);
            Console.WriteLine($"Nota fiscal {numeroNotaFiscal} salva em cache - ${notaFiscalConvertida}");
        }

        public byte[] baixarNotaFiscal(int numeroNotaFiscal)
        {
            try
            {
                var pedidoService = new PedidoService();
                var notaFiscal = pedidoService.baixarNotaFiscal(numeroNotaFiscal);
                auditarDownload(numeroNotaFiscal);
                adicionarNaCache(numeroNotaFiscal, notaFiscal);
                return notaFiscal;
            } catch(Exception e)
            {
                Console.WriteLine($"Erro ao baixar nota fiscal {numeroNotaFiscal}");
                throw e;
            }
        }
    }
}
