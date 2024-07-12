using JCH.Application.Contracts.Candidates;
using JCH.Application.Features.Candidates.CreateOrUpdate;

namespace JCH.API.Controllers;

[ApiController]
[Route("candidates")]
public class CandidatesController : ControllerBase
{
    private readonly ISender _sender;

    public CandidatesController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost]
    public async Task<ActionResult> CreateCandidate(CreateCandidateRequest dto)
    {
        var command = new CreateOrUpdateCommand(dto);

        var response = await _sender.Send(command);

        return response.IsSuccess ? Ok(response) : BadRequest(response.Error);
    }
}
