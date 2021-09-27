# Words Concatenation

Given a string and a list of words, find all the starting indices of substrings in the given string that are a concatenation of all the given words exactly once without any overlapping of words. It is given that all words are of the same length.

### Example 1
Input: String="catfoxcat", Words=["cat", "fox"]
Output: [0, 3]
Explanation: The two substring containing both the words are "catfox" & "foxcat".

### Example 2:
Input: String="catcatfoxfox", Words=["cat", "fox"]
Output: [3]
Explanation: The only substring containing both the words is "catfox"

### Example 3:
Input: String = "BikeCardCardCardBike", Words = ["Bike","Card"]

Then words can combine like this:
- BikeCard 
- CardBike
Then we search the string and check if it contains the above strings
BikeCard" is found in the beginning of the string, then we take the index which is *0

Then we search for CardBike, which is found at index 12

Then we return [0,12]
