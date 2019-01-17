public class Solution {
    public int RomanToInt(string s) {
        int temp = 0;
        
        for (int i = 0; i<s.Length; i++)
        {
            bool skip = false;
            if(i < s.Length -1)
            {
                char[] substr = {s[i], s[i+1]};
                string newsubstr = new string(substr);

                switch(newsubstr)
                {
                    case "IV":
                        temp += 4;
                        i ++;
                        skip = true;
                        break;
                    case "IX":
                        temp += 9;
                        i ++;
                        skip = true;
                        break;
                    case "XL":
                        temp += 40;
                        i ++;
                        skip = true;
                        break;
                    case "XC":
                        temp += 90;
                        i ++;
                        skip = true;
                        break;
                    case "CD":
                        temp += 400;
                        i ++;
                        skip = true;
                        break;
                    case "CM":
                        temp += 900;
                        i ++;
                        skip = true;
                        break;                
                }
            }
            if(!skip)
            {
                switch(s[i])
                {
                    case 'I':
                        temp +=1;
                        break;
                    case 'V':
                        temp +=5;
                        break;
                    case 'X':
                        temp +=10;
                        break;
                    case 'L':
                        temp +=50;
                        break;
                    case 'C':
                        temp +=100;
                        break;
                    case 'D':
                        temp +=500;
                        break;
                    case 'M':
                        temp +=1000;
                        break;
                }
            }
        }
        return temp;        
    }
}
