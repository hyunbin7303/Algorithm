namespace JobInterviewPrepare.Searching
{
    public class BinarySearch
    {
        // l is the first index
        // r is the last index.
        public int BinarySearching(int[] arr, int l, int r, int target) // Recursive implementation.
        {
            if (r >= l)
            {
                int mid = l + (r - 1) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                if (arr[mid] > target)
                {
                    return BinarySearching(arr, l, mid - 1, target);
                }
                return BinarySearching(arr, mid + 1, r, target);
            }
            return -1;
        }
        public int BinarySearchTesting(int[] arr, int l, int r, int target)
        {
            int mid = (l + r) / 2;
            if (arr[mid] == target)
            {
                return mid;
            }
            else if (l >= r)
            {
                return -1;
            }
            else if (target < arr[mid])
            {
                return BinarySearchTesting(arr, l, mid, target);
            }
            else
            {
                return BinarySearchTesting(arr, mid, r, target);
            }
        }



        // find min and max value in Binary Search tree.
        // last left child node of a subtree beginning with the left child of the root node. On the other hand, the largest value in a BST
        // is found at the last right child node of a subtree beginning with the right child of the root node. 
        public int BST_FindMinAndMax(int[] arr, int l, int r)
        {
            return 0;
        }



        //https://www.csharpstar.com/csharp-program-to-find-min-and-max-in-binary-search-tree/
        //https://www.csharpstar.com/csharp-program-to-count-number-of-words-in-a-string/
    }
}
