using Persistence.Entities;

namespace BusinessLogic.Services;

public interface ICodeRunnerService
{
    public Task<string> RunCodeAsync(string code, Language language, IEnumerable<TestCase> testCases);
}