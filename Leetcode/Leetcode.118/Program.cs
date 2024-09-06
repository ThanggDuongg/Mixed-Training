IList<IList<int>> Generate(int numRows)
{
    var result = new List<IList<int>>(); // { new List<int> { 1 }, new List<int> { 1,1 } };

    if (numRows == 0)
    {
        return result;
    } 
    else if (numRows == 1) 
    {
        result.Add(new List<int> { 1 });
        return result;
    }
    else if (numRows == 2)
    {
        result.AddRange(new List<IList<int>>() { new List<int> { 1 }, new List<int> { 1, 1 } });
        return result;
    }
    result.AddRange(new List<IList<int>>() { new List<int> { 1 }, new List<int> { 1, 1 } });

    for (int i = 3; i <= numRows; i++)
    {
        var arr = new List<int>() { 1 };
        for (int j = 1; j <= i - 2; j++)
        {
            var sum = result[i - 2][j-1] + result[i - 2][j];
            arr.Add(sum);
        }
        arr.Add(1);
        result.Add(arr);
    }

    return result;
}

var a = Generate(5);