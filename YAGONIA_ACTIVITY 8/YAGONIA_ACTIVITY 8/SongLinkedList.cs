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

        public void Insert(Songs song)
        {
            songs.AddLast(song);
            Console.WriteLine("Song added successfully!");
        }

        public void Remove(string title)
        {
            var current = songs.First;

            while (current != null)
            {
                if (current.Value.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    songs.Remove(current);
                    Console.WriteLine("Song removed successfully!");
                    return;
                }
                current = current.Next;
            }

            Console.WriteLine("Song not found.");
        }

        public void Display()
        {
            if (songs.Count == 0)
            {
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
