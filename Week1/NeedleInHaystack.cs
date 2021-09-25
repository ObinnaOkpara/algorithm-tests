
    class Program
    {
        static void Main(string[] args)
        {
            var ans = NeedleInHaystack("Hello", "lo");
            Console.WriteLine(ans);
        }

        public static int NeedleInHaystack(string haystack, string needle)
        {
            int nL = needle.Length;
            if (nL == 0) return 0;
            int hL = haystack.Length;
            if (hL == 0 || hL < nL) return -1;

            //mississippi issip

            for (int i = 0; i <= hL - nL; i++)
            {
                int j = 0;
                // start one-by-one character comparison only if first and last characters of sliding window 
                // match the needle's first and last characters - it improves performance a lot!
                if (haystack[i] == needle[j] && haystack[i + nL - 1] == needle[nL - 1])
                {
                    j++; // as we already checked the first character
                    while (j < nL && haystack[i + j] == needle[j])
                    {
                        j++;
                    }
                    if (j == nL) return i;
                }
            }
            return -1;

        }


    }
