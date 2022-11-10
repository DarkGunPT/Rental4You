namespace TP.Models
{
    public class Cliente : User
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Carro> Carros { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
    }
}
