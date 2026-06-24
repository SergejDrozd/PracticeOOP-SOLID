class Program
{
    static void Main()
    {
        var calc = new Calculate();

        double distance = 10;
        double weight = 10;
        bool isFragile = false;
        string DeliveryType = "Standard";

        decimal finallyCost = calc.CalculateDeliveryCost(distance, weight, isFragile, DeliveryType);

        Console.WriteLine(finallyCost);
    }
}
