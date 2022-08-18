// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var obj = new Sample { Id = 1, Name = "Sample Class", Removed = 0, CreationDate = DateTime.Now};
Console.WriteLine("Sammple Class:\r\n\t {0}", obj.ToString());

public class Sample
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Removed { get; set; }
    public DateTime CreationDate { get; set; }
}