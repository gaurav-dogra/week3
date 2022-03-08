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

<<<<<<< HEAD
    public override string ToString()
    { 

        return $"Thank you for flying {_airline}: {base.ToString()} altitude: {Altitude}.";
    }

    public override string Move(int times)
    {
        return base.Move(times) + $" at an altitude of {Altitude} meters.";
    }

    public override string Move()
    {
        return base.Move() + $" at an altitude of {Altitude} meters.";
=======
    public string ToString()
    { 

        return $"Thank you for flying JetsRUs: {base.ToString()} altitude: 500.";
>>>>>>> 9c368afadf596c693c292702222d31bb082eeee5
    }

    public override string Move(int times)
    {
        return base.Move(3) + $" at an altitude of {Altitude} meters.";
    }
}
