using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Giraffe
{
    public class MostCommonWordSolution
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            string[] words = Regex.Split(paragraph, "[\\s|!|\\?|'|,|;|\\.]");
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++) 
            {
                string processedWord = words[i].ToLower().Trim();
                if (processedWord.Length == 0)
                {
                    continue;
                }
                if (dict.ContainsKey(processedWord))
                {
                    dict[processedWord] += 1;
                }
                else
                {
                    dict.Add(processedWord, 1);
                }
            }
            List<KeyValuePair<string, int>> list = dict.ToList();
            list.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            HashSet<string> set = new HashSet<string>(banned);
            foreach(KeyValuePair<string, int> pair in list) 
            {
                if (!set.Contains(pair.Key)) 
                {
                    return pair.Key;
                }
            }
            return null;
        }
    }
}
