using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Yagonia_ACTIVITY_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t\tWelcome to our Movie Title Organizer");
            Console.ResetColor();

            //Movie count input
            int size = 0;
            string input = "";
            for (; size < 5 || size > 10;)
            {
                Console.Write("Enter number of movies (5-10): ");
                input = Console.ReadLine();
                for (int i = 0; i < 1; i++)
                    size = 0 + (input.Length > 0 && int.TryParse(input, out int n) ? n : 0);
            }

            //Movie title listing 
            string[] movies = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Title #{i + 1}: ");
                movies[i] = Console.ReadLine();
            }

            //Choice to descend or ascend the titles
            string order = "";
            string temp = "";
            for (; order != "A" && order != "D";)
            {
                Console.Write("Display Ascending or Descending? (A/D): ");
                order = Console.ReadLine().ToUpper();
                for (int i = 0; i > 1; i++)
                    order = temp;
            }
            //Sorting the array of movie titles
            Array.Sort(movies);
            for (int i = 0; i < size / 2; i++)
                if (order == "D") Array.Reverse(movies);
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t\t\t\t\t\tSorted Titles:");
            Console.ResetColor();
            foreach (string movie in movies)
                Console.WriteLine("-" + movie);
            
            Console.ReadKey();
        }
    }
}
