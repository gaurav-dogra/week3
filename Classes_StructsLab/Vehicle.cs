namespace Week3;

public class Vehicle
{
    private int _capacity; // when we can have Property; is there a use case for prived fields
    //private int _numPassengers; // having property and field both in the given diagram?
    public int Position { get; private set; }
    public int Speed { get; init; }
    
    public int NumPassengers { get; private set; }

    const int DEFAULT_SPEED = 10;
    public Vehicle() 
    {
        Speed = DEFAULT_SPEED;
    }

    public Vehicle(int capacity, int speed = DEFAULT_SPEED)
    {
        _capacity = capacity;
        Speed = speed;
    }

    private void setPosition(int position)
    {
        Position = position;
    }

    public void SetNumPassengers (int numPassengers)
    {
        if (numPassengers < 0) 
            throw new IncorrectPassengerNumberException("Passenger number can not be negative");
        if (numPassengers > _capacity)
            throw new PassengersExceedCapacityException("Passenger number exceed the capacity");
        NumPassengers = numPassengers;
    }

    public string Move()
    {
        setPosition(Position + Speed);
        return "Moving along";
    }

    public string Move(int times)
    {
        setPosition(Position + times * Speed);
        return $"Moving along {times} times";
    }
}
