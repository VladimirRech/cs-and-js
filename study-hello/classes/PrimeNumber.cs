namespace study_hello.classes
{
    public class PrimeNumber
    {
        public void Start()
        {
            Console.Write("Please inform an integer number: ");
            IsPrime(int.Parse(Console.ReadLine()));
        }

        void IsPrime(int n)
        {
            int divisor = 0;
            int j = 1;
            while (j <= n)
            {
                divisor += n % j == 0 ? 1 : 0;
                j++;
            }

            Console.WriteLine("{0} {1} a prime number.", n,
                n == 1 || divisor == 2 ? "is" : "isn't"); 
        }
    }
}