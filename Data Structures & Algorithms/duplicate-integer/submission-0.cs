public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seenNum = new HashSet<int>();
        int n = nums.Length;

        for (int i = 0; i < n; i++) {
            if (!seenNum.Add(nums[i])) {
                return true;
            }
        }

        return false;
    }
}