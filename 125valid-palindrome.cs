public class Solution {
    public bool IsPalindrome(string s) {        
        int i = 0;
        int p = s.Length-1;
        
        while(i<=p)
        {
            while(i<s.Length && !Char.IsLetterOrDigit(s[i]))
            {
                i++;
            }
            while(p>=0 && !Char.IsLetterOrDigit(s[p]))
            {
                p--;
            }
            //Console.WriteLine($"{i}:{s[i]},{p}:{s[p]}");
            if(i==s.Length || p == -1)
            {
                return true;
            }
            if(i==p)
            {
                return true;
            }
            if(Char.ToLower(s[i])!=Char.ToLower(s[p]))
            {
                return false;
            }
            i++;
            p--;            
        }
        return true;
    }
    
    public bool IsPalindrome-2(string s) {        
        int i = 0;
        int j = s.Length -1;
        
        while(i<j)
        {
            if(!Char.IsLetterOrDigit(s[i]))
            {
                i++;
            }
            else if(!Char.IsLetterOrDigit(s[j]))
            {
                j--;
            }
            else if(Char.ToLower(s[i])!=Char.ToLower(s[j]))
            {
                return false;
            } 
            else
            {
                i++;
                j--;
            }
        }
        return true;
    }
}
