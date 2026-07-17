using RideConnect.Domain.Errors;

namespace RideConnect.Domain.Common;

public class Result
{
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public Error Error { get; }
    
    protected Result(bool isSuccess, Error error)
    {
        if (isSuccess && error != Error.None ||
            !isSuccess && error == Error.None)
        {
            throw new ArgumentException("Invalid result");
        }
        IsSuccess = isSuccess;
        Error = error;
    }

    public static Result Success() => new(true, Errors.Error.None);
    public static Result Failure(Error error) => new(false, error);
}

public class Result<T>: Result
{
    public T? Value { get; }

    private Result(T value) : base(true, Errors.Error.None) => Value = value;

    private Result(Error error) : base(false, error) {}

    public static Result<T> Success(T value) => new(value);
    
    public new static Result<T> Failure(Error error) => new(error);
}
