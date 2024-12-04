using Talonario.Domain.Shared.Enums;

namespace Talonario.Domain.Entities;

public class TipoPessoa
{
    public ETipoPessoa Id { get; set; }
    public required string Nome { get; set; }
}