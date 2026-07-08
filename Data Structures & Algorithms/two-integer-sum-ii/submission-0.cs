public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var map  = new Dictionary<int, int>();

        for(int i = 0; i < numbers.Length; i++)
        {
            var diff = target - numbers[i];

            if(map.ContainsKey(diff))
            {
                return new int[2] {map[diff] + 1, i+1};
            }
            map.Add(numbers[i], i);
        }
        return [];
    }
}
