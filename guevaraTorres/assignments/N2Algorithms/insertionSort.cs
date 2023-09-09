namespace Hg.cuny_ttp_algo_summer2021_1.guevaraTorres.assignments.Insertion_Sort
{
    public class insertionSort
    {
       public class Solution {
            public int[] SortArray(int[] nums) {
                
                for(int i = 0; i < nums.Length; i++){
                    int j = i;
                    while(j > 0 && nums[j - 1] > nums[j]){
                        int temp = nums[j];
                        nums[j] = nums[j - 1];
                        nums[j - 1] = temp;
                        j = j - 1;
                    }
                }

                return nums;
            }
        }
    }
}