public class Solution {
    // Use Dictionary
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> countdic = new Dictionary<int, int>();
        //int halflen = nums.Length/2;
        //Console.WriteLine(halflen);
        for(int i = 0; i < nums.Length; i++){
            if(countdic.ContainsKey(nums[i])){
                countdic[nums[i]]++;                
            }
            else{
                countdic.Add(nums[i],1);
            }
            //Console.WriteLine(countdic[nums[i]]);
            if(countdic[nums[i]] > nums.Length/2){
                return nums[i];
            }
        }
        return -1;

        /*KeyValuePair<int, int> maxitem = new KeyValuePair<int, int>(0,0);
        foreach(var item in countdic){
            if(item.Value > maxitem.Value){
                maxitem = item;
            }
        }
        
        return maxitem.Key;*/     
    }
    
    // Use sorting
    public int MajorityElement2(int[] nums) {
        Array.Sort(nums);
        return nums[nums.Length/2];
    }
    
   
}
