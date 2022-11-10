namespace TP.Models
{
    public class Reserva
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public Boolean Estado { get; set; } // Ativo / Inativo ?
        
        public DateTime DataLevantamento { get; set; }
        public DateTime DataEntrega { get; set; }
        public int CarroId { get; set; }
        public Carro Carro { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        // Ligação à empresa? Ou empresa já se encontra ligada através do Carro
        public Estado EstadoLevantamento { get; set; }
        public Estado EstadoEntrega { get; set; }
    }
}
