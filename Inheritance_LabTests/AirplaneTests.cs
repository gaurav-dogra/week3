using NUnit.Framework;

namespace Week3;

public class AirplaneTests
{
    [Test]
    public void ToStringTest()
    {
        const string expected = "Thank you for flying JetsRUs: Week3.Airplane " +
            "capacity: 200 passengers: 150 speed: 100 position: 500 altitude: 500.";
        Airplane airplane = new Airplane(200) { Speed = 100 };
        airplane.NumPassengers = 150;
        airplane.Move(5);
        airplane.Ascend(500);
        Assert.That(airplane.ToString(), Is.EqualTo(expected));
    }
    
    [Test]
    public void MoveWithInput_Test()
    {
        const string expected = "Moving along 3 times at an altitude of 500 meters.";
        Airplane airplane = new Airplane(200) { Speed = 100 };
        airplane.Ascend(500);
        string actual = airplane.Move(3);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Move_Test()
    {
        const string expected = "Moving along at an altitude of 500 meters.";
        Airplane airplane = new Airplane(200) { Speed = 100 };
        airplane.Ascend(500);
        string actual = airplane.Move();
        Assert.That(actual, Is.EqualTo(expected));
    }

}
