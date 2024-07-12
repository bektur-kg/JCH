namespace JCH.Application.Abstractions;

/// <summary>
/// Represents an error with a code and an optional message.
/// </summary>
/// <param name="Code">The code that identifies the error.</param>
/// <param name="Message">The optional message that describes the error.</param>
public sealed record Error(string Code, string? Message = null)
{
    public static readonly Error None = new(string.Empty);
    public static readonly Error InternalServerError = new("Request.InternalServerError", 
        "Internal server error");
}