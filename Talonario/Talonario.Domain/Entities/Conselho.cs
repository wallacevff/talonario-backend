using Talonario.Domain.Shared.Entities;

namespace Talonario.Domain.Entities;

public class Conselho
{
    public short Id { get; set; }
    public required string Nome { get; set; }
    public string? Sigla { get; set; }

    public short? EstadoId { get; set; }
    public Estado? Estado { get; set; }
}