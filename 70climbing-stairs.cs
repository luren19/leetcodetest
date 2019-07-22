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
    
    public int ClimbStairs-Fibonacci2(int n) {
        int a = 1, b = 1;
        while (n-- > 0)
            a = (b += a) - a;
        return a;
    }
    
    public int ClimbStairs-bruteforce(int n) {
        int[] memo = new int[n+1];
        return ClimbStairs-bruteforce(0,n,memo);
    }
    
    public int ClimbStairs-bruteforce(int i, int n, int[] memo)
    {
        if(i>n)
        {
            return 0;
        }
        if(i==n)
        {
            return 1;
        }
        if(memo[i]>0)
        {
            return memo[i];
        }
        memo[i]=ClimbStairs-bruteforce(i+1,n,memo)+ClimbStairs-bruteforce(i+2,n,memo);
        return memo[i];
    }
}
