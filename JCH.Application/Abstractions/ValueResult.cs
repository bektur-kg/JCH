namespace JCH.Application.Abstractions;

/// <summary>
/// Represents the result of an operation that returns a value, indicating success or failure.
/// </summary>
/// <typeparam name="TValue">The type of the value.</typeparam>
public class ValueResult<TValue>
{
    private ValueResult(bool isSuccess, Error error, TValue? value = default)
    {
        if
        (
            (isSuccess && (error != Error.None || value is null)) ||
            (!isSuccess && (error == Error.None || value is not null))
        )
        {
            throw new ArgumentException("Invalid error", nameof(error));
        }

        Value = value;
        IsSuccess = isSuccess;
        Error = error;
    }

    public bool HasValue => Value != null;
    public TValue? Value { get; private set; }
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public Error Error { get; }

    public static ValueResult<TValue> Success(TValue value) => new(true, Error.None, value);
    public static ValueResult<TValue> Failure(Error error) => new(false, error);
}