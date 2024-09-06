void Rotate(int[] nums, int k)
{
    if (k == nums.Length || k == 0 || nums.Length == 1) return;

    var tempArr = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        tempArr[(i + k) % nums.Length] = nums[i];
    }

    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = tempArr[i];
    }
}

//Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3);
Rotate(new int[] { 1, 2, 3, 4 }, 2);

// 1234 - 2
//1 - 4123 => i = (i+k)%len = 0+2%4 = 0
//2 - 3412 =
//3 - 2341
//4 - 1234