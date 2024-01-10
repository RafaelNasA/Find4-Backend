namespace MinhaAgenciaApi.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Assunto { get; set; } = string.Empty;
        public string Conteudo { get; set; } = string.Empty;
    }
}
