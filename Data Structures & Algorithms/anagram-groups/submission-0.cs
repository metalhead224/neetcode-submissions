public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagrams = 
            new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!anagrams.ContainsKey(key))
            {
                anagrams[key] = new List<string>();
            }

            anagrams[key].Add(str);
        }

        return anagrams.Values.Cast<List<string>>().ToList();
    }
}
