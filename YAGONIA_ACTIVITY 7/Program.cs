using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAGONIA_ACTIVITY_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare Linked List
            LinkedList<string> friendsList = new LinkedList<string>();
            int numberOfFriends = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("LINKED LIST PROGRAM - Names of my friends\n");
            Console.ResetColor();

            // Input Section with Try & Catch
            do
            {
                try
                {
                    Console.Write("Enter number of friends (5 to 10 entries only): ");
                    numberOfFriends = int.Parse(Console.ReadLine());

                    if (numberOfFriends < 5 || numberOfFriends > 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter a number between 5 and 10.\n");
                        Console.ResetColor();
                        numberOfFriends = 0; 
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid number.\n");
                    Console.ResetColor();
                    numberOfFriends = 0; 
                }
            } while (numberOfFriends < 5 || numberOfFriends > 10);

            // Insertion
            for (int i = 1; i <= numberOfFriends; i++)
            {
                Console.Write($"Enter first name of friend #{i}: ");
                string name = Console.ReadLine();
                friendsList.AddLast(name);
            }

            // Sorting via array 
            string[] friendsArray = new string[friendsList.Count];
            int index = 0;
            foreach (string friend in friendsList)  
            {
                friendsArray[index++] = friend;
            }

            Array.Sort(friendsArray); // A-Z sorting

            // Clear original list and insert sorted names
            friendsList.Clear();
            foreach (string friend in friendsArray)
            {
                friendsList.AddLast(friend);
            }

            // Display
            Console.WriteLine("\nYour friends based on your entries (Linked List Sorted Entries):\n");
            foreach (string friend in friendsList)
            {
                Console.WriteLine(friend);
            }
            Console.ReadKey();
        }
    }
}
