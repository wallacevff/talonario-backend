using Talonario.Domain.Shared.Enums;

namespace Talonario.Domain.Entities;

public class Funcao
{
    public EFuncao Id { get; set; }
    public required string Nome { get; set; }
}