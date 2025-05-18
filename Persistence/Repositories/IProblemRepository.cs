using Persistence.Entities;

namespace Persistence.Repositories;

public interface IProblemRepository
{
    public Task<IList<Problem>> GetProblemsAsync(CancellationToken cancellationToken);

    public Task<Problem> GetProblemByIdAsync(ulong id, CancellationToken cancellationToken);
}