public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int newArrLength = 2 * n;
        int[] ans = new int[newArrLength];

        Array.Copy(nums, 0, ans, 0, n);
        Array.Copy(nums, 0, ans, n, n);
        return ans;
    }
}