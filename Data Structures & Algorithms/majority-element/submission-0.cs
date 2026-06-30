public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> elementsWithCount = new Dictionary<int, int>();
        int maxCountKey = 0;
        int currentMaxElement = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (!elementsWithCount.ContainsKey(nums[i]))
            {
                elementsWithCount.Add(nums[i], 1);
            }
            else
            {
                elementsWithCount[nums[i]]++;
            }
        }

        foreach (var kvp in elementsWithCount)
        {
            if (kvp.Value > currentMaxElement)
            {
                currentMaxElement = kvp.Value;
                maxCountKey = kvp.Key;
            }
        }

        return maxCountKey;
    }
}