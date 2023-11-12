//int RemoveDuplicates(int[] nums)
//{
//    var flag = 0;
//    var val = int.MinValue;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] != val)
//        {
//            val = nums[i];
//            nums[flag++] = nums[i];
//        }
//    }
//    return flag;
//}

int RemoveDuplicates(int[] nums)
{
    var flag = 1;
    var val = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            val = nums[i];
            nums[flag++] = nums[i];
        }
    }
    return flag;
}