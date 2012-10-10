using System.Data;

public class Common
{
	public static bool IsValueType(string dataType)
	{
		bool isValueType = false;
	
		switch (dataType)
		{
			case "bool":
			case "byte":
			case "short":
			case "int":
			case "long":
			case "DateTime":
			case "decimal":
			case "float":
			case "double":
			case "Guid":
				isValueType = true;
				break;
		}
	
		return isValueType;
	}

	public static bool RequiresSize(DbType dataType)
	{
		if (dataType == DbType.AnsiString ||
			dataType == DbType.AnsiStringFixedLength ||
			dataType == DbType.String ||
			dataType == DbType.StringFixedLength)
			return true;
	
		return false;
	}

	public static string GetTypeDefault(string dataType)
	{
		string defaultValue;
	
		switch (dataType)
		{
			case "bit":
			case "bool":
				defaultValue = "false";
				break;
			case "byte":
				defaultValue = "byte.MinValue";
				break;
			case "short":
				defaultValue = "short.MinValue";
				break;
			case "int":
				defaultValue = "int.MinValue";
				break;
			case "long":
				defaultValue = "long.MinValue";
				break;
			case "datetime":
			case "DateTime":
				defaultValue = "DateTime.MinValue";
				break;
			case "decimal":
				defaultValue = "decimal.MinValue";
				break;
			case "float":
				defaultValue = "float.MinValue";
				break;
			case "double":
				defaultValue = "double.MinValue";
				break;
			case "uniqueidentifier":
			case "Guid":
				defaultValue = "Guid.Empty";
				break;
			default:
				defaultValue = "null";
				break;
		}
	
		return defaultValue;
	}
}
