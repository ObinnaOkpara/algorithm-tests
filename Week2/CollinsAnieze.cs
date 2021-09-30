using System;

public class Class1
{
    public static List<int> WordConcatSubStringIndicies(string str, string[] words)
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

    public static bool CheckForMatch(string subString, string[] words)
    {
        bool isFound = false;
        string word = string.Empty;
        //This loops and concantenates each words in words and compare it with the substring
        //If it matches, we return true

        //This loop picks a word from words array
        for (int i = 0; i < words.Length; i++)
        {
            word = words[i];
            //This loop joins every word in words with the word picked in the above loop.
            for (int j = 0; j < words.Length; j++)
            {
                //we skip a step here, since we dont want to join a word to itself.
                if (i == j)
                {
                    continue;
                }
                word += words[j];
            }
            //Then, we compare the concatenated word with the subtring, 
            //If it matches, break out of the loop
            if (word == subString)
            {
                isFound = true;
                break;
            }
        }

        return isFound;
    }

}
