class Programm
{
    static void Main()
    {
        var dock = new WarehouseDock();

        dock.RegisterTruck("AA", 1);
        dock.RegisterTruck("BB", 2);
        dock.RegisterTruck("CC", 3);
        dock.RegisterTruck("DD", 2);

        dock.ProcessNextTruck();
        dock.ProcessNextTruck();
        dock.ProcessNextTruck();
        dock.ProcessNextTruck();
        dock.ProcessNextTruck();
    }
}
