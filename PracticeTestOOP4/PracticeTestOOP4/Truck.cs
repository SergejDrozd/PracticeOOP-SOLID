class Truck : Transport
{
    public Truck()
    {
        Speed = 80;
    }

    public override double CalculateTime(double distance)
    {
        return distance / Speed;
    }
}