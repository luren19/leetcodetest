public class Solution {
    public int MaxProfit-bruteforce(int[] prices) {
        int maxprofit = 0;
        int len = prices.Length;
        for(int i=0;i<len-1;i++)
        {
            for(int j=i+1;j<len;j++)
            {
                int tempprofit = prices[j]-prices[i];
                if(tempprofit>maxprofit)
                {
                    maxprofit=tempprofit;
                }
            }
        }
        return maxprofit;
    }
}
