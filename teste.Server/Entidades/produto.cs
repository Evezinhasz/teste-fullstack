using Microsoft.AspNetCore.Routing.Constraints;

namespace teste.Server.Entidades
{
    public class produto
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public double Valor { get; set; }

        public int Quantidade { get; set; }

        public long IdProduto { get; set; }

    }
}
