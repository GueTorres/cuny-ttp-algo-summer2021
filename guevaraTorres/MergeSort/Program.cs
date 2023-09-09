using System.Collections;
using System.Collections.Generic;

namespace MergeSort{
    public class MergeSort{
        public static void Main(string [] args){
            var arr = new int[]{4, 2, 1, 7, 8, 1, 2, 8, 1, 0};
            arr = Sort(arr);
            
            foreach(var item in arr){
                Console.WriteLine(item);
            }
        }

        public static int[] Sort(int[] arr){
            if(arr.Length == 1) return arr;
 
            int[] arrOne = arr[..(arr.Length/2)];
            int[] arrTwo = arr[(arr.Length/2)..];
            
            arrOne = Sort(arrOne);
            arrTwo = Sort(arrTwo);

            return Merge(arrOne, arrTwo);
        }

        public static int[] Merge(int[] one, int[] two){
            ArrayList merged = new ArrayList();

            while(two.Length > 0 && one.Length > 0){
                if(one[0] > two[0]){
                    merged.Add(two[0]);
                    two = two.Skip(1).ToArray();
                }
                else{
                    merged.Add(one[0]);
                    one = one.Skip(1).ToArray();
                }
            }
            //At this point either a or b is empty

            while(one.Length > 0){
                merged.Add(one[0]);
                one = one.Skip(1).ToArray();
            }

            while(two.Length > 0){
                merged.Add(two[0]);
                two = two.Skip(1).ToArray();
            }

            return (int[])merged.ToArray(typeof (int));
        }
    }
}
