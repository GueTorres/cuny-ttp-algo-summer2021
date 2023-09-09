/*
Find the max sum subarray of a fixed size K

Example input:
[4, 2, 1, 7, 8, 1, 2, 8, 1, 0]
*/

namespace Hg.cuny_ttp_algo_summer2021_1.guevaraTorres.assignments.BinarySearch
{
    public class slidingWindow
    {
        public static int findMaxSumSubarray( int[] arr, int k){
                int max_Value = int.MinValue;
                int currentRunningSum = 0;

                for(int i = 0; i < arr.length; i++){
                    currentRunningSum += arr[i];
                    if(i > k - 1){
                        max_Value = Math.Max(max_Value, currentRunningSum);
                        currentRunningSum -= arr[i - (k - 1)];
                    }
                }
                return max_Value;
        }
        public static void main(string[] args){
            System.out.println(findMaxSumSubarray(new int[]{4, 2, 1, 7, 8, 1, 2, 8, 1, 0}, 3));  
        }
    }
}