using Talonario.Domain.Shared.Entities;
using Talonario.Domain.Shared.Enums;

namespace Talonario.Domain.Entities;

public sealed class UsuarioEmpresa : DefaultEntity
{
    public Guid UsuarioId { get; set; }
    public Guid EmpresaId { get; set; }
    public ESituacao SituacaoId { get; set; }
    public ETipoPessoa TipoVinculoId { get; set; }
    public UsuarioExterno? Usuario { get; set; }
    public Empresa? Empresa { get; set; }
    public Situacao? Situacao { get; set; }
    public TipoPessoa? TipoVinculo { get; set; }
}