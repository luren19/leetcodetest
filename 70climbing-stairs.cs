public class Solution {
    public int ClimbStairs(int n) {
        int first = 1;
        int second = 2;
        int third = n;
        for(int i=3;i<=n;i++)
        {
            third = first + second;
            first = second;
            second = third;
        }
        return third;
    }
}
