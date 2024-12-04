namespace Talonario.Domain.Entities;

public sealed class UsuarioInterno : Usuario
{
    public required string Matricula { get; set; }
}