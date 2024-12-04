namespace Talonario.Domain.Shared.Entities;

public class Municipio
{
    public short? Id { get; set; }
    public required string Name { get; set; }
    public int EstadoId { get; set; }
    public Estado? Estado { get; set; }
}