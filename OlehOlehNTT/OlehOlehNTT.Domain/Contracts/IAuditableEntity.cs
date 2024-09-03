namespace OlehOlehNTT.Domain.Contracts;

public interface IAuditableEntity
{
    public DateTime AddedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
}
