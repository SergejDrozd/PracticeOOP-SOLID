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
