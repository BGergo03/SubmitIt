using Persistence.Entities;

namespace BusinessLogic.Services;

public class CodeRunnerService : ICodeRunnerService
{
    public Task<string> RunCodeAsync(string code, Language language, IEnumerable<TestCase> testCases)
    {
        throw new NotImplementedException();
    }
}