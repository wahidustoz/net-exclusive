// var sonlar = new Solution().TwoSum(
//     target: 9,
//     nums: new int[] { 2, 1, 3, 2, 7, 11, 15 });

// foreach(var son in sonlar)
//     Console.WriteLine(son);

public partial class Solution 
{
    public int[] TwoSum(int[] nums, int target)
    {
        var juftlar = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
            if(juftlar.ContainsKey(target - nums[i]))
                return new int[] { i, juftlar[target - nums[i]]};
            else
                juftlar.TryAdd(nums[i], i);

        return new int[] { };
    }
}