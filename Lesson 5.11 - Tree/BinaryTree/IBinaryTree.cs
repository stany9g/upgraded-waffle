namespace BinaryTree
{
    public interface IBinaryTree
    {
        /// <summary>
        /// Inserts value to appropriate place based on impl
        /// </summary>
        /// <param name="value"></param>
        void Insert(int value);

        /// <summary>
        /// Delete value and fix the tree
        /// </summary>
        /// <param name="value"></param>
        void Delete(int value);

        /// <summary>
        /// Search value in the tree and return true if exists and false if it does not
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        bool Search(int value);

        /// <summary>
        /// Return a minimum value from subtree of node
        /// </summary>
        /// <param name="start"></param>
        void SubtreeMin(Node start);

        /// <summary>
        /// Returns an array in PreOrder traverse
        /// </summary>
        /// <returns></returns>
        int[] PreOrderTraversal();

        /// <summary>
        /// Returns an array in InOrder traverse
        /// </summary>
        /// <returns></returns>
        int[] InOrderTraversal();

        /// <summary>
        /// Returns an array in PostOrder traverse
        /// </summary>
        /// <returns></returns>
        int[] PostOrderTraversal();

        /// <summary>
        /// Returns an array in LevelOrder traverse
        /// </summary>
        /// <returns></returns>
        int[] LevelOrderTraversal();
    }
}