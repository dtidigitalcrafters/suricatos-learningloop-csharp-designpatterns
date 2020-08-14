namespace GestaoUsuarios
{
    public class Usuario
    {
        public string Nome { get; set; }
        public PerfilUsuario perfilUsuario { get; set; }

        public Usuario(string nome, PerfilUsuario perfilUsuario)
        {
            this.Nome = nome;
            this.perfilUsuario = perfilUsuario;
        }

        public override string ToString()
        { 
            return $"Nome: {Nome}\nPermissões: {perfilUsuario.ToString()}";
        }
    }
}
