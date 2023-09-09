namespace Hg.cuny_ttp_algo_summer2021_1.guevaraTorres.assignments.N2Algorithms
{
    public class selectionSort
    {
        public int[] SortArray(int[] nums) {

        Console.WriteLine(nums[0] + " " + nums[1] + " " + nums[2] + " " + nums[3]);
        for(int j = 0; j < nums.Length - 1; j++){
            int iMin = j;

            for(int i = j + 1; i < nums.Length; i++){
                
                if(nums[i] < nums[iMin]){
                    iMin = i;
                }
            }
            if(iMin != j){
                int temp = nums[j]; 
                nums[j] = nums[iMin];   
                nums[iMin] = temp;  
                Console.WriteLine(nums[0] + " " + nums[1] + " " + nums[2] + " " + nums[3]);
            }
        }    

        return nums;
    }
    }
}