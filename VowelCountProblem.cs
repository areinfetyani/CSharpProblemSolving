public class VowelCountProblem
{
    public static int vowelCount(string str)
    {
        int count = 0;
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        foreach (char c in str.ToLower())
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }
        return count;
    }
}
