/**
 * @param {string} s
 * @return {number}
    Need to find the longest non-repeating substring.
    So, a comparison of the previous substring has to be made.
    But a subarray of non-repeating characters has to be reached first.
    Therefore, strLength has to be incremented and 'current' increased by windowEnd's value until
    the 'current' subarray has reached the target sum while facilitating to a sliding window pattern.
    Then change the minLength to the value of the stringLength.

    variables: strLength, current, minLength, windowStart, windowEnd

    edge cases: null or 0 for sum and/or array
 */
    var lengthOfLongestSubstring = function(s) {
        let minLength = s.length;                       //minLength starts at s.length
        let strLength = 0;                              //the curernt length that will satisfy the subarray requirements
        let windowStart = 0;                            //the sliding window needs to start at the s strings first index
        let current = String.Empty;                     //the current substring should be empty   
        let reached = false;                            //flag -- found the longest non-repeating substring yet?

        if(s.length == 0 || s == String.Empty || s == null) return -1;        //if string is empty or null, it will fail

        for(let windowEnd = 0; windowEnd < s.length; windowEnd++){  //the sliding window increments, starting from s[0]
            const rightChar = s[windowEnd];             //character at the end of the window 
            if (current.length <= s.length) sumLength++;//if the current length is less than s length, increment sumLength
            if(!(rightChar in current)){                //if the character is not a repeat, add it to the substring
                current.concat(rightChar);              //adds the non-repeating char to the string                              
                //move windowStart 
            }


            

        }
    };