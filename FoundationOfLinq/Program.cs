

var result = GenerateNumberRandom(7).Where(x =>
{
	return x % 2 == 0;
}).Select(x =>
{
	return x * 2;
});

/*foreach (var item in result)
{
	Console.WriteLine(item);
}*/

foreach (var item in UseYield())
{
    Console.WriteLine(item);
}

IEnumerable<int> UseYield()
{
    var total = 1;                          //  5
    for (var i = 0; i < 5; i++)             //  6
    {                                       //  7
        total += i;                         //  8
        yield return total;                 //  9
    }                                       //  10
}

IEnumerable<int> GenerateNumberRandom(int maxValue)
{
	for (int i = 0; i < maxValue; i++)
	{
		yield return i;
	}
}

//normally
/*IEnumerable<int> GenerateNumberRandom(int maxValue)
{
	var list = new List<int>();
	for (int i = 0; i < maxValue; i++)
	{
		list.Add(i);
	}
	return list;
}*/