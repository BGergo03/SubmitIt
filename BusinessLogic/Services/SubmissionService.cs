using BusinessLogic.Dtos.SubmissionDtos;
using Persistence.Entities;
using Persistence.Repositories;

namespace BusinessLogic.Services;

public class SubmissionService : ISubmissionService
{
    private readonly ISubmissionRepository _submissionRepository;
    private readonly IProblemRepository _problemRepository;
    private readonly ICodeRunnerService _codeRunnerService;

    public SubmissionService(ISubmissionRepository submissionRepository, IProblemRepository problemRepository)
    {
        _submissionRepository = submissionRepository;
        _problemRepository = problemRepository;
    }
    
    public async Task Submit(CreateSubmission createSubmission, CancellationToken cancellationToken)
    {
        Problem problem = await _problemRepository.GetProblemByIdAsync(createSubmission.ProblemId, cancellationToken);

        string result = await _codeRunnerService.RunCodeAsync(createSubmission.Code, createSubmission.Language, problem.TestCases);
        
        
    }
}