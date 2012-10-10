using System.Linq;

public static class Extensions
{
	public static string ToValidCSharpVariableName(this string variableName)
	{
		//check for reserved words
		var reservedWords = new[] {
			"to", "void"
		};
		
		if (reservedWords.Contains(variableName))
			return "@" + variableName;
		
		return variableName;
	}
}
