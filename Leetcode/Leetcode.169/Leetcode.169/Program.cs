int MajorityElement(int[] nums)
{
    var x = nums.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).First();
    return nums.GroupBy(x => x).OrderByDescending(x => x).Select(x => x.Key).First();
}

MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 });