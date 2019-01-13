//Reversing an integer can be done similarly to reversing a string.

//We want to repeatedly "pop" the last digit off of xx and "push" it to the back of the \text{rev}rev. In the end, \text{rev}rev will be the reverse of the xx.

//To "pop" and "push" digits without the help of some auxiliary stack/array, we can use math.

//Need to check beforehand whether or this statement would cause an overflow.

public class Solution {
    public int Reverse(int x) {
        int rev = 0;
        while(x != 0)
        {
            int pop = x % 10;
            x /= 10;
            if(rev > int.MaxValue / 10 
               || (rev == int.MaxValue / 10 && pop > 7)
               || rev < int.MinValue / 10
               || (rev == int.MinValue / 10 && pop < -8)
              )
            {
                return 0;
            }
            rev = rev * 10 + pop;
        }
        return rev;        
    }
}
