using CodeSmith.Engine;
using System.ComponentModel;
using SchemaExplorer;

public abstract class BaseTemplate : CodeTemplate
{
	protected BaseTemplate() : base()
	{
		Response.IndentValue = "\t";
	}
	
	public string Namespace	{ get; set; }
	//public string DatabaseExceptionNamespace { get; set; }

	protected void BeginNamespace()
	{
		if (!string.IsNullOrEmpty(Namespace)) {
			Response.WriteLine("namespace " + Namespace);
			Response.WriteLine("{");
			Response.Indent();
		}
	}
	
	protected void EndNamespace()
	{
		if (!string.IsNullOrEmpty(Namespace)) {
			Response.Unindent();
			Response.WriteLine("}");
		}
	}
}
