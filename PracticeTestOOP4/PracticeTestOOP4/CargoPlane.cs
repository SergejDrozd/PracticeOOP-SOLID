class CargoPlane : Transport
{
    public CargoPlane()
    {
        Speed = 800;
    }

    public override double CalculateTime(double distance)
    {
        return distance / Speed + 2;
    }
}