namespace JCH.Application.Abstractions;

public sealed record Error(string Code, string? Message = null)
{
    public static readonly Error None = new(string.Empty);
    public static readonly Error InternalServerError = new("Request.InternalServerError", "Internal server error");
}

