using Persistence.Entities;

namespace BusinessLogic.Dtos.SubmissionDtos;

public class CreateSubmission
{
    public string Code { get; set; }
    
    public Language Language { get; set; }
    
    public ulong ProblemId { get; set; }
}