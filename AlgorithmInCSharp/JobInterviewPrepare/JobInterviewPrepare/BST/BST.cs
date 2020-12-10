
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
            else if (value < root.val)
            {
                root.left = Insert(root.left, value);
            }else
            {
                root.right = Insert(root.right, value);
            }
            return root;
        }
        public void Traverse(BSTNode root)
        {
            if(root == null)
            {
                return;
            }
            System.Console.WriteLine($"The root {root.val}");
            Traverse(root.left);
            Traverse(root.right);
        }

        public BSTNode Find (BSTNode root, int value)
        {
            if (root == null) return null;
            if(root.val == value)
            {
                System.Console.WriteLine($"Fidn the value {root.val}");
                return root;
            }
            if(value  < root.val)
            {
                return Find(root.left, value);
            }
            else
            {
                return Find(root.right, value);
            }
        }
        public void PreOrder(BSTNode root)
        {

        }
        public void InOrder(BSTNode root)
        {
            if(root == null)
            {
                return;
            }
        }
        public void Remove(BSTNode root,int value){
            if (root == null) return;
        }
    }
    //iterative. 
    public class BSTree
    {
        public BSTNode Root { get; set; }
        public bool Insert(int value)
        {
            BSTNode before = null, after = this.Root; 
            while(after != null)
            {
                before = after;
                if(value < after.val)
                {
                    after = after.left;
                }
                else if( value > after.val)
                {
                    after = after.right;
                }
                else
                {
                    return false;
                }
            }
            BSTNode newNode = new BSTNode(value);
            if(this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                if(value < before.val)
                {
                    before.left = newNode;
                }
                else
                {
                    before.right = newNode;
                }
            }
            return true;
        }

        public BSTNode Find(int value)
        {
            return this.Find(this.Root, value);
        }

        // Required to upgrade. 
        public BSTNode Find(BSTNode root, int value)
        {
            if(root == null)
            {
                return null;
            }
            if(root.val == value)
            {
                return root;
            }

            return null;
        }
    }
}
