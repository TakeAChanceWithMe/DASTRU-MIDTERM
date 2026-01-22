using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAGONIA_ACTIVITY_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Jack Anthony D. Yagonia
            //Problem: Inserting Nodes to the Linked List

            // Declarating the Linked List
            LinkedList<string> friendsList = new LinkedList<string>();
            int numberOfFriends;

            // Input Section
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("LINKED LIST PROGRAM - Names of my friends\n\n");

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter number of friends (5 to 10 entries only): ");
                numberOfFriends = int.Parse(Console.ReadLine());

                if (numberOfFriends < 5 || numberOfFriends > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number between 5 and 10.");
                    Console.ResetColor();
                }

            } while (numberOfFriends < 5 || numberOfFriends > 10);

            // Insertion Section
            for (int i = 1; i <= numberOfFriends; i++)
            {
                Array.Sort(friendsList.ToArray());
                Console.Write($"Enter first name of friend #{i}: ");
                string name = Console.ReadLine();

                friendsList.AddLast(name);
               
            }

            // Sorting of output
            List<string> temporaryList = new List<string>(friendsList);
            temporaryList.Sort(); //A-Z 

            friendsList.Clear(); // Clears the original linked list(unsorted entries) and is replaced with the sorted entries form the temporary list

            foreach (string name in temporaryList)
            {
                friendsList.AddLast(name);
            }

            // Display Section
            Console.WriteLine("\nYour friends base from your entries (Linked List Sorted Entries):");
            Console.WriteLine("");

            foreach (string friend in friendsList)
            {
                Console.WriteLine(friend);
            }
            Console.ReadKey();
            //End of Program hehe
        }
    }
}
