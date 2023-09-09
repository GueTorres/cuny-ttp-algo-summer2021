namespace BinarySearchTree
{
    public class binarySearchTree
    {
        var root = new Node();
        public void add(int value){

            const newNode = new Node(value);

            if(!this.root){ //this allows for an addition at the root if it doesn't hold a value 
                this.root = newNode;
                return;
            }

            var currentNode = this.root;
            while(currentNode){
                if(currentNode.value == currentNode.value){ //checks if the value is already there
                    return;
                }
            
                const direction = currentNode.value > newNode.value ? "left" : "right";
                if(!currentNode[direction]){    //if left or right node doesn't exist this is where newNode should be placed
                    currentNode[direction] = newNode;
                    return;
                }

                currentNode = currentNode[direction];   //if left or right does exist then currentNode goes left or right
            }
        }
    }

    public class Node{
        public int value;
        public Node left;
        public Node right;

        public Node(int value){
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
}