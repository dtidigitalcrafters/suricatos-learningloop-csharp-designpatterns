using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoUsuarios
{
    public class PerfilUsuario : ICloneable
    {
        public IList<Permissao> permissoes { get; set; }

        public PerfilUsuario(IList<Permissao> permissoes)
        {
            this.permissoes = permissoes;
        }

        public PerfilUsuario(PerfilUsuario perfilUsuario)
        {
            this.permissoes = perfilUsuario.permissoes;
        }

        public object Clone() => new PerfilUsuario(this);

        public override string ToString()
        {
            string texto = "";

            foreach(Permissao permissao in permissoes)
            {
                texto += $"{permissao} ";
            }

            return texto;
        }

    }
}
