using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAGONIA_ACTIVITY_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jack Anthony D. Yagonia
            // ACTIVITY 6 – Linked List with OOP

            SongLinkedList list = new SongLinkedList();
            bool running = true;

            Console.WriteLine("=== MUSIC ENTRY PROGRAM ===");

            while (running)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Pop Music");
                Console.WriteLine("2. Add Rock Music");
                Console.WriteLine("3. Remove Song");
                Console.WriteLine("4. Display Songs");
                Console.WriteLine("5. Exit");
                Console.ResetColor();

                int choice = UserInput.GetInt("Enter choice: ");

                if (choice == 1)
                {
                    string title = UserInput.GetString("Title: ");
                    string artist = UserInput.GetString("Artist: ");
                    int year = UserInput.GetInt("Year Produced: ");
                    string language = UserInput.GetString("Language: ");

                    list.Insert(new PopMusic(title, artist, year, language));
                }
                else if (choice == 2)
                {
                    string title = UserInput.GetString("Title: ");
                    string artist = UserInput.GetString("Artist: ");
                    int year = UserInput.GetInt("Year Produced: ");
                    string instrument = UserInput.GetString("Instrument: ");

                    list.Insert(new RockMusic(title, artist, year, instrument));
                }
                else if (choice == 3)
                {
                    string title = UserInput.GetString("Enter title to remove: ");
                    list.Remove(title);
                }
                else if (choice == 4)
                {
                    list.Display();
                }
                else if (choice == 5)
                {
                    running = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice.");
                    Console.ResetColor();
                }
            }

            Console.WriteLine("\nThank you for using the Music Program!");
            Console.ReadKey();
        }
    }
}
