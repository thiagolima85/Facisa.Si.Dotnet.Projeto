using System;

namespace Facisa.Si.Dotnet.Projeto.Dados.Entidades
{
    public class Atividade
    {
        public int AtividadeId { get; set; }

        public string Nome { get; set; }

        public string Local { get; set; }

        public DateTime DataInicio { get; set; }

        public string TipoDeAtividade { get; set; }

        public string Descricao { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public Atividade()
        {
           
        }
    }
}
