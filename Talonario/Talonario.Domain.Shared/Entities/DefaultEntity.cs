namespace Talonario.Domain.Shared.Entities;

public abstract class DefaultEntity
{
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}