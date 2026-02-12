using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAGONIA_ACTIVITY_8
{
    internal class SongLinkedList
    {
        private LinkedList<Songs> songs = new LinkedList<Songs>();

        public void InsertSongs(Songs song)
        {
            songs.AddLast(song);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Song added successfully!");
            
        }


        public void Remove(string title)
        {
            var node = songs.First;

            while (node != null)
            {
                if (node.Value.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    songs.Remove(node);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Song removed successfully!");
                    return;
                }
                node = node.Next;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Song not found.");
        }

        public void Display()
        {
            if (songs.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No songs available.");
                return;
            }

            foreach (Songs song in songs)
            {
                song.DisplayInfo();
            }
        }
    }
}
