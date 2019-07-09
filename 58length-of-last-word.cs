public class Solution {
    public int LengthOfLastWord(string s) {
        int lens = 0;
        int end = s.Length - 1;
        while(end >= 0 && s[end] == ' ')
        {
            end--;
        }
        int start = end;
        while(start >= 0 && s[start] != ' ')
        {
            start --;
        }
        return end - start;
    }
}
