public class NumericStringProblem
{
    public static bool NumericString(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (!char.IsDigit(str[i]))
            {
                return false;
            }
        }
        return true;
    }
}
