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
        var truck = new Truck();
        var plane = new CargoPlane();
        var train = new Train();

        double distance = 2400;

        double truckTime = truck.CalculateTime(distance);
        double planeTime = plane.CalculateTime(distance);
        double trainTime = train.CalculateTime(distance);

        Console.WriteLine(truckTime);
        Console.WriteLine(planeTime);
        Console.WriteLine(trainTime);
    }
}
