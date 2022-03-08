namespace Week3;

public class Vehicle
{
    private int _capacity;
    private int _numPassengers;
    private const int DEFAULT_SPEED = 10;

    // when we can have Property; is there a use case for prived fields

    public int Position { get; private set; }
    public int Speed { get; init; }
    public int NumPassengers
    {
        get
        {
            return _numPassengers;
        }
        set
        {
            if (value < 0)
                throw new IncorrectPassengerNumberException("Passenger number can not be negative");
            if (value > _capacity)
                throw new PassengersExceedCapacityException("Passenger number exceed the capacity");
            _numPassengers = value;
        }
    }

    public Vehicle() 
    {
        Speed = DEFAULT_SPEED;
    }

    public Vehicle(int capacity, int speed = DEFAULT_SPEED)
    {
        _capacity = capacity;
        Speed = speed;
    }

    private void SetPosition(int position)
    {
        Position = position;
    }

    public string Move()
    {
        SetPosition(Position + Speed);
        return "Moving along";
    }

    public string Move(int times)
    {
        SetPosition(Position + times * Speed);
        return $"Moving along {times} times";
    }
}
