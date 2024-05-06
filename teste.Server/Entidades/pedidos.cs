namespace teste.Server.Entidades
{
    public class pedidos
    {
        public long IdPedido { get; set; }

        public long IdClient { get; set; }

        public bool Concluido { get; set; }

        public formaspgt Pagamento { get; set; }

        public Dictionary<long, long>? Produtos { get; set; }


    }
}
