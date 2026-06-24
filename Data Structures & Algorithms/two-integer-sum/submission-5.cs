public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seenNumbers = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int difference = target - nums[i];

            if (seenNumbers.ContainsKey(difference)) {
                return [seenNumbers[difference], i];
            }

            if (!seenNumbers.ContainsKey(nums[i])) {
                seenNumbers.Add(nums[i], i);
            }

        }

        return null;
    }
}
