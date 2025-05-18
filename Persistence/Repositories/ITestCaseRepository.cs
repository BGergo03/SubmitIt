using Persistence.Entities;

namespace Persistence.Repositories;

public interface ITestCaseRepository
{
    public Task<IList<TestCase>> GetTestCasesAsync(CancellationToken cancellationToken);
}