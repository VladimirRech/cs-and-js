using System.IO;
using System.Text;
using System.Collections.Generic;

public class CheckFiles
{
	public static List<LayoutFile> ReadLayout(string fileName)
	{
		string text = File.ReadAllText(fileName);
		List<LayoutFile> ret = new List<LayoutFile>();

		if (string.IsNullOrEmpty(text))
		{
			return ret;
		}

		string[] lines = text.Split(System.Environment.NewLine);

		// debug
		foreach(string line in lines)
		{
			Console.WriteLine(line);
		}

		return ret;
	}	
}
