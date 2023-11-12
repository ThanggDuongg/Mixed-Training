

IEnumerable<int> GetNumbers_IEnum(int limit)
{
    for (int i = 1; i <= limit; i++)
    {
         return i;
    }
}

List<int> GetNumbers_List(int limit)
{
    for (int i = 1; i <= limit; i++)
    {
        return i;
    }
}

foreach (int number in numbers)
{
    Console.WriteLine(number);
}