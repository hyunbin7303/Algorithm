
namespace JobInterviewPrepare
{
    public class BSTNode
    {
        public int val;
        public BSTNode left, right;
        public BSTNode(int val)
        {
            this.val = val;
        }
    }
    // Search - Searches a n element in a tree.
    // Insert - Inserts an element in a tree.
    // Pre-order traversal - Traverses a tree in a pre-order manner.
    // In-order traversal - Traverses a tree in an in-order manner.
    public class BST
    {
        public BSTNode Search(int value)
        {
            return null;
        }
        public BSTNode Insert(BSTNode root, int value)
        {
            if(root == null)
            {
                root = new BSTNode(value);
            }
            else if (root.val > value)
            {
                root.right = Insert(root.right, value);
            }else
            {
                root.left = Insert(root.left, value);
            }
            return root;
        }
        public void Traverse(BSTNode root)
        {
            if(root == null)
            {
                return;
            }
            Traverse(root.left);
            Traverse(root.right);
        }
        public void PreOrder(BSTNode root)
        {

        }
        public void InOrder(BSTNode root)
        {
        }
        public void Remove(int value){
        }
        public BSTNode Remove(BSTNode root,int value) { return null; }
    }
}
