int CountPrimes(int n)
{
    if (n == 0 || n == 1)
    {
        return 0;
    }

    var primes = new bool[n + 1];
    Array.Fill(primes, true);

    for (int p = 2; p <= Math.Sqrt(n); p++)
    {
        if (primes[p])
        {
            for (int i = p; i * p <= n; i++)
            {
                primes[i * p] = false;
            }
        }
    }

    primes = primes[2..n];
    return primes.Count(x => x);
}

CountPrimes(2);
