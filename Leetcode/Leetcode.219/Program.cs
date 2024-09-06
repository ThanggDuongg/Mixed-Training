bool ContainsNearbyDuplicate(int[] nums, int k)
{
    var dict = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (!dict.ContainsKey(nums[i]))
        {
            dict.Add(nums[i], i);
        } else
        {
            if (dict[nums[i]] - i < k)
            {
                return true;
            } else
            {
                dict[nums[i]] = i;
            }
        }
    }
    return false;
}

var result = ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1);