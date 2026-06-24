public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        int[] charCounts = new int[256];

        for (int i = 0; i < s.Length; i++)
        {
            charCounts[s[i]]++;
            charCounts[t[i]]--;
        }

        foreach (int count in charCounts)
        {
            if (count != 0) return false;
        }

        return true;
    }
}
