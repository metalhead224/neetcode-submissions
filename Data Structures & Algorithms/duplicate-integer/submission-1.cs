public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seenNum = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (!seenNum.Add(nums[i])) {
                return true;
            }
        }

        return false;
    }
}