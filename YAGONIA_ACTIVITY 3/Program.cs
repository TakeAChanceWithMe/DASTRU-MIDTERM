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
            //Creation of two-Dimensional Array for Songs objects
            Songs[,] songs = new Songs[3,3];

            //Values for Pop music
            Console.ForegroundColor = ConsoleColor.Yellow;
            songs[0,0] = new PopMusic("Golden", "Jessa Esquirdo", 2025, "English");
            songs[0,1] = new PopMusic("Fashion", "Cortis", 2025, "Korean");
            songs[0,2] = new PopMusic("Despacito", "Luis Fonsi", 2016, "Spanish");
            

            //Values for Rock music
            songs[1,0] = new RockMusic("Master of Puppets", "Metallica", 1986, "Electric Guitar");
            songs[1,1] = new RockMusic("Given Up", "Linkin Park", 2008, "Bass Guitar");
            songs[1,2] = new RockMusic("Highway to Hell", "AC/DC", 1979, "Drums");

            //Repitition structure to display each song
           for (int i = 0; i < songs.GetLength(0); i++)
            {
                for (int j = 0; j < songs.GetLength(1); j++)
                {
                    songs[i, j]?.DisplayInfo();
                }
            }
           Console.ReadKey();

        }
    }
}
