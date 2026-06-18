class Program
{
    static void Main()
    {
        var cont = new Containers();

        int[] boxWeights = [1, 3, 4, 6, 2, 3, 1, 1];
        int maxCapacity = 7;

        int count = cont.GetRequiredContainers(boxWeights, maxCapacity);

        Console.WriteLine(count);
    }
}
