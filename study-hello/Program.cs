using study_hello.classes;
using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Initial tests");
Menu();


static void Menu()
{
    int option = -1;
    
    while (option != 0)
    {   
        Console.Clear();        
        Console.WriteLine("\t 1. Invert two integers");
        Console.WriteLine("\t 2. Swap chars ");
        Console.WriteLine("\t 3. Is this a prime number?");
        Console.WriteLine("\t 4. Plus Minus");
        Console.WriteLine("\t 5. Sum Min/Max");
        Console.WriteLine("\t 6. Time format conversion");
        Console.WriteLine("\t 7. Median");
        Console.WriteLine("\r\n\t 0. Quit");
        Console.Write("\r\n\tOption: ");
        string choice = Console.ReadLine();

        if (!int.TryParse(choice, out option)) 
        {
            Console.WriteLine("Invalid choice. Press ENTER");
            Console.ReadLine();
        }
        
        switch (option)
        {
            case 1: new InvertNumbers().Entry(); break;
            case 2: new SwapChar().Swap(); break;
            case 3: new PrimeNumber().Start(); break;
            case 4:
            {
                var arr = new int[5] {1, 1, 0, -1, -1};
                PlusMinus.plusMinus(arr.ToList());
                break;
            }
            case 5:
            {
                // var arr = new int[5] {1, 3, 2, 4, 5};
                var arr = new int[5] {1, 3, 5, 7, 9};
                HackerHank.minMaxSum(arr.ToList());
                break;
            }
            case 6: 
            {
                string s = "2:08:00PM";
                Console.WriteLine(s);
                Console.WriteLine(HackerHank.timeConversion(s)); 
                break;
            }
            case 7:
            {
                List<int> arr = (new int[] { 10, 12, 11}).ToList();
                Console.WriteLine(HackerHank.median(arr));
                break;

            }
            case 0: continue;

        }
        option = -1;
        Console.WriteLine("\r\nPress any key to continue");
        Console.ReadKey();
    }
}
