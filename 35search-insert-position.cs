public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if(nums.Length == 0)
        {
            return 0;
        }
        int i = 0;                
        for(;i<nums.Length;i++)
        {
            //Console.WriteLine(nums[i]);
            if(nums[i]>=target)
            {
                return i;
            }
        }
        return i;        
    }
}
