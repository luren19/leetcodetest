//Complexity Analysis:

//Time complexity : O(n)O(n). We traverse the list containing nn elements only once. Each look up in the table costs only O(1)O(1) time.

//Space complexity : O(n)O(n). The extra space required depends on the number of items stored in the hash table, which stores at most nn elements.

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
