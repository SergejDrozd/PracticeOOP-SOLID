class WarehouseDock
{
    //Решил использовать три очереди, чтобы обеспечить условие: Если приоритеты равны, первым обслуживается тот, кто приехал раньше
    private Queue<string> high = new Queue<string>();
    private Queue<string> medium = new Queue<string>();
    private Queue<string> low = new Queue<string>();

    public void RegisterTruck(string plate, int priority)
    {
        switch (priority)
        {
            case 3: high.Enqueue(plate); break;
            case 2: medium.Enqueue(plate); break;
            case 1: low.Enqueue(plate); break;
            default:
                throw new ArgumentException("Error priority");
        }
    }

    public void ProcessNextTruck()
    {
        if (high.Count > 0)
        {
            Console.WriteLine($"Грузовик {high.Dequeue()} разгружен");
        }
        else if (medium.Count > 0)
        {
            Console.WriteLine($"Грузовик {medium.Dequeue()} разгружен");
        }
        else if (low.Count > 0)
        {
            Console.WriteLine($"Грузовик {low.Dequeue()} разгружен");
        }
        else
        {
            Console.WriteLine("Грузовиков в очереди нет");
        }
    }
}


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
