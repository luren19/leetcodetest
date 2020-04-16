public class Solution {
    public void Rotate(int[] nums, int k) {
        if(nums.Length == 0) return;
        k = k % nums.Length;
        if(k == 0) return;
        int count = 0;

        for(int i = 0; count < nums.Length; i++)
        {            
            int current = i;
            int temp = nums[i];
            do
            {                
                int nextRotate = (current+k)%nums.Length;
                int temp2 = nums[nextRotate];
                // Console.WriteLine($"current is {current} {temp}, next is {nextRotate} {temp2}");
                nums[nextRotate] = temp;
                temp = temp2;
                current = nextRotate;
                count++;
            } while(i != current);
        }
    }
}
