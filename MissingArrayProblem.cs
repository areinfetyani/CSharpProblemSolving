public class MissingArrayProblem
{
    public static int missingArray(int[] array)
    {
        int expectedSum = 0;
        int sum = 0;
        for (int i = 1; i <= array.Length + 1; i++)
        {
            expectedSum += i;
        }
        foreach (int i in array)
        {
            sum += i;
        }
        return expectedSum - sum;
    }
}
