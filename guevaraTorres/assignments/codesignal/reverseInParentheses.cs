namespace Hg.cuny_ttp_algo_summer2021_1.guevaraTorres.assignments.codesignal
{
    public class reverseInParentheses
    {
       //need to find the parentheses within the string so we can determine what to reverse 
        //we may need to implement with recursion in mind 
        //perhaps recursing when it reaches a '(' and then pop up on a ')'
        //after the parentheses are found, we can reverse the substring with a for loop
        public string solution(string inputString) {

            while(inputString.Contains("("))
            {
                int i = inputString.LastIndexOf("(");   
                //reports the last index where "(" occurs
                var s = new string(inputString.Skip(i + 1).TakeWhile(x => x != ')').Reverse().ToArray());
                //Copies the characters in this instance to a Unicode character array.
                //Inverts the order of the elements in a sequence.
                //Returns elements from a sequence as long as they do not include a ')'.
                //Bypasses every element before the integer i and returns the remaining elements.
                //Makes a new string with the result
                var t = "(" + new string(s.Reverse().ToArray()) + ")";
                //Copies the characters in this instance to a Unicode character array.
                //Inverts the order of the elements in a sequence.
                //Makes a new string that is encapsulated by a '(' and ')'
                inputString = inputString.Replace(t, s);
                //Replace string t with string s
            }

            return inputString;
        }
    }
}