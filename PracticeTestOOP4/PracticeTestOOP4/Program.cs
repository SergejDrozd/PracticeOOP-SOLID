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
