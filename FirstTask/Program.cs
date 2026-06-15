class Calculate
{
    public decimal CalculateDeliveryCost(double distance, double weight, bool isFragile, string DeliveryType)
    {
        // Проврека расстояния и веса на положительное число
        if (weight <= 0) throw new ArgumentException("Invalid weight");
        if (distance <= 0) throw new ArgumentException("Invalid distance");

        decimal cost = 10;

        //Рассчёт веса
        cost += (decimal)weight * 2m;

        //Рассчёт расстояния, 3-ий вариант требовал, чтобы за каждый километр свыше 1000 была скидка в 20%.
        if (distance <= 1000) cost += (decimal)distance * 0.5m;
        else cost += 500m + (decimal)(distance - 1000) * 0.4m;

        //Рассчёт хрупкости
        if (isFragile) cost *= 1.5m;

        //Определние коэффицента за тип товара
        if (DeliveryType == "Standard") cost *= 1m;
        else if (DeliveryType == "Express") cost *= 1.5m;
        else if (DeliveryType == "Overnight") cost *= 2m;
        else throw new ArgumentException("Invalid DeliveryType");

        return cost;
    }
}


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

