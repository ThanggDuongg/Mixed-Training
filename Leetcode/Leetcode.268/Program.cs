int MissingNumber(int[] nums)
{
    var max = nums.Max() + 1;
    var sum = Enumerable.Range(0, max).Sum();
    var result = sum - nums.Sum();
    return nums.Contains(0) && result == 0 ? max : result;
}

var test = MissingNumber(new[] { 0,  1 });