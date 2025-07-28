public class SubsetsOfSetProblem
{
    public static List<List<int>> SubsetsOfSet(int[] array)
    {
        List<List<int>> result = new List<List<int>>();
        List<int> subset = new List<int>(); // this is the temporary working subset
        Dfs(array, 0, subset, result);
        return result;
    }

    private static void Dfs(int[] array, int i, List<int> subset, List<List<int>> result)
    {
        if (i >= array.Length)
        {
            result.Add(new List<int>(subset));
            return;
        }

        // Include array[i]
        subset.Add(array[i]);
        Dfs(array, i + 1, subset, result);

        // Exclude array[i]
        subset.RemoveAt(subset.Count - 1);
        Dfs(array, i + 1, subset, result);
    }
}
