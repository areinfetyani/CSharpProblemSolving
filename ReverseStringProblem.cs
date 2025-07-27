using System.Text;

public class ReverseStringProblem
{
    public static string reverseString(string str)
    {
        if (str.Length < 2)
        {
            return str;
        }
        StringBuilder newString = new StringBuilder(str.Length);
        for (int i = str.Length - 1; i >= 0; i--)
        {
            newString.Append(str[i]);
        }

        return newString.ToString();
    }
}
