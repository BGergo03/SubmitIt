namespace Persistence.Entities;

public class Problem
{
    public ulong Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Difficulty Difficulty { get; set; }
    public IEnumerable<TestCase> TestCases { get; set; } = [];
    public IEnumerable<Submission> Submissions { get; set; } = [];
}

public enum Difficulty
{
    Easy,
    Medium,
    Hard
}