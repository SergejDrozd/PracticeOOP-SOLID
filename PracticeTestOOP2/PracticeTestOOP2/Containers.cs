class Containers
{
    public int GetRequiredContainers(int[] boxWeights, int maxCapacity)
    {
        int i;
        int count = 0;
        int currentWeight = 0;

        for (i = 0; i < boxWeights.Length; i++)
        {
            // Две проверки:
            // 1) На корректность данных
            // 2) На переполнение контейнера
            if (boxWeights[i] > maxCapacity)
            {
                throw new ArgumentException("Invalid boxWeights");
            }
            else if (boxWeights[i] + currentWeight <= maxCapacity)
            {
                currentWeight += boxWeights[i];
            }
            else
            {
                count++;
                currentWeight = boxWeights[i];
            }
        }

        // Возвращаем количество контейнеров + 1, так как последний контейнер не заполнен
        return count + 1;
    }
}