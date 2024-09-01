namespace OlehOlehNTT.Domain.Contracts;

public interface IAuditableEntity
{
    public DateTime AddetAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
}
