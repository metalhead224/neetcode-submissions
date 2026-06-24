public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        char[] sChar = s.ToCharArray();
        char[] tChar = t.ToCharArray();

        Dictionary<char, int> sCharKvp = new Dictionary<char, int>();
        Dictionary<char, int> tCharKvp = new Dictionary<char, int>();

        for (int i = 0; i < sChar.Length; i++) {
            if (!sCharKvp.ContainsKey(sChar[i])) {
                sCharKvp.Add(sChar[i], 1);
            } else {
                sCharKvp[sChar[i]]++;
            }
        }

        for (int i = 0; i < tChar.Length; i++) {
            if (!tCharKvp.ContainsKey(tChar[i])) {
                tCharKvp.Add(tChar[i], 1);
            } else {
                tCharKvp[tChar[i]]++;
            }
        }

        foreach (var sItem in sCharKvp) {
            if (!tCharKvp.ContainsKey(sItem.Key) 
                || tCharKvp[sItem.Key] != sItem.Value)
            {
                return false;
            }
        }

        return true;
    }
}
