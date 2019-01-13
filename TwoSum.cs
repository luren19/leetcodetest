public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> temp = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(temp.ContainsKey(target-nums[i]))
            {      
                return new int[2]{temp[target-nums[i]],i};
            }
            else if(!(temp.ContainsKey(nums[i])))
            {                
                temp.Add(nums[i],i);
            }
        }
        return null;        
    }
}
