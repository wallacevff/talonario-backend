namespace Talonario.Domain.Entities;

public class UsuarioTelefone
{
    public Guid TelefoneId { get; set; }
    public Guid UsuarioId { get; set; }

    public Usuario? Usuario { get; set; }
    public Telefone? Telefone { get; set; }
}