public class FirstNonRepeatingCharacterProblem
{
	public static char firstNonrepeatingCharacter(string str)
	{
		char nonrepeated = '\0';
		if (str.Length == 0)
		{
			return nonrepeated;
		}
		if (str.Length == 1)
		{
			return str[0];
		}
		Dictionary<char, int> characters = new Dictionary<char, int>();
		foreach (char c in str)
		{
			if (characters.ContainsKey(c))
			{
				characters[c]++;
			}
			else
			{
				characters.Add(c, 1);
			}
		}
		foreach (char c in characters.Keys)
		{
			if (characters[c] == 1)
			{
				nonrepeated = c;
				break;
			}
		}
		return nonrepeated;
	}
}
