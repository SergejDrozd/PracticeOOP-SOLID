class Programm
{
    static void Main()
    {
        var container = new ContainersV("2", 0, 0);

        container.VolumeCapacity = 20;

        int volume = 5;

        Console.WriteLine(container.CurrentStatus);

        container.LoadCargo(volume);
        Console.WriteLine(container.CurrentStatus);
        Console.WriteLine(container.CurrentVolume);

        volume = 15;
        container.LoadCargo(volume);
        Console.WriteLine(container.CurrentStatus);
        Console.WriteLine(container.CurrentVolume);

        volume = 20;
        container.UnloadCargo(volume);
        Console.WriteLine(container.CurrentStatus);
        Console.WriteLine(container.CurrentVolume);

        var container1 = container.Clone("3");

        Console.WriteLine(container1.CurrentStatus);
        Console.WriteLine(container1.CurrentVolume);
    }
}
