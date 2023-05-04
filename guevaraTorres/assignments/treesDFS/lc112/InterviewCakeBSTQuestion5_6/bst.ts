//provide the 2nd largest element with provided bst
class BinaryTreeNode {
    value: any | number | null;
    left: BinaryTreeNode | null;
    right: BinaryTreeNode | null;

    constructor(value){
        this.value = value;
        this.left = null;
        this.right = null;
    }

    public insertLeft(value) {
        this.left = new BinaryTreeNode(value);
        return this.left;
    }

    public insertRight(value) {
        this.right = new BinaryTreeNode(value);
        return this.right;
    }
}

function solution(btn: BinaryTreeNode): number{
    return find2nd(btn, btn);
}

function find2nd(btn: BinaryTreeNode, parent: BinaryTreeNode): number{ 

    if(btn.left && !btn.right) return btn.left.value; //if there is a left and no right, return btn.left
    if(btn.right) return find2nd(btn.right, btn);    //if right E tf recurse
    if(btn.left && btn.right) return find2nd(btn.right, btn);    //complete => recurse
    if(!btn.left && !btn.right) {
        return parent.value;
    }

    return find2nd(btn,parent);

}

var root = new BinaryTreeNode(10)
root.left = new BinaryTreeNode(7)
root.right = new BinaryTreeNode(23)
root.left.left = new BinaryTreeNode(1)
root.right.left = new BinaryTreeNode(15)
root.right.right = new BinaryTreeNode(30)
console.log(`2nd largest element: ${solution(root)}`)

var root = new BinaryTreeNode(47)
root.left = new BinaryTreeNode(4)
root.right = new BinaryTreeNode(77)
root.left.left = new BinaryTreeNode(2)
root.right.left = new BinaryTreeNode(9)
root.right.right = new BinaryTreeNode(154)
console.log(`2nd largest element: ${solution(root)}`)