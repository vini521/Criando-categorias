namespace ExemploEF.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }
        public string Nome { get; set; }
        //Relacionando as entidades Categoria e Produto (1 Categoria - N Produtos)
        //Cada Categoria possui varios produtos
        public IEnumerable<Produto>? Produtos { get; set; }
    }
}
