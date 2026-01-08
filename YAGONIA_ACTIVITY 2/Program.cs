using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAGONIA_ACTIVITY_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs[] songs = new Songs[6];

            //Values for Pop music
            Console.ForegroundColor = ConsoleColor.Yellow;
            songs[0] = new PopMusic("Golden", "Jessa Esquirdo", 2025, "English");
            songs[1] = new PopMusic("Fashion", "Cortis", 2025, "Korean");
            songs[2] = new PopMusic("Despacito", "Luis Fonsi", 2016, "Spanish");
            

            //Values for Rock music
            songs[3] = new RockMusic("Master of Puppets", "Metallica", 1986, "Electric Guitar");
            songs[4] = new RockMusic("Given Up", "Linkin Park", 2008, "Bass Guitar");
            songs[5] = new RockMusic("Highway to Hell", "AC/DC", 1979, "Drums");

            //Repitition structure to display each song
           foreach (var song in songs)
            {
                song.Display();
            }

            Console.ReadKey();
        }
    }
}
