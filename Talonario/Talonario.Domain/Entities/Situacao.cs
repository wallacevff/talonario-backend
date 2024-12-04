using Talonario.Domain.Shared.Entities;
using Talonario.Domain.Shared.Enums;

namespace Talonario.Domain.Entities;

public class Situacao
{
    public ESituacao Id { get; set; }
    public required string Nome { get; set; }
}