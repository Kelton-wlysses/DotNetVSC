namespace DotNetVSC.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        //relação 1 p muitos
        public List<Lanche> Lanches { get; set; }
    }
}