using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace YAGONIA_ACTIVITY_2
{
    internal class Songs
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Produced { get; set; }

        //Parameterized Constructor
        public Songs(string title, string artist, int produced)
        {
            Title = title;
            Artist = artist;
            Produced = produced;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Produced: {Produced}");
        }
    }

    class PopMusic : Songs //Derived Class
    {
        public string Language { get; set; }

        //Parameterized Constructor
        public PopMusic(string title, string artist, int produced, string language) : base(title, artist, produced)
        {
            Language = language;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("\n---Pop Music Details---");
            Console.WriteLine($"Pop Music Language: {Language}");
            base.DisplayInfo();
        }
    }
    class RockMusic : Songs //Derived Class
    {
        public string Instruments { get; set; }

        //Parameterized Constructor
        public RockMusic(string title, string artist, int produced, string instruments) : base(title, artist, produced)
        {
            Instruments = instruments;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("\n---Rock Music Details---");
            Console.WriteLine($"Rock Music Instruments: {Instruments}");
            base.DisplayInfo();
        }
    }
}