using PushBased;

FibonacciSequence sequence = new FibonacciSequence();
foreach (int number in sequence.GetSequence().Take(10))
{
    Console.WriteLine(number);
}


/*Demo number from 0 to x*/
foreach (var number in GetNumbers(10))
{
    Console.WriteLine(number);
}

IEnumerable<int> GetNumbers(int limit)
{
    for (int i = 1; i <= limit; i++)
    {
        yield return i;
    }
}