using Talonario.Domain.Shared.Enums;

namespace Talonario.Domain.Entities;

public class Grupo
{
    public EGrupo Id { get; set; }
    public required string Nome { get; set; }
}