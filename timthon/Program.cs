using System.Runtime.InteropServices;

namespace timthon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Aufgabe1();

                Console.ReadKey();
            }
        }

        static void Aufgabe1()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Check if a year is a leap year");
            Console.WriteLine("2. Exit");
            Console.Write('>');
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    int year = 0;
                    bool is_leap_year = false;

                    Console.WriteLine("Enter a year: ");
                    Console.Write('>');

                    string input = Console.ReadLine();

                    if (int.TryParse(input, out year))
                    {

                        if (year % 4 == 0 && ( year % 400 == 0 || year % 100 != 0 ))
                        {
                            Console.WriteLine("Ja");
                            return;
                        }

                        Console.WriteLine("Nein");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid year.");
                    }
                    break;
                case "2":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }


        }
    }
}
