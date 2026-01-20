using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace YAGONIA_ACT_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Jack Anthony D. Yagonia
            //ACTIVITY 5: Customize a User-Input Method
            Songs[,] songs = new Songs[2, 3]; // 2 rows: 0=Pop, 1=Rock, 3 songs per row
            int[] songCount = new int[2];      // track how many songs entered per category

            Console.WriteLine("=== MUSIC ENTRY PROGRAM ===");

            while (songCount[0] < 3 || songCount[1] < 3) // Continue until all slots are filled
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nChoose Music Category:");
                Console.WriteLine("1. Add Pop Music");
                Console.WriteLine("2. Add Rock Music");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1") // Pop
                {
                    if (songCount[0] >= 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You already entered 3 Pop songs. Choose Rock.");
                        Console.ResetColor();
                        continue;
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n--- Enter Pop Music ---");

                    int j = songCount[0]; // next free slot
                    Console.Write("Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Artist: ");
                    string artist = Console.ReadLine();

                    Console.Write("Year Produced: ");
                    int produced = int.Parse(Console.ReadLine());

                    Console.Write("Language: ");
                    string language = Console.ReadLine();

                    songs[0, j] = new PopMusic(title, artist, produced, language);
                    songCount[0]++;
                    Console.WriteLine("Pop music added successfully!");
                }
                else if (choice == "2") // Rock
                {
                    if (songCount[1] >= 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You already entered 3 Rock songs. Choose Pop.");
                        Console.ResetColor();
                        continue;
                    }

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n--- Enter Rock Music ---");

                    int j = songCount[1]; // next free slot
                    Console.Write("Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Artist: ");
                    string artist = Console.ReadLine();

                    Console.Write("Year Produced: ");
                    int produced = int.Parse(Console.ReadLine());

                    Console.Write("Instrument: ");
                    string instrument = Console.ReadLine();

                    songs[1, j] = new RockMusic(title, artist, produced, instrument);
                    songCount[1]++;
                    Console.WriteLine("Rock music added successfully!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice! Enter 1 or 2.");
                }

                Console.ResetColor();
            }

            // After all songs entered, display them using foreach
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- POP MUSIC ---");
            foreach (Songs song in songs)
            {
                if (song is PopMusic) // only display Pop songs in the Pop section
                    song.DisplayInfo();
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n--- ROCK MUSIC ---");
            foreach (Songs song in songs)
            {
                if (song is RockMusic) // only display Rock songs in the Rock section
                    song.DisplayInfo();
            }

            Console.ResetColor();
            Console.WriteLine("\nThank you for using the Music Program!");
            Console.ReadKey();
        }
    }
}


