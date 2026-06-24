class Train : Transport
{
    public Train()
    {
        Speed = 120;
    }

    public override double CalculateTime(double distance)
    {
        return distance / Speed;
    }
}
