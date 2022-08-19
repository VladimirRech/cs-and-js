// Change neighbor chars
namespace study_hello.classes
{
    public class SwapChar
    {
        public void Swap()
        {
            Console.Write("Pleas enter a string:");
            string str = Console.ReadLine();
            int i = 0;
            string s = "";

            while (i < str.Length)
            {
                if (i < (str.Length - 1))
                {
                    s += str[i + 1];
                    s += str[i];
                }
                else
                {
                    s += str[i];
                }

                i += 2;
            }

            Console.WriteLine(s);
        }
    }
}