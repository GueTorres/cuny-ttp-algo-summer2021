namespace Hg.cuny_ttp_algo_summer2021_1.guevaraTorres.assignments.BinarySearch
{
    public class binarySearchIterative.com
    {
        public static boolean binarySearchIterative(int[] array, int x){
            int left = 0;
            int right = array.length - 1;
            while (left <= right){
                int mid = left + ((right - left) / 2);
                if (array [mid] == x){
                    return true;
                } else if (x < array[mid]){
                    right = mid - 1;
                } else{
                    left = mid + 1;
                }
            }
            return false;
        }
    }
}

//if you're searching for the particular index of the target value
//then switch each method's return type to int
//and change line 18 and line 11's return value to -1 and mid respectively