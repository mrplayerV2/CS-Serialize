using Newtonsoft.Json;

public class SerializeClass
{
	public string Serialize(bool ident)
	{
		try
		{
			return JsonConvert.SerializeObject(this, ident ? Formatting.Indented : Formatting.None);
		}
		catch
		{
			return string.Empty;
		}
	}
}
