using study_hello.classes;

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
        Console.WriteLine("\r\n\t 0. Quit");
        Console.Write("\r\nOption: ");
        string choice = Console.ReadLine();

        if (!int.TryParse(choice, out option)) {
            Console.WriteLine("Invalid choice. Press ENTER");
            Console.ReadLine();
        }
        
        switch (option)
        {
            case 1: new InvertNumbers().Entry(); break;
            case 0: continue;

        }
        option = -1;     
    }
}