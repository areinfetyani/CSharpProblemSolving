public class ArrayMaxProblem
{
    public static int ArrayMax(int[] array)
    {
        if (array.Length == 0)
        {
            throw new Exception("The array is empty");
        }
        else if (array.Length == 1)
        {
            return array[0];
        }
        int max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}
