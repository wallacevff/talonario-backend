using Talonario.Domain.Shared.Enums;

namespace Talonario.Domain.Entities;

public class TalaoDocumento
{
    public ETalao TalaoId { get; set; }
    public ETipoPessoa TipoPessoaId { get; set; }
    public short DocumentoId { get; set; }
    public bool Obrigatorio { get; set; } = true;
    public Talao? Talao { get; set; }
    public TipoPessoa? TipoPessoa { get; set; }
    public Documento? Documento { get; set; }
   
}