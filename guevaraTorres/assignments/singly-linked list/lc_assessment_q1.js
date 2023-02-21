// There is a singly-linked list head and we want to delete a node node in it.

// You are given the node to be deleted node. You will not be given access to the first node of head.

// All the values of the linked list are unique, and it is guaranteed that the given node node is not the last node in the linked list.

// Delete the given node. Note that by deleting the node, we do not mean removing it from memory. We mean:

// The value of the given node should not exist in the linked list.
// The number of nodes in the linked list should decrease by one.
// All the values before node should be in the same order.
// All the values after node should be in the same order.
// Custom testing:

// For the input, you should provide the entire linked list head and the node to be given node. node should not be the last node of the list and should be an actual node in the list.
// We will build the linked list and pass the node to your function.
// The output will be the entire list after calling your function.

/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} node
 * @return {void} Do not return anything, modify node in-place instead.
 */

//first we'll need to find the node
//since i do not have access to the first node of head, it will start on head.next
//if we can't find the node, then it is safe to assume it is the first node
//so head will then equal head.next
//this can most likely be searched with a while loop 

//variables: previous, current, next
//edge cases: if node == head
var deleteNode = function(node) {
    
    let current = null;         //initialize current
    let previous = null;        //initialize previous
    let next = null;            //initialize next
    
    //start while loop with condition that as long as head.next does not equal null continue
    while(head !== null){
        next = head.next;       
        previous = current;
        current = next;
        next = current.next;
        
    //after each variable has been assigned a value, we can then determine if the current node is the one to be deleted
        if(current === node){       
            current.next = null;
            previous.next = next;
            return head;
        }
    }
    
    head = head.next;           //edge case
    return head;
};