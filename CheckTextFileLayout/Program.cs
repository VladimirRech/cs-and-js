// See https://aka.ms/new-console-template for more information
public class Program
{
	public static void Main(string[] args)
	{
		if (args.Length < 2)
		{
			Console.WriteLine("Usage: CheckTextFileLayout <arq1> <arq2>");
			return;
		}

		List<LayoutFile> lines = CheckFiles.ReadLayout(args[0]);
		
		if (!CheckFiles.MatchFile(lines, args[1]))
		{
			Console.WriteLine($"File {args[1]} doesn't match with the layout in {args[0]} file");
		}
		
		Console.WriteLine("Done.");
	}	
}
