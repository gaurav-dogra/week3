using Week3;
namespace Week3;

public class Airplane : Vehicle
{
    private string _airline;

    public int Altitude { get; private set; }

    public Airplane(int capacity) : base(capacity) { }

    public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
    {
        _airline = airline;
    }

    public void Ascend(int distance)
    {
        Altitude += distance;
    }
    
    public void Descend(int distance)
    {
        Altitude -= distance;
    }

    public string ToString()
    { 

        return $"Thank you for flying JetsRUs: {base.ToString()} altitude: 500.";
    }

    public override string Move(int times)
    {
        return base.Move(3) + $" at an altitude of {Altitude} meters.";
    }
}
