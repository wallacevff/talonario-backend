using Talonario.Domain.Shared.Entities;

namespace Talonario.Domain.Entities;

public class Telefone : DefaultEntity
{
    public Guid Id { get; set; }
    public required string Ddd { get; set; }
    public required string Numero { get; set; }
}