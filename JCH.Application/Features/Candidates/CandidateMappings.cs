using AutoMapper;
using JCH.Application.Contracts.Candidates;
using JCH.Domain.Modules.Candidates;

namespace JCH.Application.Features.Candidates;

public class CandidateMappings : Profile
{
    public CandidateMappings()
    {
        CreateMap<CreateCandidateRequest, Candidate>()
           .ForAllMembers(opts => opts.Condition((_, _, srcMember) => srcMember != null));
    }
}

