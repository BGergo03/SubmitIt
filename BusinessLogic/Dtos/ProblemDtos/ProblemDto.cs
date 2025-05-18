using BusinessLogic.Dtos.TestCaseDtos;

namespace BusinessLogic.Dtos.ProblemDtos;

public class ProblemDto
{
    public ulong Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public IEnumerable<TestCaseDto> TestCases { get; set; } = [];
}