using System;

public class Class1
{
	public Class1()
	{
        public static string TwoString(string str1, string str2)
        {

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        return "YES";
                    }
                }
            }

            return "NO";
        }
    }
}
