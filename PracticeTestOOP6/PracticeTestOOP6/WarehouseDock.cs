class WarehouseDock
{
    private PriorityQueue<string, (int priority, int order)> queue
        = new PriorityQueue<string, (int priority, int order)>();

    private int arrivalCounter = 0;


    public void RegisterTruck(string plate, int priority)
    {
        if (priority < 1 || priority > 3)
        {
            throw new ArgumentException("Error priority");
        }

        // Инвертируем приоритет, чтобы 3 обслуживался раньше 1
        int invertedPriority = -priority;

        // Добавляем грузовик в очередь
        queue.Enqueue(plate, (invertedPriority, arrivalCounter));

        arrivalCounter++;
    }


    public void ProcessNextTruck()
    {
        if (queue.TryDequeue(out string plate, out _))
        {
            Console.WriteLine($"Грузовик {plate} разгружен");
        }
        else
        {
            Console.WriteLine("Грузовиков в очереди нет");
        }
    }
}
