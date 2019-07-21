public class Solution {
    public int ClimbStairs-Fibonacci(int n) {
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
    
    public int ClimbStairs-dp(int n) {
        if(n<=2)
        {
            return n;
        }
        int[] dp = new int[n];
        dp[0] = 1;
        dp[1] = 2;
        for(int i=2;i<n;i++)
        {
            dp[i] = dp[i-1] + dp[i-2];
        }
        return dp[n-1];
    }
}
