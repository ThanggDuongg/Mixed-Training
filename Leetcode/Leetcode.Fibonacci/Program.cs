Console.WriteLine(Fibonacci(100000));

long Fibonacci(long x)
{
    long[] array = new long[4];
    array[0] = array[1] = 1;

    for (long i = 2; i < x; i++)
    {
        array[3] = array[0] + array[1];
        array[0] = array[1];
        array[1] = array[3];
    }

    return array[3];
}