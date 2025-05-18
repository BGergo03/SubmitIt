namespace Persistence.Entities;

public class TestCase
{
    public ulong Id { get; set; }
    public string InputData { get; set; }
    public string ExpectedOutput { get; set; }
    public ulong ProblemId { get; set; }
    public Problem Problem { get; set; }
}