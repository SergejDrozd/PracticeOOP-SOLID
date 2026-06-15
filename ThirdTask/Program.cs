class ContainersV
{
    public string Id { get; }
    public ContainersV(string id, double volumeCapacity, double currentVolume = 0)
    {
        Id = id;
        VolumeCapacity = volumeCapacity;
        CurrentVolume = currentVolume;
    }
    public double VolumeCapacity { get; set; }
    public double CurrentVolume { get; private set; } = 0;
    public enum Status
    {
        Empty, 
        PartiallyFilled, 
        Full
    }
    public void LoadCargo(double volume)
    {
        if (CurrentVolume + volume > VolumeCapacity) throw new InvalidOperationException("Too much");
        CurrentVolume += volume;
    }
    public void UnloadCargo(double volume)
    {
        if (CurrentVolume - volume < 0) throw new InvalidOperationException("Less than zero");
        CurrentVolume -= volume;
    }

    public Status CurrentStatus
    {
        get
        {
            if (CurrentVolume == 0) return Status.Empty;
            if (CurrentVolume == VolumeCapacity) return Status.Full;
            return Status.PartiallyFilled;
        }
    }
    public ContainersV Clone(string idNew)
    {
        return new ContainersV(idNew, this.VolumeCapacity, this.CurrentVolume);
    }

}

class Programm() 
{
    static void Main()
    {
        var Container = new ContainersV("2", 0, 0);
        Container.VolumeCapacity = 20;
        int volume = 5;
        Console.WriteLine(Container.CurrentStatus);
        Container.LoadCargo(volume);
        Console.WriteLine(Container.CurrentStatus);
        Console.WriteLine(Container.CurrentVolume);
        volume = 15;
        Container.LoadCargo(volume);
        Console.WriteLine(Container.CurrentStatus);
        Console.WriteLine(Container.CurrentVolume);
        volume = 20;
        Container.UnloadCargo(volume);
        Console.WriteLine(Container.CurrentStatus);
        Console.WriteLine(Container.CurrentVolume);

        var Container1 = Container.Clone("3");
        Console.WriteLine(Container1.CurrentStatus);
        Console.WriteLine(Container1.CurrentVolume);
    }
}
