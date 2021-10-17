using System;
using System.Collections.Generic;

namespace algo{
    class LongestSubstring{
        
        public int longestSubstringBruteForce (string Str, int K){
            if(Str.Length < K){
                return Str.Length;
            }  

            // Dictionary<key,value>
            Dictionary<int, char> window = new Dictionary<int, char>();
            int distinct = 0;


            for(int i=0; i< Str.Length; i++) {
                if(!window.ContainsValue(Str[i])){
                    distinct += 1;
                }
                window.Add(i, Str[i]);
                if(distinct == K){
                    break;
                }                
            }
            int windowLength = window.Count;
            int keyToShrink = 0;

            for(int j = windowLength; j< Str.Length; j++){
                if(!window.ContainsValue(Str[j])){
                    window.Remove(keyToShrink);
                    keyToShrink+=1;
                }

                window.Add(j, Str[j]);

            }
            return windowLength;
        }
    }
}