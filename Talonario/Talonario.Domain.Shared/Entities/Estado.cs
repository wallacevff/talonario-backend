namespace Talonario.Domain.Shared.Entities;

public class Estado : DefaultEntity
{
    public short? Id { get; set; }
    public required string Sigla { get; set; }
    public required string Nome { get; set; }
    public IList<Municipio>? Municipios { get; set; }
}