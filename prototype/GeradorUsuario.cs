using System;

namespace GestaoUsuarios
{
    class GeradorUsuario
    {
        PerfilUsuario perfilPadrao;
        PerfilUsuario perfilAdmin;
        PerfilUsuario perfilSomenteLeitura;

        public GeradorUsuario()
        {
            Permissao[] permissoesPadrao = new Permissao[] { Permissao.ler, Permissao.escrever };
            Permissao[] permissoesAdmin = new Permissao[] {
                Permissao.ler, Permissao.escrever, Permissao.editar, Permissao.apagar
            };
            Permissao[] permissoesSomenteLeitura = new Permissao[] { Permissao.ler };

            perfilPadrao = new PerfilUsuario(permissoesPadrao);
            perfilAdmin = new PerfilUsuario(permissoesAdmin);
            perfilSomenteLeitura = new PerfilUsuario(permissoesSomenteLeitura);
        }

        public Usuario criarPerfilPadrao(String nome)
        {
            PerfilUsuario perfil = (PerfilUsuario) perfilPadrao.Clone();
            return new Usuario(nome, perfil);
        }

        public Usuario criarPerfilAdmin(String nome)
        {
            PerfilUsuario perfil = (PerfilUsuario) perfilAdmin.Clone();
            return new Usuario(nome, perfil);
        }

        public Usuario criarPerfilSomenteLeitura(String nome)
        {
            PerfilUsuario perfil = (PerfilUsuario) perfilSomenteLeitura.Clone();
            return new Usuario(nome, perfil);
        }
    }
}
