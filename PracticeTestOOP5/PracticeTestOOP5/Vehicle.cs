class Vehicle
{
    public string LicensePlate { get; set; }

    public enum Category
    {
        Light,
        Medium,
        Heavy
    }

    public Category CategoryVehicle { get; set; }
    public double FuelConsumption { get; set; }
    public double Mileage { get; set; }
    public bool IsMaintenanceRequired { get; set; }

    public Vehicle(string license, Category category, double fuel, double mileage)
    {
        LicensePlate = license;
        CategoryVehicle = category;
        FuelConsumption = fuel;
        Mileage = mileage;
    }
}


