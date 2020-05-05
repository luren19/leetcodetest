public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if(nums.Length <= 1){
            return false;
        }
        HashSet<int> list = new HashSet<int>();
        for(int i=0; i<nums.Length; i++){
            if(list.Contains(nums[i])){
                return true;
            }
            else{
                list.Add(nums[i]);
            }
        }
        return false;
    }
    
    public bool ContainsDuplicate2(int[] nums) {
        if(nums.Length <= 1){
            return false;
        }
        Array.Sort(nums);
        for(int i=0; i<nums.Length-1; i++){
            if(nums[i]==nums[i+1]){
                return true;
            }
        }
        return false;
    }
}
