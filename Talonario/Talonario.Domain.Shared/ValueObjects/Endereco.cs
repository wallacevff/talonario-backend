using Talonario.Domain.Shared.Entities;

namespace Talonario.Domain.Shared.ValueObjects;

public class Endereco
{
    public int EstadoId { get; set; }
    public int MunicipioId { get; set; }
    public string? Bairro { get; set; }
    public string? Logradouro { get; set; }
    public string? Numero { get; set; }
    public string? Complemento { get; set; }

    public Estado? Estado { get; set; }
    public Municipio? Municipio { get; set; }
}