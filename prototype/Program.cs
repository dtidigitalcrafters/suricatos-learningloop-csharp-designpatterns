using System;
using System.Collections.Generic;

namespace GestaoUsuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            GeradorUsuario gerador = new GeradorUsuario();

            Usuario admin = gerador.criarPerfilAdmin("Josias");
            Usuario usuario1 = gerador.criarPerfilPadrao("Lucelia");
            Usuario usuario2 = gerador.criarPerfilPadrao("Thiago");
            Usuario visitante = gerador.criarPerfilSomenteLeitura("Marina");

            Usuario[] usuarios = new Usuario[] { admin, usuario1, usuario2, visitante};
            ImprimirDadosUsuarios(usuarios);
        }

        static void ImprimirDadosUsuarios(IEnumerable<Usuario> usuarios)
        {
            foreach(Usuario usuario in usuarios)
            {
                Console.WriteLine(usuario.ToString());
            }
        }
    }
}
