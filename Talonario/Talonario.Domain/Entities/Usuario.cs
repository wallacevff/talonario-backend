using Talonario.Domain.Shared.Entities;
using Talonario.Domain.Shared.Enums;

namespace Talonario.Domain.Entities;

public abstract class Usuario : DefaultEntity
{
    public Guid Id { get; set; }
    public required string Cpf { get; set; }
    public required string Nome { get; set; }
    public string? NomeSocial { get; set; }
    public DateOnly? DtNascimento { get; set; }
    public string? Email { get; set; }
    public string? HashSenha { get; set; }
    public bool TrocarSenha { get; set; } = true;
    public ESituacao SituacaoId { get; set; }
    public Situacao? Situacao { get; set; }

    public IList<UsuarioTelefone>? Telefones { get; set; }

    public IList<UsuarioEmpresa>? Empresas { get; set; }
}