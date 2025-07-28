class BinarySearchProblem
{
    public static int BinarySearchIterative(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (array[mid] > target)
            {
                right = mid - 1;
            }
            else if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                return mid;
            }
        }
        return -1; 
    }

    public static int BinarySearchRecursive(int[] array, int target, int left, int right)
    {
      
        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (array[mid] > target)
            {
                return BinarySearchRecursive(array, target, left, mid-1);
            }
            else if (array[mid] < target)
            {
                return BinarySearchRecursive(array, target, mid + 1 , right);
            }
            else
            {
                return mid;
            }
        }
        return -1;
    }

}