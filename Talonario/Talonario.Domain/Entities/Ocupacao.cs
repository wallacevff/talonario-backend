using Talonario.Domain.Shared.Entities;

namespace Talonario.Domain.Entities;

public class Ocupacao : DefaultEntity
{
    public short Id { get; set; }
    public required string Nome { get; set; }
    public string? Descricao { get; set; }

    public IList<OcupacaoTalao>? OcupacoesTalao { get; set; }
}