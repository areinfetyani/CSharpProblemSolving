public class SecondMaxProblem
{
    public static int SecondMax(int[] array)
    {
        if (array.Length < 2)
        {
            throw new Exception("The array contains less than two number");
        }
        else if (array.Length == 2)
        {
            return Math.Min(array[0], array[1]);
        }
        int max = int.MinValue;
        int secondMax = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                secondMax = max;
                max = array[i];
            }
            else if (array[i] > secondMax)
            {
                secondMax = array[i];
            }
        }
        return secondMax;
    }
}
