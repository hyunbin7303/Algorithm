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
    }
}
