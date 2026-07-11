public class Solution {
    public int MaxArea(int[] heights) {
        int start = 0;
        int end = heights.Length-1;
        var maxArea = int.MinValue;
        while(start < end)
        {               //width                //height -> h * w is area of rectangle
            var area = (end-start) * Math.Min(heights[start], heights[end]);
            maxArea = Math.Max(maxArea, area);

            if(heights[end] < heights[start])
            {
                end--;
            } else {
                start++;
            }
        }

        return maxArea;
    }
}
