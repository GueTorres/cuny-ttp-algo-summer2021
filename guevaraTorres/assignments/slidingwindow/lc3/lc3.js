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

      let chars = new Set();          //map of substring
      let windowStart = 0;            //start of window
      let maxLength = 0;              //maxLength has yet to be assessed

      if (s.length === 0 || s.length === null) return 0; //edge case
      if (s.length === 1) return 1;                      //edge case

      for (let windowEnd = 0; windowEnd < s.length; windowEnd++) {    //the sliding window increments, starting from s[0]

        while (chars.has(s[windowEnd])) {     //check if any occurences of the current character
            chars.delete(s[windowStart])      //if so, delete
            windowStart++;                    //move window up
        }
        chars.add(s[windowEnd]);              //adds current char to window
        maxLength = Math.max(maxLength, windowEnd - windowStart + 1)    //determine max length
      }
      return maxLength;                       //sends maxLength
    };

    console.log(
        `Maximum length of a non-repeating subarray: ${lengthOfLongestSubstring(
            "abcabcbb"
        )}`
      );
      console.log(
        `Maximum length of a non-repeating subarray: ${lengthOfLongestSubstring(
            "bbbbb"
        )}`
      );
      console.log(
        `Maximum length of a non-repeating subarray: ${lengthOfLongestSubstring(
            "pwwkew"
        )}`
      );
      console.log(
        `Maximum length of a non-repeating subarray: ${lengthOfLongestSubstring(
          ""
        )}`
      );