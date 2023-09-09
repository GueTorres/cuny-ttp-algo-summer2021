public class slidingWindow
    {
        public static int findMaxSumSubarray( int[] arr, int k){    //Fixed Length
                int max_Value = int.MinValue;
                int currentRunningSum = 0;

                for(int i = 0; i < arr.Length; i++){
                    currentRunningSum += arr[i];        //add value to current running sum
                    if(i >= k - 1){                     //is current runnning sum greater than what's recorded
                        max_Value = Math.Max(max_Value, currentRunningSum); //compare maxValue to current running sum
                        currentRunningSum -= arr[i - (k - 1)];  //need to subtract the furthest left element from the input array from the current running sum
                    }
                }
                return max_Value;
        }

        public static int smallestSubarray(int targetSum, int[] arr){   //Dynamic Variant
            int minWindowSize = int.MaxValue;
            int currentWindowSum = 0;
            int windowStart = 0;
            for(int windowEnd = 0; windowEnd < arr.Length; windowEnd++){
                currentWindowSum += arr[windowEnd];

                while(currentWindowSum >= targetSum){
                    minWindowSize = Math.Min(minWindowSize, windowEnd - windowStart + 1);
                    currentWindowSum -= arr[windowStart];
                    windowStart++;
                }
            }
            return minWindowSize;
        } 

        public static string longestSubstring(int targetDistinctiveness, string letters){   //Dynamic Variant w/ Auxillary Data Structure
            var distinctCharacters = new Dictionary<char, int>();
            var windowStart = 0;
            var longestSubstring = int.MinValue;

            for(int windowEnd = 0; windowEnd < letters.Length; windowEnd++){

                if(!distinctCharacters.ContainsKey(letters[windowEnd])){
                    distinctCharacters.Add(letters[windowEnd], 1);
                }
                
                else if(distinctCharacters.ContainsKey(letters[windowEnd])){
                    distinctCharacters[letters[windowEnd]]++;
                }

                if(targetDistinctiveness < distinctCharacters.Count){
                    distinctCharacters[letters[windowStart]]--;
                    windowStart++;
                }

                int characterSum = distinctCharacters.Skip(1).Sum( _ => _.Value);

                if(characterSum > longestSubstring){
                    longestSubstring = characterSum;     
                }
                //Console.WriteLine(distinctCharacters.Count + " " + characterSum + " " + longestSubstring);
            }
            return longestSubstring.ToString();
        }

    public int LengthOfLongestSubstring(string s) {         //
        var distinctChars = new Dictionary<char, int>();
        var windowStart = 0;
        var longestSubstring = int.MinValue;
        if(s.Length < 1) return 0;

        for(var windowEnd = 0; windowEnd < s.Length; windowEnd++){

            if(!distinctChars.ContainsKey(s[windowEnd])){
                distinctChars.Add(s[windowEnd], 1);
            }

            else if(distinctChars.ContainsKey(s[windowEnd])){
                distinctChars[s[windowStart]]--;
                windowStart++;
            }

            if(longestSubstring < distinctChars.Count( _ => _.Value > 0)){
                longestSubstring = distinctChars.Count(_ => _.Value > 0);
            }
        }
        return longestSubstring;
    }

    //this solution determines how many swaps are needed by finding the difference between the max number of 
    //contiguous 1s are possible and how many 1s there are in total
    public class Solution {
        public int MinSwaps(int[] nums) {
            int totalOnesWindow = nums.Count(_ => _ == 1); //gives the window size
            int currentOnes = 0;
            int maxOnes = 0;
            int n = nums.Length;
            
            for(int i=0; i< 2*n; i++)
            {
                int idx = i >= n ? i%n : i;         //this is so you can interpret numbers past nums[nums.Length - 1]
                currentOnes += nums[idx];           //increment currentOnes by the current nums index value 

                if(i >= totalOnesWindow){                               //if i is greater than or equal to the window size
                    currentOnes -= nums[(i-totalOnesWindow) % n];       //decrement currentOnes by the index of the modulo of i minus totalOnesWindow by n
                }                                                       //this will keep currentOnes from exceding the number of possible 1s
                                                                            
                maxOnes = Math.Max(currentOnes, maxOnes);               //maxOnes is determined by whether currentOnes or maxOnes is greater
            }

            return totalOnesWindow - maxOnes;                           //by finding the difference can tell you how many swaps are needed
        }
    }
    public static void Main(string[] args){
            Console.WriteLine(findMaxSumSubarray(new int[]{4, 2, 1, 7, 8, 1, 2, 8, 1, 0}, 3));  
            Console.WriteLine(smallestSubarray(8, new int[]{4, 2, 2, 7, 8, 1, 2, 8, 10}));
            Console.WriteLine(longestSubstring(2, "AAAHHIBC"));
    }
}