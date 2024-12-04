using Talonario.Domain.Shared.Enums;

namespace Talonario.Domain.Entities;

public class OcupacaoTalao
{
    public short OcupacaoId { get; set; }
    public ETalao TalaoId { get; set; }
    public Ocupacao? Ocupacao { get; set; }
    public Talao? Talao { get; set; }
}