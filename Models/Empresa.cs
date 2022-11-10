namespace TP.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }


        public ICollection<Carro> Carros { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
        public ICollection<Gestor> Gestores { get; set; }
    }
}
