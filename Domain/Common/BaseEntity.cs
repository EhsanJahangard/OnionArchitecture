namespace Domain.Common;

public abstract class BaseEntity<TKey>
{
    public TKey Id { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime EditeDate { get; set; }
    public bool IsDeleted { get; set; } = false;
}

