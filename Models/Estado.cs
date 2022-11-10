namespace TP.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public int Km { get; set; }
        public Boolean Danos { get; set; } // possivel classe? anexar fotografias caso esteja danificado, tipo de variavel fotografia
        public string Observacoes { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
