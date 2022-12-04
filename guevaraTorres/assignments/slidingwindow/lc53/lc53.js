/*

each window is size K
conditon to determine if there's enough elements
remove the first element in the subarray
add the new included element in the sliding window

variables:windowStart, windowEnd, maxSum, current

edge cases: null or 0
*/




function max_subarray_size_k(k, arr) {
  // TODO: Write your code here

  let maxSum = 0;         //Used to determine the maximum between maxSum and current 
  let windowStart = 0;    //Where the window within the array starts
  let current = 0;        //The Sum ranged from windowStart to windowEnd

  if(arr.length == 0 || k > arr.length || k < 1) return 0; //if k or the array are too small

  for(let windowEnd = 0; windowEnd < arr.length; windowEnd++) {     //moves the window through the array
    current += arr[windowEnd];              //adds windowEnd index value to current

    if(windowEnd >= k-1) {                  //if the window is not the proper size, it goes back to increase the size of window and current
    maxSum = Math.max(maxSum, current);     //find max sum of maxSum and current
    current -= arr[windowStart];            //remove windowStart index value from current
    windowStart++;                          //increment windowStart
    }
  }

  return maxSum;

}

console.log(
  `Maximum sum of a subarray of size K: ${max_subarray_size_k(
    0,
    [2, 1, 5, 1, 3, 2]
  )}`
);
console.log(
  `Maximum sum of a subarray of size K: ${max_subarray_size_k(
    3,
    []
  )}`
);
console.log(
  `Maximum sum of a subarray of size K: ${max_subarray_size_k(
    3,
    [2, 1, 5, 1, 3, 2]
  )}`
);
console.log(
  `Maximum sum of a subarray of size K: ${max_subarray_size_k(
    2,
    [2, 3, 4, 1, 5]
  )}`
);

// bruteforce/naive approach
// -----
// let maxSum = 0,
// windowSum = 0;

// for (i = 0; i < arr.length - k + 1; i++) {
//   windowSum = 0;
//   for (j = i; j < i + k; j++) {
//     windowSum += arr[j];
//   }
//   maxSum = Math.max(maxSum, windowSum);
// }
// return maxSum;

// better approach
// -----
// let maxSum = 0,
// windowSum = 0,
// windowStart = 0;

// for (window_end = 0; window_end < arr.length; window_end++) {
//   // add the next element
//   windowSum += arr[window_end];
//   // slide the window, we don't need to slide if we've not hit the required window size of 'k'
//   if (window_end >= k - 1) {
//     maxSum = Math.max(maxSum, windowSum);
//     // subtract the element going out
//     windowSum -= arr[windowStart];
//     // slide the window ahead
//     windowStart += 1;
//   }
// }
// return maxSum;
