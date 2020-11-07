using System.Collections.Generic;

namespace BinaryTreeFun
{
    public class BinaryTree
    {
        public class BinaryTreeNode
        {
            public int Value { get; }

            public BinaryTreeNode Left { get; private set; }

            public BinaryTreeNode Right { get; private set; }

            public BinaryTreeNode(int value)
            {
                Value = value;
            }

            public BinaryTreeNode InsertLeft(int leftValue)
            {
                Left = new BinaryTreeNode(leftValue);
                return Left;
            }

            public BinaryTreeNode InsertRight(int rightValue)
            {
                Right = new BinaryTreeNode(rightValue);
                return Right;
            }

        }


        public static bool IsBalanced(BinaryTreeNode root)
        {
            return false;
        }

        public static bool IsBinarySearchTree(BinaryTreeNode root)
        {
            return false;
        }

        public static int FindSecondLargest(BinaryTreeNode root)
        {
            return 0;
        }
    }


}