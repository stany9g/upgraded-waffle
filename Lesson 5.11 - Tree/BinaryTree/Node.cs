using System.Collections;

namespace BinaryTree
{
    public class Node
    {
        public int Value;
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }


        public Node(int value, Node leftChild = null, Node rightChild = null)
        {
            Value = value;
            LeftChild = leftChild;
            RightChild = rightChild;
        }
    }
}