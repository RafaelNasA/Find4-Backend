namespace MinhaAgenciaApi.Models
{
    public class Destino
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Origem { get; set; } = string.Empty;
        public string DataIda { get; set; } = string.Empty;
        public string DataVolta { get; set; } = string.Empty;
        public short QtdQuartos { get; set; }

        // Relacionamento com Usuario
        public Usuario Usuario { get; set; }
    }
}
