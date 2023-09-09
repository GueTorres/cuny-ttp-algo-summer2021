namespace Hg.cuny_ttp_algo_summer2021_1.guevaraTorres.assignments.BinarySearch
{
    public class binarySearchRecursive
    {
       public static boolean binarySearchRecursive(int[] array, int x, int left, int right){
            if(left > right) return false;  //if left is bigger than right then we have an error and we can't find it
            
            int mid = (left + right) / 2;
            if (array[mid] == x) { return true; }
            else if (array[mid] > x) {
                return binarySearchRecursive(array, x, left, mid - 1);
            } else {
                return binarySearchRecursive(array, x, mid + 1, right);
            }
            
       }

       public static boolean booleanSearchRecursive(int[] array, int x){
        return binarySearchRecursive(array, x, 0, array.length-1);
       } 
    }
}

//if you're searching for the particular index of the target value
//then switch each method's return type to int
//and change line 6 and line 9's return value to -1 and mid respectively