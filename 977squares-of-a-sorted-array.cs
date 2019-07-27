public class Solution {
    public int[] SortedSquares(int[] A) {
        int len = A.Length;
        int i=0;
        while(i<len&&A[i]<0)
        {
            i++;
        }
        int j=i-1;
        int[] result = new int[len];
        int k = 0;
        int templ,tempr;
        while(j>=0&&i<len)
        {
            templ = A[j]*A[j];
            tempr= A[i]*A[i];
            if(templ<tempr)
            {
                result[k++]=templ;
                j--;
            }
            else
            {
                result[k++]=tempr;
                i++;
            }
        }
        while(j>=0)
        {
            result[k++]=A[j]*A[j];
            j--;
        }
        while(i<len)
        {
            result[k++]=A[i]*A[i];
            i++;
        }
        
        return result;
    }
    
    public int[] SortedSquares-2(int[] A) {
        int len = A.Length;
        int i=0;
        int j=len-1;
        int[] result = new int[len];
        for(int k=len-1;k>=0;k--)
        {
            if(Math.Abs(A[i])>Math.Abs(A[j]))
            {
                result[k]=A[i]*A[i];
                i++;
            }
            else
            {
                result[k]=A[j]*A[j];
                j--;
            }            
        }
        return result;
    }
}
