public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int len = cost.Length;
        if(len<2)
        {
            return 0;
        }
        
        int f1 = cost[0];
        int f2 = cost[1];
        for(int i=2;i<len;i++)
        {
            int temp = cost[i]+Math.Min(f1,f2);
            f1 = f2;
            f2 = temp;
        }
        return Math.Min(f1,f2);
    }
    
      public int MinCostClimbingStairs-startfromthelaststep(int[] cost) {
      int f1 = 0;
      int f2 = 0;
      for(int i=cost.Length-1;i>=0;i--)
      {
          int temp = cost[i]+Math.Min(f1,f2);
          f1 = f2;
          f2 = temp;
      }
      return Math.Min(f1,f2);
    }
}
