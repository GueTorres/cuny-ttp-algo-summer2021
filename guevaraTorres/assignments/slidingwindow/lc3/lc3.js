/**
 * @param {string} s
 * @return {number}
    Need to find the longest consecutive non-repeating substring.
    So, a comparison of the previous substring has to be made.
    But a subarray of consecutive non-repeating characters has to be reached first.
    Therefore, if a non-repeating char is found, it should be appended to temp.
    Once a char is added to temp, if temp.length is greater than maxLength and current.Length, make maxLength equal to temp.Length and current equal to temp.
    Additionally, strLength has to be incremented whenever 'current' appends another character until
    the 'current' subarray has found the maximum subarray size while following a sliding window pattern.
    Then, if current is greater than maxLength, change the maxLength to the value of strLength.

    variables: strLength, current, minLength, windowStart, windowEnd

    edge cases: null or 0 for sum and/or array
 */
    var lengthOfLongestSubstring = function(s) {
        let maxLength = 0;                       //maxLength starts at 0 to represent the lack of a non-repeating subarray
        let windowStart = 0;                     //the sliding window needs to start at the s string's first index
        let characterFrequency = {};             //will record character frequency in order to determine non-repeating characters
        let current = {};              //the current substring should be empty 
        let temp = {};                 //the temp substring should be empty

        if(s.length == 0 || s == String.Empty || s == null) return -1;      //if s string is empty or null, it will fail

        for(let windowEnd = 0; windowEnd < s.length; windowEnd++){  //the sliding window increments, starting from s[0]
            const rightCharacter = s[windowEnd];          //character at the start of the String

            if(!(rightCharacter in characterFrequency)) {   //checks to see if character has occured
                characterFrequency[rightCharacter] = 1;     //add the character if it hasn't 
            }
            //shrink the sliding window until there are only 2 character types in the frequency dictionary
            while(Object.keys(characterFrequency)) {
                const leftCharacter = s[windowStart]; //character at the start of the window

                characterFrequency[leftCharacter]--; //decrement character occurence

                if(characterFrequency[leftCharacter] === 0 ) { //check if any occurences of the starting character in the frequency dictionary
                delete characterFrequency[leftCharacter];  //if not, remove character type
                }

                windowStart++;      //move window up
            }

            maxLength = Math.max(maxLength, windowEnd - windowStart + 1);   //determine max length
            
        }
        let substring = Array.from(current)
        return substring;                                   //return the largest subarray
    };

    console.log(
        `Maximum sum of a subarray of size K: ${lengthOfLongestSubstring(
            "abcabcbb"
        )}`
      );
      console.log(
        `Maximum sum of a subarray of size K: ${lengthOfLongestSubstring(
            "bbbbb"
        )}`
      );
      console.log(
        `Maximum sum of a subarray of size K: ${lengthOfLongestSubstring(
            "pwwkew"
        )}`
      );
      console.log(
        `Maximum sum of a subarray of size K: ${lengthOfLongestSubstring(
          ""
        )}`
      );