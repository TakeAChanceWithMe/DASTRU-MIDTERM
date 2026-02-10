using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAGONIA_ACTIVITY_8
{
    internal class Songs
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Produced { get; set; }

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
            Console.WriteLine($"Year Produced: {Produced}");
        }
    }

    class PopMusic : Songs
    {
        public string Language { get; set; }

        public PopMusic(string title, string artist, int produced, string language)
            : base(title, artist, produced)
        {
            Language = language;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n--- Pop Music ---");
            Console.WriteLine($"Language: {Language}");
            base.DisplayInfo();
        }
    }

    class RockMusic : Songs
    {
        public string Instrument { get; set; }

        public RockMusic(string title, string artist, int produced, string instrument)
            : base(title, artist, produced)
        {
            Instrument = instrument;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n--- Rock Music ---");
            Console.WriteLine($"Instrument: {Instrument}");
            base.DisplayInfo();
        }
    }
}
