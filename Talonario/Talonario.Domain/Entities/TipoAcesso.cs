using Talonario.Domain.Shared.Enums;

namespace Talonario.Domain.Entities;

public class TipoAcesso
{
    public ETipoAcesso Id { get; set; }
    public required string Nome { get; set; }
}