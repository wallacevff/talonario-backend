namespace Talonario.Domain.Shared.Entities;

public abstract class Usuario : DefaultEntity
{
    public int Id { get; set; }
    public required string Cpf { get; set; }
    public required string Nome { get; set; }
    public string? NomeSocial { get; set; }
    public DateOnly? DtNascimento { get; set; }
    public string? Email { get; set; }
    public string? HashSenha { get; set; }
    public bool TrocarSenha { get; set; } = true;
}