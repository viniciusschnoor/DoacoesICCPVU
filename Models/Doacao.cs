namespace DoacoesICCPVU.Models
{
    public class Doacao
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateOnly? EmitidoEm { get; set; }
        public string NumeroOficio { get; set; }
        public string Motivo { get; set; }
        public string Doador { get; set; }
        public string Donatario { get; set; }
        public string Itens { get; set; }
    }
}
