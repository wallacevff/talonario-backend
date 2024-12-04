using Talonario.Domain.Shared.Entities;
using Talonario.Domain.Shared.Enums;

namespace Talonario.Domain.Entities;

public class Empresa : DefaultEntity
{
    public Guid Id { get; set; }
    public required string Cnpj { get; set; }
    public string? NomeFantasia { get; set; }
    public required string RazaoSocial { get; set; }
    public ESituacao SituacaoId { get; set; }
    public Situacao? Situacao { get; set; }

    public IList<UsuarioEmpresa>? Usuarios { get; set; }
}