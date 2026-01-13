using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yagonia_ACTIVITY3_2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //This program demonstrates the use of a 2D array in C#
            string[,] section = new string[3, 4]
            {
                {"\nRow 1\tIT401P - Yap", "\t\tIT402P - Juarez", "\t\tIT403P - Soberano", "\t\tIT404P - Minaj"},
                {"Row 2\tMM401P - Pepito", "\tMM402P - Marquez", "\t\tMM403P - Gomez", "\t\t\tMM404P - Grande"},
                {"Row 3\tTM101P - Salvo", "\t\tTM102P - Zefanya", "\t\tTM103P - Mendez", "\t\tTM104P - Pomoy"}
            };

            //Display sections
            Console.WriteLine("Sections with the smartest students base on the course that they're in:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t  Column 1:\t\t" + "   Column 2:\t\t\t" + "   Column 3:\t\t\t" + "   Column 4:\t");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < section.GetLength(0); i++)
            {
                for(int j = 0; j < section.GetLength(1); j++)
                {
                    Console.Write(section[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
