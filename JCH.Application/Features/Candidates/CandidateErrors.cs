namespace JCH.Application.Features.Candidates;

public abstract class CandidateErrors
{
    public static readonly Error NotProvidedBothDates = new("Candidate.NotProvidedBothDates", 
        "Provide both properties: preferredCallStartDate and preferredCallEndDate. Or leave both properties empty");
    public static readonly Error IncorrectTimeInterval = new("Candidate.IncorrectTimeInterval", 
        "Incorrect date interval");
}

