using System;

namespace proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var codigoUsuario = 1111;
            var numeroNotaFiscal = 2222;
            var pedidoProxy = new PedidoProxy(codigoUsuario);

            try
            {
                var notaFiscal = pedidoProxy.baixarNotaFiscal(numeroNotaFiscal);
                var notaFiscalConvertida = System.Text.Encoding.UTF8.GetString(notaFiscal);
                Console.WriteLine($"Nota fiscal {numeroNotaFiscal} baixada - {notaFiscalConvertida}");
            } catch (Exception e)
            {
                Console.WriteLine("Erro ao baixar nota fiscal - " + e.Message);
            }
        }
    }
}
