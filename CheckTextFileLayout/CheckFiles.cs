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
		CreateList(ret, lines);
		return ret;
	}
	
	public static bool MatchFile(List<LayoutFile> layout, string matchFileName)
	{
		string[] lines = File.ReadAllText(matchFileName)
			.Split(System.Environment.NewLine);
		
		if (lines == null || lines.Length == 0)
			return false;
		
		// Debugging
		Console.WriteLine("Debugging"); 
		foreach(var item in lines) Console.WriteLine(item);
		return false;
	}
	
	private static string[] fileLines(string matchFileName)
	{
		return new string[] { };
	}
	
	private static bool ReadLines(string[] lines, List<LayoutFile> layout)
	{
		return false;
	} 
	
	private static void CreateList(List<LayoutFile> lst, string[] lines)
	{
		for (int i = 1; i < lines.Length; i++)
		{
			lst.Append(
				new LayoutFile {
					Code = lines[i].Split(';')[0],
					Length = Convert.ToInt32(lines[i].Split(';')[1])
				}
			);
		}
	}
}
