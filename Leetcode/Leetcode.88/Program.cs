void Merge(int[] nums1, int m, int[] nums2, int n)
{
    if (n == 0) return;
    if (m == 0)
    {
        Array.Copy(nums2, nums1, n);
    }

    int index = 0;
    for (int i = m; i < nums1.Length; i++)
    {
        if (nums1[i] == 0)
        {
            nums1[i] = nums2[index++];
        }
    }
    Array.Sort(nums1);
    var test = nums1;
}

//Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
//Merge(new int[] { 1 }, 1, new int[] { }, 0);
Merge(new int[] { 0 }, 0, new int[] { 1 }, 1);