public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> triangle = new List<IList<int>>();
        
        if(numRows == 0)
        {
            return triangle;
        }
        
        triangle.Add(new List<int>());
        triangle[0].Add(1);
        
        for(int rowNum = 1; rowNum < numRows;rowNum++)
        {
            List<int> row = new List<int>();
            List<int> prevRow = new List<int>(triangle[rowNum-1]);
            row.Add(1);
            for(int j = 1; j < rowNum; j++)
            {
                row.Add(prevRow[j-1] + prevRow[j]);
            }
            row.Add(1);
            triangle.Add(row);
        }
        
        return triangle;
    }
}
