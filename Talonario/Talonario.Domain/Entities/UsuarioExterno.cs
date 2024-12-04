namespace Talonario.Domain.Entities;

public sealed class UsuarioExterno : Usuario
{
    public required string Crm { get; set; }
    public short ConselhoId { get; set; }
    public Conselho? Conselho { get; set; }
    public IList<UsuarioEmpresa>? Empresas { get; set; }
}