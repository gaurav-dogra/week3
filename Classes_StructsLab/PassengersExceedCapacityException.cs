using System;

namespace Week3;

public class PassengersExceedCapacityException : Exception
{
    public PassengersExceedCapacityException(string message) : base(message) { }
    public PassengersExceedCapacityException() { }
    public PassengersExceedCapacityException(string message, Exception inner) : base(message, inner) { }

}
