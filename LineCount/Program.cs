// See https://aka.ms/new-console-template for more information

var ob = new FileLinesApp("no_repeated_lines.txt");
Console.WriteLine("Processou arquivo? {0}", ob.Process() ? "Sim" : "Não");
