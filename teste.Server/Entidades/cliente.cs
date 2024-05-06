using teste.Server .modelos;

namespace teste.Server.Entidades
{
    public partial class cliente
    {
        public cliente(ClienteNovoModelo modelo)
        {
            Nome = modelo.Nome;
            CPF = modelo.CPF;
            DataNascimento = modelo.DataNascimento;
            Endereco = modelo.Endereco;
        }
        public string Nome { get; set; }

        public string CPF { get; set; }

        public DateOnly DataNascimento { get; set; }

        public string Endereco { get; set; }

        public long IdClient { get; set; }
    }
}
