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
        if (CurrentVolume + volume > VolumeCapacity)
        {
            throw new InvalidOperationException("Too much");
        }

        CurrentVolume += volume;
    }

    public void UnloadCargo(double volume)
    {
        if (CurrentVolume - volume < 0)
        {
            throw new InvalidOperationException("Less than zero");
        }

        CurrentVolume -= volume;
    }

    public Status CurrentStatus
    {
        get
        {
            if (CurrentVolume == 0)
            {
                return Status.Empty;
            }

            if (CurrentVolume == VolumeCapacity)
            {
                return Status.Full;
            }

            return Status.PartiallyFilled;
        }
    }

    public ContainersV Clone(string idNew)
    {
        return new ContainersV(idNew, this.VolumeCapacity, this.CurrentVolume);
    }
}


