public class Solution {
    public int RomanToInt(string s) {
        int temp = 0;
        Hashtable romanvalue = new Hashtable();
        Hashtable romanvalue1 = new Hashtable();
        romanvalue.Add("I",1);
        romanvalue.Add("V",5);
        romanvalue.Add("X",10);
        romanvalue.Add("L",50);
        romanvalue.Add("C",100);
        romanvalue.Add("D",500);
        romanvalue.Add("M",1000);
        romanvalue.Add("IV",4);
        romanvalue.Add("IX",9);
        romanvalue.Add("XL",40);
        romanvalue.Add("XC",90);
        romanvalue.Add("CD",400);
        romanvalue.Add("CM",900);
        
        for (int i = 0; i<s.Length; i++)
        {
            bool skip = false;
            if(i < s.Length -1)
            {
                //char[] substr = {s[i], s[i+1]};
                //string newsubstr = new string(substr);
                string newsubstr = s.Substring(i,2);
                switch(newsubstr)
                {
                    case "IV":
                    case "IX":
                    case "XL":
                    case "XC":
                    case "CD":
                    case "CM":
                        temp = temp + (int)romanvalue[newsubstr];
                        i ++;
                        skip = true;
                        break;
                        /*case "IV":
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
                        break;*/               
                }
            }
            if(!skip)
            {
                temp = temp + (int)romanvalue[s.Substring(i,1)];
                /*switch(s[i])
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
                }*/
            }
        }
        return temp;        
    }
}
