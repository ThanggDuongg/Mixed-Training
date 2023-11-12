int SearchInsert(int[] nums, int target)
{
    var min = nums.Min();
    var max = nums.Max();

    if (min >= target)
    {
        return 0;
    }

    if (max < target)
    {
        return nums.Length;
    }

    var index = Array.FindIndex(nums, x => x == target);
    if (index == -1)
    {
        var result = Array.FindIndex(nums, x => x > target);
        return result - 1;
    }
    return index;
}

SearchInsert(new[] { 1, 3, 5, 6 }, 5);