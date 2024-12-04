using Talonario.Domain.Shared.Entities;
using Talonario.Domain.Shared.Enums;

namespace Talonario.Domain.Entities;

public class Talao : DefaultEntity
{
    public ETalao Id { get; set; }
    public required string Nome { get; set; }
    public required string Descricao { get; set; }

    public IList<OcupacaoTalao>? Ocupacoes { get; set; }
    public IList<TalaoDocumento>? Documentos { get; set; }
}