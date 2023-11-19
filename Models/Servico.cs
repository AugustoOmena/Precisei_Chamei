namespace AspNetCoreWebApp.Models
{
    public class Servico
    {
        public int IdServico { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public int Estoque { get; set; }
    }
}
