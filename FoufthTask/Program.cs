abstract class Transport
{
    public double Speed;
    public abstract double CalculateTime(double distance);
}
class Truck : Transport
{
    public Truck()
    {
        Speed = 80;
    }
    public override double CalculateTime(double distance)
    {
        return distance / Speed;
    }
}
class CargoPlane : Transport
{
    public CargoPlane()
    {
        Speed = 800;
    }
    public override double CalculateTime(double distance)
    {
        return distance / Speed + 2;
    }
}

class Train : Transport
{
    public Train()
    {
        Speed = 120;
    }
    public override double CalculateTime(double distance)
    {
        return distance / Speed;
    }
}

class Program
{
    static void Main()
    {
        var Truck1 = new Truck();
        var Plane1 = new CargoPlane();
        var Train1 = new Train();
        double distance = 2400;
        double TruckTime, TrainTime, PlaneTime;
        TruckTime = Truck1.CalculateTime(distance);
        PlaneTime = Plane1.CalculateTime(distance);
        TrainTime = Train1.CalculateTime(distance);
        Console.WriteLine(TruckTime);
        Console.WriteLine(PlaneTime);
        Console.WriteLine(TrainTime);
    }
}
