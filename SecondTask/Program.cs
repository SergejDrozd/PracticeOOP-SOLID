class Containers
{
    public int GetRequiredContainers(int[] boxWeights, int maxCapacity)
    {
        int i, count = 0, currentWeight = 0;
        for (i = 0; i< boxWeights.Length; i++)
        {
            //Две проверки, первая на правильные данные, вторая на то, если контейнер не переполняется, если обо условия не выполняются, значит контейнер перполнен
            if (boxWeights[i] > maxCapacity) throw new ArgumentException("Invalid boxWeights");
            else if(boxWeights[i] + currentWeight <= maxCapacity) currentWeight += boxWeights[i];
            else {
                count++;
                currentWeight = boxWeights[i];
            }
        }
        //Возвращаем количество контейнеров + 1, так как последний контейнер не заполнен
        return count + 1;
    }


}


class Program
{
    static void Main()
    {
        var cont = new Containers();
        int[] boxWeights = [1, 3, 4, 6, 2, 3, 1, 1];
        int maxCapacity = 7;
        int count;
        count = cont.GetRequiredContainers(boxWeights, maxCapacity);
        Console.WriteLine(count);
    }
}
