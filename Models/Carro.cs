namespace TP.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Localizacao { get; set; }
        //public string Tipo { get; set; } // criar classe?
        public float Preco { get; set; }
        public Boolean Disponivel { get; set; }
        public int Lugares { get; set; }
        public string Mudancas { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        
        // Estado do veiculo
        //

        public ICollection<Reserva> Reservas { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }

    }
}
