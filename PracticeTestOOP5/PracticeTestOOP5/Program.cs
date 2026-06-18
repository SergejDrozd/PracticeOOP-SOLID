class Programm
{
    static void Main()
    {
        var vehicles = new List<Vehicle>
        {
            new Vehicle("AA", Vehicle.Category.Light, 6.5, 60000),
            new Vehicle("BB", Vehicle.Category.Light, 7.0, 30000),
            new Vehicle("CC", Vehicle.Category.Medium, 12.0, 80000),
            new Vehicle("DD", Vehicle.Category.Medium, 13.5, 90000),
            new Vehicle("EE", Vehicle.Category.Heavy, 20.0, 120000),
            new Vehicle("FF", Vehicle.Category.Heavy, 18.0, 40000)
        };

        var result = VehicleAnalytics.SortVehicle(vehicles);

        Console.WriteLine();

        foreach (var pair in result)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
