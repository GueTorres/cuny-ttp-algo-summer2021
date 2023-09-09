using System;

namespace LinkedList{
    public class LinkedList<T> : IEnumerable<T> where T : class{
        Node head = new Node(6);
        Node nodeB = new Node(3);
        Node nodeC = new Node(4);
        Node nodeD = new Node(2);
        Node nodeE = new Node(1);

        //create a link
        head.next = nodeB;
        nodeB.next = nodeC;
        nodeC.next = nodeD;
        nodeD.next = nodeE;

        //this manual way of doing this is inefficient
        //better to make another class to link the linked list together

        static int countNodes(Node head){
            int count = 1;
            
            Node current = head;
            //if(head.next == null) return count;

            while(current != null){
                current = current.next;
                count++;
            }

            return count;
            
        }
    }
    class Node{
        int data;
        Node next;
        Node(int data) { this.data = data};  
    }
}