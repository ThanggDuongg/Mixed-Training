int RemoveElement(int[] nums, int val)
{
    var flag = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            nums[flag++] = nums[i];
        }
    }
    return flag;
}

var test = RemoveElement(new[] { 3, 2, 2, 3 }, 3);