/*
Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.

The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2.

Note:

Your returned answers (both index1 and index2) are not zero-based.
You may assume that each input would have exactly one solution and you may not use the same element twice.
Example:

Input: numbers = [2,7,11,15], target = 9
Output: [1,2]
Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.
*/

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int,int> numPairs = new Dictionary<int,int>();
        for(int i = 0; i < numbers.Length; i++){
            if(numPairs.ContainsKey(target-numbers[i])){
                return new int[2]{numPairs[target-numbers[i]]+1, i+1};
            }
            else if(!numPairs.ContainsKey(numbers[i])){
                numPairs.Add(numbers[i], i);
            }
        }
        return null;
    }
    
    //use 2 points
    public int[] TwoSum2(int[] numbers, int target) {
        int p = 0;
        int q = numbers.Length-1;
        while(p<q){
            int sum = numbers[p] + numbers[q];
            if(sum == target){
                return new int[2]{p+1,q+1};
            }
            else if(sum < target){
                p++;
            }
            else{
                q--;
            }
        }
        return null;
    }
}


