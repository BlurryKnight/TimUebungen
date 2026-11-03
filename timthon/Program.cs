using System.Diagnostics.CodeAnalysis;
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

                Aufgabe2();

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

        static void Aufgabe2()
        {
            int totalSum = 0;
            int bullshitSum = 0;

            Console.WriteLine("Input upper bound");
            Console.Write('>');
            
            if (int.TryParse(Console.ReadLine(), out int n) && n > 2)
            {
                totalSum = GetSum(n);

                int i = 0;

                for (i = 2; i < n + 1; i++)
                {

                    if (i % 2 == 0)
                    {
                        if (i % 3 == 0)
                        {
                            continue;
                        }
                        bullshitSum += i;
                    }

                }

                i = 0;
                int maxN = 0;
                while (true)
                {
                    if (GetSum(i) > n)
                    {
                        maxN = i;
                        break;
                    }
                    i++;
                }

                Console.WriteLine("Upper bound :" + n);
                Console.WriteLine("Total sum: " + totalSum);
                Console.WriteLine("Bullshit sum: " + bullshitSum);
                Console.WriteLine("Limit: " + maxN);
            }
        }

        static int GetSum(int upperBound)
        {
            int sum = 0;
            int i = 0;
            while (i < upperBound+1)
            {
                sum += i;
                i++;
            }
            return sum;
        }
    }
}
