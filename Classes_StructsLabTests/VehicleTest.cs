using NUnit.Framework;
using Week3;

namespace Classes_StructsLabTests;

public class Tests
{
    [Test]
    public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
    {
        Vehicle v = new Vehicle();
        var result = v.Move(2);
        Assert.AreEqual(20, v.Position);
        Assert.AreEqual("Moving along 2 times", result);
    }

    [Test]
    public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
    {
        Vehicle v = new Vehicle(5, 40);
        var result = v.Move();
        Assert.AreEqual(40, v.Position);
        Assert.AreEqual("Moving along", result);
    }
    
    [Test]
    public void WhenAVehicleMovedTwiceItsPositionIs20()
    {
        Vehicle v = new Vehicle();
        v.Move();
        v.Move();
        Assert.AreEqual(20, v.Position);
    }

    [Test]
    public void ShouldThrow_PassengerExceedCapacityException()
    {
        const int PASSENGER_CAPACITY = 5;
        var vehicle = new Vehicle(PASSENGER_CAPACITY);

        Assert.That(() => vehicle.NumPassengers = 6, Throws.TypeOf<PassengersExceedCapacityException>()
        .With.Message
        .Contain("Passenger number exceed the capacity"));
    }

    [Test]
    public void ShouldThrow_IncorrectPassengerNumberException()
    {
        const int PASSENGERS_NUMBER = -1;
        var vehicle = new Vehicle();

        Assert.That(() => vehicle.NumPassengers = PASSENGERS_NUMBER,
            Throws.TypeOf<IncorrectPassengerNumberException>()
        .With.Message
        .Contain("Passenger number can not be negative"));
    }

    [Test]
    public void ToString_Test()
    {
        Vehicle vehicle = new Vehicle(200) { Speed = 100 };
        vehicle.Move(3);
        vehicle.NumPassengers = 150;
        string expected = "Week3.Vehicle capacity: 200 passengers: 150 speed: 100 position: 300";
        Assert.That(vehicle.ToString(), Is.EqualTo(expected));
    }
}