using System.ComponentModel;

namespace Descontrolada.Models
{
    public class ProdutoModel
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public float PrecoVenda { get; set; }
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public TipoProduto TipoProduto { get; set; }
    }
    public enum TipoProduto
    {
        [Description("Orgânico")]
        Organico = 1,
        [Description("Não orgânico")]
        NaoOrganico = 2,
    }
}
