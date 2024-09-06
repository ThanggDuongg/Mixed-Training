int SingleNumber(int[] nums)
{
    //return nums.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).First();
    var dict = new Dictionary<int, int>();
    foreach (var x in nums)
    {
        if (dict.ContainsKey(x))
        {
            dict[x] = dict[x] + 1;
        } 
        else
        {
            dict.Add(x, 1);
        }
    }
    return dict.Where(x => x.Value == 1).Select(x => x.Key).First();
}