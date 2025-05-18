using Persistence.Entities;

namespace Persistence.Repositories;

public interface ISubmissionRepository
{
    public Task<IList<Submission>> GetSubmissionsAsync(CancellationToken cancellationToken);

    public Task<Submission> GetSubmissionByIdAsync(ulong id, CancellationToken cancellationToken);

    public Task<Submission> AddSubmissionAsync(Submission submission, CancellationToken cancellationToken);
}