namespace ExemploEF.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        //Relacionando as entidades Categoria e Produto (1 Categoria - N Produtos)
        //Cada produto pode pertencer a uma categoria
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
