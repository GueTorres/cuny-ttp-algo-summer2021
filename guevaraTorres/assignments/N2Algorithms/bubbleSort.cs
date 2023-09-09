namespace Hg.cuny_ttp_algo_summer2021_1.guevaraTorres.assignments.N2Algorithms
{
    public class bubbleSort
    {
        public int[] SortArray(int[] nums) {
        
        for(int i = 1; i < nums.Length; i++){
            for(int j = 0; j < nums.Length - 1; j++){
                if(nums[j] > nums[j + 1]){
                    int temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                    Console.WriteLine(temp);
                }
            }
        }

        return nums;
    }
}