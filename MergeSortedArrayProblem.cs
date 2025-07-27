public class MergeSortedArrayProblem
{
    public static int[] MergeSortedArray(int[] array1, int[] array2)
    {
        if (array1 == null)
        {
            return array2;
        } else if (array2 == null)
        {
            return array1;
        }
        int m = array1.Length;
        int n = array2.Length;
        int[] mergedArray = new int[m + n];
        int i = 0, j = 0, k = 0;
        while (i < m && j < n)
        {
            if (array1[i] <= array2[j])
            {
                mergedArray[k++] = array1[i++];
            }
            else
            {
                mergedArray[k++] = array2[j++];
            }
        }
        while (i < m)
        {
            mergedArray[k++] = array1[i++];
        }
        while (j < n)
        {
            mergedArray[k++] = array2[j++];
        }
        return mergedArray;
    }
      
}
