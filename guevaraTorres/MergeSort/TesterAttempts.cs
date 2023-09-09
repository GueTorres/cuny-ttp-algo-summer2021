namespace MergeSort
{
    public class TesterAttempts
    {
       public int[] SortArray(int[] nums) {

        if(nums.Length == 1) return nums;
        Console.WriteLine(nums[0] + " " + nums[1] + " " + nums[2] + " " + nums[3]);
        for(int j = 0; j < nums.Length - 1; j++){
            int iMin = j;

            for(int i = j + 1; i < nums.Length; i++){
                
                if(nums[i] < nums[iMin]){
                    iMin = i;
                }
            }
            if(iMin != j){
                int temp = nums[j]; //temp = 2
                nums[j] = nums[iMin];   //nums[j] = 3
                nums[iMin] = temp;  //nums[iMin] = 2
                Console.WriteLine(nums[0] + " " + nums[1] + " " + nums[2] + " " + nums[3]);
            }
        }    

        return nums;
        }

    }
}