using System;

public class Class1
{
	public Class1()
	{
        public static int LongestSubstringwithKDistinctCharacters(string str, int k)
        {
            int maxLength = 0;
            int windowStart = 0;
            var charFrequencyMap = new Dictionary<char, int>();

            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                var nextChar = str[windowEnd];

                if (!charFrequencyMap.ContainsKey(nextChar))
                    charFrequencyMap.Add(nextChar, 0);

                charFrequencyMap[nextChar] += 1;

                while (charFrequencyMap.Count > k)
                {
                    var leftCharToRemove = str[windowStart];

                    charFrequencyMap[leftCharToRemove] -= 1;

                    if (charFrequencyMap[leftCharToRemove] == 0)
                        charFrequencyMap.Remove(leftCharToRemove);

                    windowStart++;
                }

                maxLength = Math.Max(maxLength, (windowEnd - windowStart) + 1);
            }

            return maxLength;
        }
    }
}
