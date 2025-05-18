using BusinessLogic.Dtos.SubmissionDtos;

namespace BusinessLogic.Services;

public interface ISubmissionService
{
    public Task Submit(CreateSubmission createSubmission, CancellationToken cancellationToken);
}