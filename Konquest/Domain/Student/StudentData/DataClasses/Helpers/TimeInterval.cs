namespace Konquest.Domain.Student.IndepDataModels.Helpers;

public record TimeInterval(DateTime Start, DateTime End)
{
    public TimeSpan Duration => End - Start;

    public bool Contains(DateTime time) => time >= Start && time <= End;

    public bool IntersectsWith(TimeInterval other)
    {
        return Start < other.End && other.Start < End;
    }
}