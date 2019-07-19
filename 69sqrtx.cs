public class Solution {
    public int MySqrt(int x) {
        if(x<=1)
        {
            return x;
        }
        long left = 1;
        long right = x;
        while(left<right)
        {
            long mid = (right+left)/2;
            //Console.WriteLine($"{left},{right},{mid}");
            if(mid*mid>x)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
            //Console.WriteLine($"{left},{right},{mid}");
        }
        return Convert.ToInt32(left-1);
    }
}
