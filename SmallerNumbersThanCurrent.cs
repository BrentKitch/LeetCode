public int[] SmallerNumbersThanCurrent(int[] nums) 
{
    int[] counts = new int[nums.Length];
    for(int i = 0; i < nums.Length; i++)
    {
        int count =0;
        for(int a = 0; a < nums.Length; a++)
        {
            if(nums[a] < nums[i]) count++;
        }
        counts[i] = count;
    }
    return counts;
}