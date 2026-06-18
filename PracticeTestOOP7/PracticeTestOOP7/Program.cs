public class WaybillParseException : Exception
{
    public WaybillParseException(string message) : base(message)
    {
    }
}


class Waybill
{
    public string IdTruck { get; set; }
    public string NameTruck { get; set; }
    public int CountTruck { get; set; }
    public double WeightTruck { get; set; }


    public Waybill ParsingWaybill(string data)
    {
        if (string.IsNullOrWhiteSpace(data))
        {
            throw new WaybillParseException("Строка пуста");
        }

        string[] parts = data.Split(';');

        if (parts.Length != 4)
        {
            throw new WaybillParseException("Неверный формат строки");
        }

        string ID = parts[0];
        string Name = parts[1];

        if (!int.TryParse(parts[2], out int Count))
        {
            throw new WaybillParseException("Количество не int");
        }

        if (!double.TryParse(parts[3], out double Weight))
        {
            throw new WaybillParseException("Вес не double");
        }

        return new Waybill
        {
            IdTruck = ID,
            NameTruck = Name,
            CountTruck = Count,
            WeightTruck = Weight
        };
    }
}


class Programm
{
    static void Main()
    {
        var wb = new Waybill();

        var ok = wb.ParsingWaybill("AA;Volvo;10;5000");

        Console.WriteLine($"{ok.IdTruck} {ok.NameTruck} {ok.CountTruck} {ok.WeightTruck}");

        // wb.ParsingWaybill("AA;Volvo;abc;5000");
        // wb.ParsingWaybill("AA;Volvo;10;xyz");
        // wb.ParsingWaybill("AA;Volvo;10;5000;213");
    }
}
