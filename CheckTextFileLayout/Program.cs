// See https://aka.ms/new-console-template for more information
public class Program
{
	public static void Main(string[] args)
	{
		if (args.Length < 2)
		{
			Console.WriteLine("Uso: CheckTextFileLayout <arq1> <arq2>");
			return;
		}

		List<LayoutFile> lines = CheckFiles.ReadLayout(args[0]); 
	}	
}
