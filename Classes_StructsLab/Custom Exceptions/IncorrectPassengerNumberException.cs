
namespace Week3;

public class IncorrectPassengerNumberException : Exception
{
    public IncorrectPassengerNumberException()
    {
    }

    public IncorrectPassengerNumberException(string? message) : base(message)
    {
    }

    public IncorrectPassengerNumberException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

}
