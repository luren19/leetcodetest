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
    
    public int MaxProfit-DP(int[] prices) {
        int maxprofit = 0;
        int len = prices.Length;
        if(len<2)
        {
            return maxprofit;
        }
        int minprice = prices[0];
        for(int i=1;i<len;i++)
        {
            int tempprice = prices[i];
            if(minprice>tempprice)
            {
                minprice = tempprice;
            }
            else if(prices[i]-minprice>maxprofit)
            {
                maxprofit = prices[i]-minprice;
            }
        }
        return maxprofit;
    }

        public int MaxProfit-Kadane(int[] prices) {
        int maxprofit = 0;
        int maxcurprofit = 0;
        int len = prices.Length;

        for(int i=1;i<len;i++)
        {
            maxcurprofit = Math.Max(0,maxcurprofit + prices[i] - prices[i-1]);
            maxprofit = Math.Max(maxprofit,maxcurprofit);
        }
        return maxprofit;
    }
}
