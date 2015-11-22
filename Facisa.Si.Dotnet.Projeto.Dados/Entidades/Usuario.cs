using System.Collections.Generic;


namespace Facisa.Si.Dotnet.Projeto.Dados.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public List<Atividade> Atividades { get; set; }

        public Usuario()
        {
            Atividades = new List<Atividade>();
        }

    }
}
