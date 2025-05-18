namespace Persistence.Entities;

public class Submission
{
    public ulong Id { get; set; }
    public string Code { get; set; }
    public string Result { get; set; }
    public Language Language { get; set; }
    public ulong ProblemId { get; set; }
    public Problem Problem { get; set; }
}

public enum Language
{
    Csharp,
    Java,
    Python
}