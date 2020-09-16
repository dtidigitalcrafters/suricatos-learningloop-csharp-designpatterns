using System;

namespace proxy
{
    public class PedidoService : IPedido
    {
        public byte[] baixarNotaFiscal(int numeroNotaFiscal)
        {
            var rand = new Random();
            var notaFiscal = new byte[10];
            rand.NextBytes(notaFiscal);
            return notaFiscal;
        }
    }
}
