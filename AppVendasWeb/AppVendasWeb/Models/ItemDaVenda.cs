namespace AppVendasWeb.Models
{
    public class ItemDaVenda
    {
        public Guid ItemDaVendaId { get; set; }
        public Guid ProdutoId { get; set; }

        public Produto? Produto { get; set; }

        public Guid VendaID { get; set; }

        public Venda? Venda { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}
