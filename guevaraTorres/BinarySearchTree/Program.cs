using System;
using System.Collections.Generic;
// Class containing left and right
// child of current node and key value
public class NaiveNode {
	public int data;
	public NaiveNode left, right;
	public NaiveNode(int item)
	{
		data = item;
		left = right = null;
	}
}

class BFSNaive {				//Time Complexity: O(N2), where N is the number of nodes in the skewed tree.
								//Auxiliary Space: O(1) If the recursion stack is considered the space used is O(N).

	// Root of the Binary Tree
	public NaiveNode root;

	public void BinaryTree() { root = null; }

	// Function to print level order
	// traversal of tree
	public virtual void printLevelOrder()
	{
		int h = height(root);
		int i;
		for (i = 1; i <= h; i++) {
			printCurrentLevel(root, i);
		}
	}

	// Compute the "height" of a tree --
	// the number of nodes along the longest
	// path from the root node down to the
	// farthest leaf node.
	public virtual int height(NaiveNode root)
	{
		if (root == null) {
			return 0;
		}
		else {

			// Compute height of each subtree
			int lheight = height(root.left);		//this recursion will return the height of rheight + 1
			int rheight = height(root.right);		//this recursion will return the heitht of lheight + 1

			// use the larger one
			if (lheight > rheight) {
				return (lheight + 1);
			}
			else {
				return (rheight + 1);
			}
		}
	}

	// Print nodes at the current level
	public virtual void printCurrentLevel(NaiveNode root,
										int level)
	{
		if (root == null) {
			return;
		}
		if (level == 1) {
			Console.Write(root.data + " ");
		}
		else if (level > 1) {
			printCurrentLevel(root.left, level - 1);
			printCurrentLevel(root.right, level - 1);
		}
	}

	
}

// Iterative Queue based C# program
// to do level order traversal
// of Binary Tree


// Class to represent Tree node
public class CleverNode {
	public int data;
	public CleverNode left, right;

	public CleverNode(int item)
	{
		data = item;
		left = null;
		right = null;
	}
}

public class RecurseNode{
	public int data;
	public RecurseNode left, right;

	public RecurseNode(int item){
		data = item;
		left = null;
		right = null;
	}
}

// Class to print Level Order Traversal
public class DFSInOrder{
		public NaiveNode root;
		public DFSInOrder() { root = null; }

		//Given a tree, print its nodes in order
		public void printInOrder(NaiveNode node) {
			if(node == null) {
				return;
			}

			//First recur on left child
			printInOrder(node.left);

			//Then print the data of node
			Console.Write(node.data + " ");

			//Now recur on right child
			printInOrder(node.right);
		}

		//wrappers over above recursive functions
		public void printInOrder() { printInOrder(root); }
}

public class DFSPreOrder{
	//Visit the root.
	//Traverse the left subtree(left => subtree)
	//Traverse the right subtree(right => subtree)

	//Use of preorder is for making a copy of the tree. Preorder traversal is also to get prefix expressions on an expression tree.

	//Root of Binary Tree
	public NaiveNode root;

	public DFSPreOrder() { root = null; }

	//Given a binary tree, print its nodes in preorder
	public void printPreOrder(NaiveNode node) {
		if(node == null) return;

		//First print data of node
		Console.Write(node.data + " ");

		//Then recur on left subtree
		printPreOrder(node.left);

		//Now recur on right subtree
		printPreOrder(node.right);
	}
	public void printPreOrder() { printPreOrder(root); } //need this wrapper so that you can call the method using the object that calls it
}
// Class to count full nodes of Tree 
public class BinaryTree 
{ 
  /*
  	1) Create an empty Queue Node and push root node to Queue.
	2) Do following while nodeQeue is not empty.
   		a) Pop an item from Queue and process it.
      	a.1) If it is full node then increment count++.
   		b) Push left child of popped item to Queue, if available.
   		c) Push right child of popped item to Queue, if available.
  */
    public NaiveNode root; 

	public RecurseNode recurseRoot;
  
    /* Function to get the count of full Nodes in 
    a binary tree*/
    public int getFullCountIterative() 
    { 
        // If tree is empty 
        if (root == null) 
        return 0; 
          
        // Initialize empty queue. 
        var queue = new Queue<NaiveNode>(); 
          
        // Do level order traversal starting from root 
        queue.Enqueue(root); 
          
        int count = 0; // Initialize count of full nodes 
        while (queue.Count != 0) 
        { 
  
            NaiveNode temp = queue.Dequeue(); 
            if (temp.left != null && temp.right != null) 
            count++; 
  
            // Enqueue left child 
            if (temp.left != null) 
            { 
                queue.Enqueue(temp.left); 
            } 
  
            // Enqueue right child 
            if (temp.right != null) 
            { 
                queue.Enqueue(temp.right); 
            } 
        } 
        return count; 
    }

	public int getFullCountRecursive(RecurseNode node){
		if(recurseRoot == null) return 0;

		int res = 0;
		if(recurseRoot.left != null && recurseRoot.right != null) res++;

		res += (getFullCountRecursive(recurseRoot.left) + getFullCountRecursive(recurseRoot.right));

		return res;
	}

	/*
	Helper function that allocates a new Node with the given data and NULL left and right pointers.
	*/

	// static NaiveNode node(int data){
	// 	var node = new NaiveNode();
	// 	node.data =  data;
	// 	node.left = null;
	// 	node.right = null;
	// 	return node;
	// }
	public int getFullCountRecursive(){ getFullCountRecursive(recurseRoot); }
}
public class DFSPostOrder{
	//Traverse the left subtree(left => subtree)
	//Traverse the right subtree(right => subtree)
	//Visit the root

	//Root of Binary Tree
	public NaiveNode root;

	public DFSPostOrder (){ root = null; }

	//Given a binary tree, print its nodes according to the "bottom-up" postorder traversal.
	public void printPostOrder(NaiveNode node) {
		if(node == null) return ;

		//First recur on left subtree
		printPostOrder(node.left);

		//Then recur on right subtree
		printPostOrder(node.right);

		//Now deal with the node
		Console.Write(node.data + " ");
	}

	public void printPostOrder() { printPostOrder(root); }
}
public class BFSClever {		//Time Complexity: O(N) where N is the number of nodes in the binary tree.
								//Auxiliary Space: O(N) where N is the number of nodes in the binary tree.

	CleverNode root;

	// Given a binary tree. Print
	// its nodes in level order using
	// array for implementing queue
	void printLevelOrder()
	{
		Queue<CleverNode> queue = new Queue<CleverNode>();
		queue.Enqueue(root);
		while (queue.Count != 0) {

			CleverNode tempNode = queue.Dequeue();
			Console.Write(tempNode.data + " ");

			// Enqueue left child
			if (tempNode.left != null) {
				queue.Enqueue(tempNode.left);
			}

			// Enqueue right child
			if (tempNode.right != null) {
				queue.Enqueue(tempNode.right);
			}
		}
	}

	

	// Driver code
	public static void Main()
	{
		// Creating a binary tree and entering
		// the nodes
		BFSClever tree_level = new BFSClever();
		tree_level.root = new CleverNode(1);
		tree_level.root.left = new CleverNode(2);
		tree_level.root.right = new CleverNode(3);
		tree_level.root.left.left = new CleverNode(4);
		tree_level.root.left.right = new CleverNode(5);

		Console.Write("Level order traversal of binary tree is ");
		tree_level.printLevelOrder();

		BFSNaive tree = new BFSNaive();
		tree.root = new NaiveNode(1);
		tree.root.left = new NaiveNode(2);
		tree.root.right = new NaiveNode(3);
		tree.root.left.left = new NaiveNode(4);
		tree.root.left.right = new NaiveNode(5);

		Console.Write("\nLevel order traversal of binary tree is ");
		tree.printLevelOrder();

		//DFS InOrder function call
		DFSInOrder binTree = new DFSInOrder();
		binTree.root = new NaiveNode(1);
		binTree.root.left = new NaiveNode(2);
		binTree.root.right = new NaiveNode(3);
		binTree.root.left.left = new NaiveNode(4);
		binTree.root.left.right = new NaiveNode(5);	

		Console.Write("\nInorder traversal of binary tree is ");
		binTree.printInOrder();

		DFSPreOrder preTree = new DFSPreOrder();
		preTree.root = new NaiveNode(1);
		preTree.root.left = new NaiveNode(2);
		preTree.root.right = new NaiveNode(3);
		preTree.root.left.left = new NaiveNode(4);
		preTree.root.left.right = new NaiveNode(5);	

		Console.Write("\nPreorder traversal of binary tree is ");
		preTree.printPreOrder();

		DFSPostOrder postTree = new DFSPostOrder();
		postTree.root = new NaiveNode(1);
		postTree.root.left = new NaiveNode(2);
		postTree.root.right = new NaiveNode(3);
		postTree.root.left.left = new NaiveNode(4);
		postTree.root.left.right = new NaiveNode(5);	

		Console.Write("\nPreorder traversal of binary tree is ");
		postTree.printPostOrder();

		/* 2 
        / \ 
        7 5 
        \ \ 
        6 9 
        / \ / 
        1 11 4 
        Let us create Binary Tree as shown 
        */
        BinaryTree tree_count = new BinaryTree(); 
        tree_count.root = new NaiveNode(2); 
        tree_count.root.left = new NaiveNode(7); 
        tree_count.root.right = new NaiveNode(5); 
        tree_count.root.left.right = new NaiveNode(6); 
        tree_count.root.left.right.left = new NaiveNode(1); 
        tree_count.root.left.right.right = new NaiveNode(11); 
        tree_count.root.right.right = new NaiveNode(9); 
        tree_count.root.right.right.left = new NaiveNode(4); 
  
  		BinaryTree tree_recurse = new BinaryTree(); 
        tree_recurse.recurseRoot = new RecurseNode(2); 
        tree_recurse.recurseRoot.left = new RecurseNode(7); 
        tree_recurse.recurseRoot.right = new RecurseNode(5); 
        tree_recurse.recurseRoot.left.right = new RecurseNode(6); 
        tree_recurse.recurseRoot.left.right.left = new RecurseNode(1); 
        tree_recurse.recurseRoot.left.right.right = new RecurseNode(11); 
        tree_recurse.recurseRoot.right.right = new RecurseNode(9); 
        tree_recurse.recurseRoot.right.right.left = new RecurseNode(4);
		
        Console.WriteLine("\nCount of full nodes in a binary tree is " + tree_count.getFullCountIterative()); 
		Console.WriteLine("\nCount of full nodes in a binary tree is " + tree_recurse.getFullCountRecursive()); 
	}
}

// This code contributed by PrinciRaj1992

// This code is contributed by Shrikant13


