using System;

namespace CustomStringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicTrack track = new MusicTrack("Jimi Hendrix", "Electric Ladyland", "1967");
            Console.WriteLine("Artist: {0:A}", track);
            Console.WriteLine("Title: {0:T}", track);
            Console.WriteLine("Year: {0:Y}", track);
            Console.WriteLine("Default: {0:D}", track);
            Console.WriteLine("Full: {0:F}", track);
            Console.WriteLine("Not specified:" + track);
        }
    }
}
