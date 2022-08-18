namespace study_hello.classes
{
    // Invert 2 numbers
    // Doesn't do any validation
    public class InvertNumbers
    {
        internal bool Entry() 
        {
            Console.Write("n1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("n2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            return DoInvert(n1, n2);
        }

        bool DoInvert(int n1, int n2)
        {
            Console.WriteLine($"Original:{n1} {n2}");
            n1 += n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine($"Final: {n1} {n2}");
            Console.ReadLine();

            return true;
        }
    }
}