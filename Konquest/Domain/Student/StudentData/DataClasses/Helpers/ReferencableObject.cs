namespace Konquest.Domain.Student.IndepDataModels.Helpers;

public abstract class ReferencableObject()
{
    public Guid Id = Guid.NewGuid();
    public DateTime CreatedAt = DateTime.UtcNow;
}