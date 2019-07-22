public class Solution {
    public int Fib(int N) {
        if(N==0)
        {
            return 0;
        }
        int f0 = 0;
        int f1 = 1;
        //for(int i=2;i<=N;i++)
        while(N-->1)
        {
            f0 = (f1 += f0) - f0;
        }
        return f1;
    }
}
