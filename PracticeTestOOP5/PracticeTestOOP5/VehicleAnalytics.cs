class VehicleAnalytics
{
    public static Dictionary<string, double> SortVehicle(List<Vehicle> vehicles)
    {
        var result = vehicles
            .Where(v => v.Mileage > 50000)
            .GroupBy(v => v.CategoryVehicle)
            .OrderByDescending(g => g.Key)
            .ToDictionary(
                g => g.Key.ToString(),
                g => g.Average(v => v.FuelConsumption)
            );

        return result;
    }
}


