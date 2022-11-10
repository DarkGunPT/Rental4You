namespace TP.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Carro> Carros { get; set; }
    }
}
