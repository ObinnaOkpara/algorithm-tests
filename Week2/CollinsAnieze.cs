using System;

public class Class1
{
    public static List<int> WordConcatination(string str, string[] words)
    {
        int wordCount = words.Length;
        int wordLength = words[0].Length;
        int totalWordLength = wordCount * wordLength;

        var returnList = new List<int>();

        for (int i = 0; i <= str.Length - totalWordLength; i++)
        {
            var subString = str.Substring(i, totalWordLength);

            if (CheckForMatch(subString, words))
            {
                returnList.Add(i);
            }

        }

        return returnList;
    }

    public static bool CheckForMatch(string str, string[] words)
    {
        int wordLength = words[0].Length;
        var newDic1 = new Dictionary<string, int>();
        var newDic2 = new Dictionary<string, int>();


        for (int i = 0; i < str.Length; i += wordLength)
        {
            string word = str.Substring(i, wordLength);
            if (newDic1.ContainsKey(word))
            {
                newDic1[word] += 1;
                continue;
            }
            newDic1.Add(word, 1);
        }

        foreach (var word in words)
        {
            if (newDic2.ContainsKey(word))
            {
                newDic2[word] += 1;
                continue;
            }
            newDic2.Add(word, 1);
        }

        foreach (var keyValue in newDic2)
        {
            if (newDic1.ContainsKey(keyValue.Key))
            {
                if (!(keyValue.Value == newDic1[keyValue.Key]))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        return true;
    }

}
