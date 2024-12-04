using Talonario.Domain.Shared.Enums;

namespace Talonario.Domain.Entities;

public class Documento
{
    public short Id { get; set; }
    public required string Nome { get; set; }
    public string? Descricao { get; set; }

    public IList<TalaoDocumento>? Taloes { get; set; }
}