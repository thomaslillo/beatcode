public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {

        // exit early if        
        if (strs.Count() == 1) {
            return new List<IList<string>>() { strs.ToList() };
        }

        // holds all the arrays
        Dictionary<string, IList<string>> results = new Dictionary<string,IList<string>>();

        foreach (string word in strs)
        {
            // sort the string
            char[] characters = word.ToCharArray();
            Array.Sort(characters);
            string sortedWord = new string(characters);

            if (results.ContainsKey(sortedWord))
            {
                var tempList = results[sortedWord];
                tempList.Add(word);
                results[sortedWord] = tempList.ToList();
            }
            else 
            {
                results.Add(sortedWord, new List<string> { word });
            }
        }

        return results.Values.ToList();
    }
}
