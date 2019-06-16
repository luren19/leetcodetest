/*
 * @lc app=leetcode id=137 lang=csharp
 *
 * [137] Single Number II
 */
public class Solution {
    public int SingleNumber1(int[] nums) {
        int[] count = new int[32];
        int result = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = 0; j < 32; j++)
            {
                count[j] += nums[i]>>j&0x1;               
            }
        }

        for(int i = 0; i < 32; i++)
        {
            result |= (count[i]%3<<i);
        }

        return result;
    }
    
    public int SingleNumber2(int[] nums) {
        int low = 0;
        int high = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            low = ~high & (low ^ nums[i]);
            high = ~low & (high ^ nums[i]);           
        }

        return low;
    }
}

