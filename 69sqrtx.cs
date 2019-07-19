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
    
    public int MySqrt2(int x) {
        if(x<=1)
        {
            return x;
        }
        long left = 1;
        long right = x;
        while(true)
        {
            long mid = (right+left)/2;
            //Console.WriteLine($"{left},{right},{mid}");
            if(mid>x/mid)
            {
                right = mid-1;
            }
            else
            {
                if((mid+1)>x/(mid+1))
                {
                    return Convert.ToInt32(mid);
                }
                left = mid + 1;
            }
            //Console.WriteLine($"{left},{right},{mid}");
        }
    }
    
    public int MySqrt-Newton(int x) {
        if(x<=1)
        {
            return x;
        }
        int result = x;
        while(result>x/result)
        {
            result = (result + x/result)/2;
        }
        return result;
    }
    
    public int MySqrt(int x) {
        if(x<=1)
        {
            return x;
        }
        long result = x;
        while(result*result>x)
        {
            result = (result + x/result)/2;
            //Console.WriteLine(Convert.ToInt32(result));
        }
        return Convert.ToInt32(result);
    }
}
