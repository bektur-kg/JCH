using JCH.Domain.Modules.Candidates;
using System.ComponentModel.DataAnnotations;

namespace JCH.Application.Contracts.Candidates;

public record CreateCandidateRequest
{
    [MaxLength(CandidateAttributeConstants.MAX_FIRST_NAME_LENGTH)]
    public required string FirstName { get; set; }

    [MaxLength(CandidateAttributeConstants.MAX_LAST_NAME_LENGTH)]
    public required string LastName { get; set; }

    [Phone]
    public string? PhoneNumber { get; set; }

    [EmailAddress]
    public required string Email { get; set; }

    public DateTime? PreferredCallStartDate { get; set; }

    public DateTime? PreferredCallEndDate { get; set; }

    [Url]
    public string? LinkedInUrl { get; set; }

    [Url]
    public string? GitHubUrl { get; set; }

    [MaxLength(CandidateAttributeConstants.MAX_TEXT_COMMENT_LENGTH)]
    public required string TextComment { get; set; }
}